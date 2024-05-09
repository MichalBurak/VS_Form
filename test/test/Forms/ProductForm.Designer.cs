namespace test
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productNameLable = new Label();
            productName = new TextBox();
            priceLable = new Label();
            price = new TextBox();
            cancel = new Button();
            Confirm = new Button();
            weightTypeLabel = new Label();
            weightTypeKg = new RadioButton();
            weightTypeL = new RadioButton();
            WeightLabel = new Label();
            weight = new TextBox();
            CheckYes = new CheckBox();
            invoiceCheckYes = new Label();
            numberOfLable = new Label();
            activityLable = new Label();
            activityYesRadioButton = new RadioButton();
            activityNoRadioButton = new RadioButton();
            weightTypeSzt = new RadioButton();
            weightTypeGroupBox = new GroupBox();
            activityGroupBox = new GroupBox();
            countryComboBox = new ComboBox();
            countryComboBoxLabel = new Label();
            dateTimePicker = new DateTimePicker();
            dateLable = new Label();
            numberOf = new TextBox();
            weightTypeGroupBox.SuspendLayout();
            activityGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // productNameLable
            // 
            productNameLable.AutoSize = true;
            productNameLable.Location = new Point(27, 26);
            productNameLable.Name = "productNameLable";
            productNameLable.Size = new Size(120, 20);
            productNameLable.TabIndex = 0;
            productNameLable.Text = "Nazwa Produktu:";
            // 
            // productName
            // 
            productName.Location = new Point(185, 23);
            productName.Name = "productName";
            productName.Size = new Size(125, 27);
            productName.TabIndex = 1;
            // 
            // priceLable
            // 
            priceLable.AutoSize = true;
            priceLable.Location = new Point(27, 59);
            priceLable.Name = "priceLable";
            priceLable.Size = new Size(45, 20);
            priceLable.TabIndex = 2;
            priceLable.Text = "Cena:";
            // 
            // price
            // 
            price.Location = new Point(185, 56);
            price.Name = "price";
            price.Size = new Size(125, 27);
            price.TabIndex = 3;
            // 
            // cancel
            // 
            cancel.Location = new Point(26, 396);
            cancel.Name = "cancel";
            cancel.Size = new Size(115, 28);
            cancel.TabIndex = 4;
            cancel.Text = "Anuluj";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // Confirm
            // 
            Confirm.Location = new Point(185, 396);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(125, 28);
            Confirm.TabIndex = 5;
            Confirm.Text = "Zatwierdz";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // weightTypeLabel
            // 
            weightTypeLabel.AutoSize = true;
            weightTypeLabel.Location = new Point(6, 23);
            weightTypeLabel.Name = "weightTypeLabel";
            weightTypeLabel.Size = new Size(115, 20);
            weightTypeLabel.TabIndex = 6;
            weightTypeLabel.Text = "Jednostka Wagi:";
            // 
            // weightTypeKg
            // 
            weightTypeKg.AutoSize = true;
            weightTypeKg.Location = new Point(126, 21);
            weightTypeKg.Name = "weightTypeKg";
            weightTypeKg.Size = new Size(48, 24);
            weightTypeKg.TabIndex = 7;
            weightTypeKg.TabStop = true;
            weightTypeKg.Text = "Kg";
            weightTypeKg.UseVisualStyleBackColor = true;
            // 
            // weightTypeL
            // 
            weightTypeL.AutoSize = true;
            weightTypeL.Location = new Point(180, 21);
            weightTypeL.Name = "weightTypeL";
            weightTypeL.Size = new Size(37, 24);
            weightTypeL.TabIndex = 8;
            weightTypeL.TabStop = true;
            weightTypeL.Text = "L";
            weightTypeL.UseVisualStyleBackColor = true;
            // 
            // WeightLabel
            // 
            WeightLabel.AutoSize = true;
            WeightLabel.Location = new Point(26, 153);
            WeightLabel.Name = "WeightLabel";
            WeightLabel.Size = new Size(50, 20);
            WeightLabel.TabIndex = 9;
            WeightLabel.Text = "Waga:";
            // 
            // weight
            // 
            weight.Location = new Point(185, 150);
            weight.Name = "weight";
            weight.Size = new Size(125, 27);
            weight.TabIndex = 10;
            // 
            // CheckYes
            // 
            CheckYes.AutoSize = true;
            CheckYes.Location = new Point(189, 183);
            CheckYes.Name = "CheckYes";
            CheckYes.Size = new Size(52, 24);
            CheckYes.TabIndex = 11;
            CheckYes.Text = "Tak";
            CheckYes.UseVisualStyleBackColor = true;
            // 
            // invoiceCheckYes
            // 
            invoiceCheckYes.AutoSize = true;
            invoiceCheckYes.Location = new Point(26, 184);
            invoiceCheckYes.Name = "invoiceCheckYes";
            invoiceCheckYes.Size = new Size(59, 20);
            invoiceCheckYes.TabIndex = 12;
            invoiceCheckYes.Text = "Faktura:";
            // 
            // numberOfLable
            // 
            numberOfLable.AutoSize = true;
            numberOfLable.Location = new Point(27, 215);
            numberOfLable.Name = "numberOfLable";
            numberOfLable.Size = new Size(42, 20);
            numberOfLable.TabIndex = 14;
            numberOfLable.Text = "Ilość:";
            // 
            // activityLable
            // 
            activityLable.AutoSize = true;
            activityLable.Location = new Point(6, 23);
            activityLable.Name = "activityLable";
            activityLable.Size = new Size(67, 20);
            activityLable.TabIndex = 15;
            activityLable.Text = "Aktywny:";
            // 
            // activityYesRadioButton
            // 
            activityYesRadioButton.AutoSize = true;
            activityYesRadioButton.Location = new Point(123, 21);
            activityYesRadioButton.Name = "activityYesRadioButton";
            activityYesRadioButton.Size = new Size(51, 24);
            activityYesRadioButton.TabIndex = 16;
            activityYesRadioButton.TabStop = true;
            activityYesRadioButton.Text = "Tak";
            activityYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // activityNoRadioButton
            // 
            activityNoRadioButton.AutoSize = true;
            activityNoRadioButton.Location = new Point(180, 21);
            activityNoRadioButton.Name = "activityNoRadioButton";
            activityNoRadioButton.Size = new Size(53, 24);
            activityNoRadioButton.TabIndex = 17;
            activityNoRadioButton.TabStop = true;
            activityNoRadioButton.Text = "Nie";
            activityNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // weightTypeSzt
            // 
            weightTypeSzt.AutoSize = true;
            weightTypeSzt.Location = new Point(223, 21);
            weightTypeSzt.Name = "weightTypeSzt";
            weightTypeSzt.Size = new Size(39, 24);
            weightTypeSzt.TabIndex = 18;
            weightTypeSzt.TabStop = true;
            weightTypeSzt.Text = "It";
            weightTypeSzt.UseVisualStyleBackColor = true;
            // 
            // weightTypeGroupBox
            // 
            weightTypeGroupBox.Controls.Add(weightTypeLabel);
            weightTypeGroupBox.Controls.Add(weightTypeSzt);
            weightTypeGroupBox.Controls.Add(weightTypeKg);
            weightTypeGroupBox.Controls.Add(weightTypeL);
            weightTypeGroupBox.Location = new Point(26, 89);
            weightTypeGroupBox.Name = "weightTypeGroupBox";
            weightTypeGroupBox.Size = new Size(284, 52);
            weightTypeGroupBox.TabIndex = 19;
            weightTypeGroupBox.TabStop = false;
            // 
            // activityGroupBox
            // 
            activityGroupBox.Controls.Add(activityLable);
            activityGroupBox.Controls.Add(activityYesRadioButton);
            activityGroupBox.Controls.Add(activityNoRadioButton);
            activityGroupBox.Location = new Point(26, 246);
            activityGroupBox.Name = "activityGroupBox";
            activityGroupBox.Size = new Size(284, 50);
            activityGroupBox.TabIndex = 20;
            activityGroupBox.TabStop = false;
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "Polska", "Francja", "Niemcy" });
            countryComboBox.Location = new Point(185, 302);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(125, 28);
            countryComboBox.TabIndex = 21;
            // 
            // countryComboBoxLabel
            // 
            countryComboBoxLabel.AutoSize = true;
            countryComboBoxLabel.Location = new Point(26, 305);
            countryComboBoxLabel.Name = "countryComboBoxLabel";
            countryComboBoxLabel.Size = new Size(126, 20);
            countryComboBoxLabel.TabIndex = 22;
            countryComboBoxLabel.Text = "Kraj Pochodzenia:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(26, 363);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(283, 27);
            dateTimePicker.TabIndex = 23;
            // 
            // dateLable
            // 
            dateLable.AutoSize = true;
            dateLable.Location = new Point(26, 340);
            dateLable.Name = "dateLable";
            dateLable.Size = new Size(48, 20);
            dateLable.TabIndex = 24;
            dateLable.Text = "Data: ";
            // 
            // numberOf
            // 
            numberOf.Location = new Point(184, 215);
            numberOf.Name = "numberOf";
            numberOf.Size = new Size(125, 27);
            numberOf.TabIndex = 25;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 446);
            Controls.Add(numberOf);
            Controls.Add(dateLable);
            Controls.Add(dateTimePicker);
            Controls.Add(countryComboBoxLabel);
            Controls.Add(countryComboBox);
            Controls.Add(activityGroupBox);
            Controls.Add(weightTypeGroupBox);
            Controls.Add(numberOfLable);
            Controls.Add(invoiceCheckYes);
            Controls.Add(CheckYes);
            Controls.Add(weight);
            Controls.Add(WeightLabel);
            Controls.Add(Confirm);
            Controls.Add(cancel);
            Controls.Add(price);
            Controls.Add(priceLable);
            Controls.Add(productName);
            Controls.Add(productNameLable);
            Name = "ProductForm";
            Text = "Produkt";
            weightTypeGroupBox.ResumeLayout(false);
            weightTypeGroupBox.PerformLayout();
            activityGroupBox.ResumeLayout(false);
            activityGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productNameLable;
        private TextBox productName;
        private Label priceLable;
        private TextBox price;
        private Button cancel;
        private Button Confirm;
        private Label weightTypeLabel;
        private RadioButton weightTypeKg;
        private RadioButton weightTypeL;
        private Label WeightLabel;
        private TextBox weight;
        private CheckBox CheckYes;
        private Label invoiceCheckYes;
        private Label numberOfLable;
        private Label activityLable;
        private RadioButton activityYesRadioButton;
        private RadioButton activityNoRadioButton;
        private RadioButton weightTypeSzt;
        private GroupBox weightTypeGroupBox;
        private GroupBox activityGroupBox;
        private ComboBox countryComboBox;
        private Label countryComboBoxLabel;
        private DateTimePicker dateTimePicker;
        private Label dateLable;
        private TextBox numberOf;
    }
}