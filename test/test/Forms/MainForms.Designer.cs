namespace test
{
    partial class MainForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bProductCreate = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // bProductCreate
            // 
            bProductCreate.Location = new Point(26, 225);
            bProductCreate.Name = "bProductCreate";
            bProductCreate.Size = new Size(114, 42);
            bProductCreate.TabIndex = 0;
            bProductCreate.Text = "Produkt";
            bProductCreate.UseVisualStyleBackColor = true;
            bProductCreate.Click += bProductCreate_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(26, 273);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(991, 331);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // MainForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(dgvProducts);
            Controls.Add(bProductCreate);
            Name = "MainForms";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bProductCreate;
        private DataGridView dgvProducts;
    }
}
