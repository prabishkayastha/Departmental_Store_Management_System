namespace Department_Store
{
    partial class add_product
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
            this.label2 = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name :";
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(174, 88);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(156, 20);
            this.product_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity :";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(174, 132);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(156, 20);
            this.Quantity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rate :";
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(174, 177);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(156, 20);
            this.Rate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manufacturer ID:";
            // 
            // manufacturer
            // 
            this.manufacturer.Location = new System.Drawing.Point(174, 219);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(156, 20);
            this.manufacturer.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categories :";
            // 
            // category
            // 
            this.category.AllowDrop = true;
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
            this.category.Location = new System.Drawing.Point(174, 42);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 13;
            this.category.Text = "None";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(151, 356);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 16);
            this.status.TabIndex = 16;
            // 
            // add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 393);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.label2);
            this.Name = "add_product";
            this.ShowIcon = false;
            this.Text = "ADD PRODUCT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_product_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label status;
    }
}