namespace Department_Store
{
    partial class edit_customer
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
            this.Message = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.cust_address = new System.Windows.Forms.TextBox();
            this.cust_contact = new System.Windows.Forms.TextBox();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CustomerView = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(151, 218);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 13);
            this.Message.TabIndex = 71;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(101, 162);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "EDIT";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // cust_address
            // 
            this.cust_address.Location = new System.Drawing.Point(152, 112);
            this.cust_address.Name = "cust_address";
            this.cust_address.Size = new System.Drawing.Size(180, 20);
            this.cust_address.TabIndex = 5;
            // 
            // cust_contact
            // 
            this.cust_contact.Location = new System.Drawing.Point(152, 81);
            this.cust_contact.Name = "cust_contact";
            this.cust_contact.Size = new System.Drawing.Size(180, 20);
            this.cust_contact.TabIndex = 4;
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(152, 54);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(180, 20);
            this.cust_name.TabIndex = 3;
            this.cust_name.TextChanged += new System.EventHandler(this.cust_name_TextChanged);
            // 
            // cust_id
            // 
            this.cust_id.Location = new System.Drawing.Point(152, 26);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(180, 20);
            this.cust_id.TabIndex = 2;
            this.cust_id.Click += new System.EventHandler(this.cust_id_Click);
            this.cust_id.TextChanged += new System.EventHandler(this.cust_id_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "ADDRESS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "CONTACT_NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "ID";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(206, 162);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Keyword";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(215, 71);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(121, 20);
            this.search.TabIndex = 1;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer ID",
            "Name",
            "Address",
            "Phone Num"});
            this.comboBox1.Location = new System.Drawing.Point(215, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CustomerView
            // 
            this.CustomerView.AllowUserToAddRows = false;
            this.CustomerView.AllowUserToDeleteRows = false;
            this.CustomerView.AllowUserToResizeRows = false;
            this.CustomerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerView.Location = new System.Drawing.Point(6, 125);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.ReadOnly = true;
            this.CustomerView.ShowEditingIcon = false;
            this.CustomerView.Size = new System.Drawing.Size(465, 356);
            this.CustomerView.TabIndex = 57;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(645, 314);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 8;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Search By";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CustomerView);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 523);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH CUSTOMER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Message);
            this.groupBox2.Controls.Add(this.cust_id);
            this.groupBox2.Controls.Add(this.edit_btn);
            this.groupBox2.Controls.Add(this.delete_btn);
            this.groupBox2.Controls.Add(this.cust_address);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cust_contact);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cust_name);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(493, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 253);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EDIT CUSTOMER";
            // 
            // edit_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.back_btn);
            this.Name = "edit_customer";
            this.Text = "EDIT CUSTOMER INFO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.edit_customer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox cust_address;
        private System.Windows.Forms.TextBox cust_contact;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView CustomerView;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}