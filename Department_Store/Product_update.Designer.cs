namespace Department_Store
{
    partial class Product_update
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
            this.label4 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.current_quant = new System.Windows.Forms.Label();
            this.old_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // category
            // 
            this.category.AllowDrop = true;
            this.category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "beverage",
            "bakery",
            "cereal ",
            "chocolate",
            "dairy",
            "grains",
            "jarred__canned",
            "junk__food",
            "toiletaries"});
            this.category.Location = new System.Drawing.Point(173, 33);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(100, 21);
            this.category.TabIndex = 0;
            this.category.Text = "None";
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(89, 325);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(173, 73);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(100, 20);
            this.product_name.TabIndex = 1;
            this.product_name.Click += new System.EventHandler(this.product_name_Click);
            this.product_name.TextChanged += new System.EventHandler(this.product_name_TextChanged_1);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(173, 112);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 20);
            this.Quantity.TabIndex = 2;
            this.Quantity.Click += new System.EventHandler(this.Quantity_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(173, 153);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 3;
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Location = new System.Drawing.Point(46, 258);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.UpdateProduct.TabIndex = 30;
            this.UpdateProduct.Text = "UPDATE";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(173, 258);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 31;
            this.deleteProduct.Text = "DELETE";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(298, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // current_quant
            // 
            this.current_quant.AutoSize = true;
            this.current_quant.Location = new System.Drawing.Point(304, 119);
            this.current_quant.Name = "current_quant";
            this.current_quant.Size = new System.Drawing.Size(0, 13);
            this.current_quant.TabIndex = 34;
            // 
            // old_price
            // 
            this.old_price.AutoSize = true;
            this.old_price.Location = new System.Drawing.Point(304, 160);
            this.old_price.Name = "old_price";
            this.old_price.Size = new System.Drawing.Size(0, 13);
            this.old_price.TabIndex = 35;
            // 
            // Product_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 359);
            this.Controls.Add(this.status);
            this.Controls.Add(this.old_price);
            this.Controls.Add(this.current_quant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label4);
            this.Name = "Product_update";
            this.Text = "Product_update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Product_update_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label current_quant;
        private System.Windows.Forms.Label old_price;
 
    }
}