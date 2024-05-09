using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Entity;
using test.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test
{
    public partial class ProductForm : Form
    {
        MainForms mainForms;
        public int id = 0;
        private FormTypeEnum formType;
        public Product product;

        SortedDictionary<string, int> userCache = new SortedDictionary<string, int>
        {
            {"Polska", 1},
            {"Francja", 2},
            {"Niemcy", 3}
        };
        

        public ProductForm(MainForms mainForms, FormTypeEnum formType , Product product = null)
        {
            InitializeComponent();
            this.mainForms = mainForms;
            this.formType = formType;
            this.product = product;
            countryComboBox.DataSource = new BindingSource(userCache, null);
            countryComboBox.DisplayMember = "Key";
            countryComboBox.ValueMember = "Value";
            if(formType == FormTypeEnum.Creation)
            {
                weightTypeKg.Checked = true;
                activityYesRadioButton.Checked = true;
            }
            else
            {
                productName.Text = product.name;
                price.Text = product.price.ToString();
                setProductUnit(product);
                weight.Text = product.weight.ToString();
                CheckYes.Checked = product.invoice;
                numberOf.Text = product.quantity.ToString();
                setActivity(product);
                countryComboBox.Text = product.countries;
                dateTimePicker.Value = product.date;

            }
        }

        

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            if(!validate())
            {
                return;
            }
            if(this.formType == FormTypeEnum.Edit)
            {
                
                //product.id = id;
                this.product.name = productName.Text;
                this.product.price = float.Parse(price.Text);
                this.product.unit = getProductUnit();
                this.product.weight = float.Parse(weight.Text);
                this.product.invoice = CheckYes.Checked;
                this.product.quantity = Int32.Parse(numberOf.Text);
                this.product.activity = activityYesRadioButton.Checked;
                this.product.countries = countryComboBox.Text;
                this.product.date = dateTimePicker.Value;

            }
            else
            {
                id++;
                Product product = new Product();
                product.id = id;
                product.name = productName.Text;
                product.price = float.Parse(price.Text);
                product.unit = getProductUnit();
                product.weight = float.Parse(weight.Text);
                product.invoice = CheckYes.Checked;
                product.quantity = Int32.Parse(numberOf.Text);
                product.activity = activityYesRadioButton.Checked;
                product.countries = countryComboBox.Text;
                product.date = dateTimePicker.Value;
                this.mainForms.addProduct(product);

            }
            

            

            this.Dispose();
        }

        private bool validate()
        {
            if (productName.Text == "")
            {
                MessageBox.Show("Nie podano nazwy produktu");
                return false;
            }
            try
            {
                float.Parse(price.Text);
            }
            catch
            {
                MessageBox.Show("Podano złą wartość w cenie");
                return false;          
            }
            try
            {
                float.Parse(weight.Text);
            }
            catch
            {
                MessageBox.Show("Podano złą wartość w wadze");
                return false;
            }
            try
            {
                Int32.Parse(numberOf.Text);
            }
            catch
            {
                MessageBox.Show("Podano złą wartość w ilości");
                return false;
            }
            return true;

        }

        private ProductUnitEnum getProductUnit()
        {
            if (weightTypeKg.Checked)
            {
                return Enums.ProductUnitEnum.Kg;
            }
            else if (weightTypeL.Checked)
            {
                return Enums.ProductUnitEnum.L;
            }
            else
            {
                return Enums.ProductUnitEnum.It;
            }
        }
        private void setProductUnit(Product product)
        {
            if (product.unit == ProductUnitEnum.Kg)
            {
                weightTypeKg.Checked = true;
            }
            else if (product.unit == ProductUnitEnum.L)
            {
                weightTypeL.Checked = true;
            }
            else
            {
                weightTypeSzt.Checked = true;
            }
        }
        private void setActivity(Product product)
        {
            if(product.activity)
            {
                activityYesRadioButton.Checked = true;
            }
            else
            {
                activityNoRadioButton.Checked = true;
            }
        }
    }
}
