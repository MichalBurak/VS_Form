using test.Entity;
using static System.Windows.Forms.Design.AxImporter;

namespace test
{
    public partial class MainForms : Form
    {
        List<Product> products;
        ProductForm productForm;
        public MainForms()
        {
            InitializeComponent();
            this.products = new List<Product>();

        }
        private void bProductCreate_Click(object sender, EventArgs e)
        {
            if (productForm == null || productForm.Text == "")
            {
                productForm = new ProductForm(this, Enums.FormTypeEnum.Creation);
            }
            productForm.ShowDialog();
        }

        public void addProduct(Product product)
        {
            this.products.Add(product);
            loadProductsToDataGride();
        }
        public void loadProductsToDataGride()
        {
            this.dgvProducts.DataSource = new BindingSource(products, null);

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvProducts.CurrentRow.Index;
            Product product = this.products[index];
            ProductForm form = new ProductForm(this, Enums.FormTypeEnum.Edit, product);
            form.ShowDialog();
            loadProductsToDataGride();
        }
    }
}

