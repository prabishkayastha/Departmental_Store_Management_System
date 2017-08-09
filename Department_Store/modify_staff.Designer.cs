namespace Department_Store
{
    partial class modify_staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modify_staff));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.staff_name = new System.Windows.Forms.TextBox();
            this.staff_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchStaff = new System.Windows.Forms.TextBox();
            this.SearchByCategory = new System.Windows.Forms.Label();
            this.SearchByName = new System.Windows.Forms.Label();
            this.StaffGrid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "MODIFY DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(145, 234);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 20);
            this.salary.TabIndex = 5;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(145, 191);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 4;
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(145, 147);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(100, 20);
            this.phone_number.TabIndex = 3;
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(145, 107);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(100, 20);
            this.designation.TabIndex = 2;
            // 
            // staff_name
            // 
            this.staff_name.Location = new System.Drawing.Point(145, 63);
            this.staff_name.Name = "staff_name";
            this.staff_name.Size = new System.Drawing.Size(100, 20);
            this.staff_name.TabIndex = 1;
            this.staff_name.TextChanged += new System.EventHandler(this.staff_name_TextChanged);
            // 
            // staff_id
            // 
            this.staff_id.Location = new System.Drawing.Point(145, 20);
            this.staff_id.Name = "staff_id";
            this.staff_id.Size = new System.Drawing.Size(100, 20);
            this.staff_id.TabIndex = 0;
            this.staff_id.Click += new System.EventHandler(this.staff_id_Click);
            this.staff_id.TextChanged += new System.EventHandler(this.staff_id_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Deisgnation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Staff Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Staff ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.SearchStaff);
            this.groupBox2.Controls.Add(this.SearchByCategory);
            this.groupBox2.Controls.Add(this.SearchByName);
            this.groupBox2.Controls.Add(this.StaffGrid);
            this.groupBox2.Location = new System.Drawing.Point(278, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 6355);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STAFF SEARCH";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Staff ID",
            "Staff Name",
            "Designation ",
            "Phone Num",
            "Address",
            "Salary"});
            this.comboBox1.Location = new System.Drawing.Point(74, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(421, 9);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(86, 35);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchStaff
            // 
            this.SearchStaff.Location = new System.Drawing.Point(300, 22);
            this.SearchStaff.Name = "SearchStaff";
            this.SearchStaff.Size = new System.Drawing.Size(100, 20);
            this.SearchStaff.TabIndex = 9;
            // 
            // SearchByCategory
            // 
            this.SearchByCategory.AutoSize = true;
            this.SearchByCategory.Location = new System.Drawing.Point(248, 25);
            this.SearchByCategory.Name = "SearchByCategory";
            this.SearchByCategory.Size = new System.Drawing.Size(51, 13);
            this.SearchByCategory.TabIndex = 3;
            this.SearchByCategory.Text = "Keyword:";
            // 
            // SearchByName
            // 
            this.SearchByName.AutoSize = true;
            this.SearchByName.Location = new System.Drawing.Point(6, 25);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(59, 13);
            this.SearchByName.TabIndex = 1;
            this.SearchByName.Text = "Search By:";
            // 
            // StaffGrid
            // 
            this.StaffGrid.AllowUserToAddRows = false;
            this.StaffGrid.AllowUserToDeleteRows = false;
            this.StaffGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.StaffGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StaffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StaffGrid.Location = new System.Drawing.Point(0, 50);
            this.StaffGrid.Name = "StaffGrid";
            this.StaffGrid.ReadOnly = true;
            this.StaffGrid.ShowEditingIcon = false;
            this.StaffGrid.Size = new System.Drawing.Size(514, 6293);
            this.StaffGrid.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "DELETE DATA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(27, 361);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 13);
            this.Message.TabIndex = 32;
            // 
            // modify_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 502);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.staff_name);
            this.Controls.Add(this.staff_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modify_staff";
            this.Text = "MODIFY STAFF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.modify_staff_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.TextBox staff_name;
        private System.Windows.Forms.TextBox staff_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchStaff;
        private System.Windows.Forms.Label SearchByCategory;
        private System.Windows.Forms.Label SearchByName;
        private System.Windows.Forms.DataGridView StaffGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Message;
    }
}