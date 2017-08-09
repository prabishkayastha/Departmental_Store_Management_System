namespace Department_Store
{
    partial class add_customer
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
            this.status = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.cust_address = new System.Windows.Forms.TextBox();
            this.cust_contact = new System.Windows.Forms.TextBox();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(107, 227);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 21;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(172, 280);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 20;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(50, 280);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 19;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cust_address
            // 
            this.cust_address.Location = new System.Drawing.Point(128, 119);
            this.cust_address.Name = "cust_address";
            this.cust_address.Size = new System.Drawing.Size(100, 20);
            this.cust_address.TabIndex = 18;
            // 
            // cust_contact
            // 
            this.cust_contact.Location = new System.Drawing.Point(128, 84);
            this.cust_contact.Name = "cust_contact";
            this.cust_contact.Size = new System.Drawing.Size(100, 20);
            this.cust_contact.TabIndex = 17;
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(128, 54);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(100, 20);
            this.cust_name.TabIndex = 16;
            // 
            // cust_id
            // 
            this.cust_id.Location = new System.Drawing.Point(128, 23);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(100, 20);
            this.cust_id.TabIndex = 15;
            this.cust_id.Click += new System.EventHandler(this.cust_id_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contact No ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer_id ";
            // 
            // add_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 362);
            this.Controls.Add(this.status);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.cust_address);
            this.Controls.Add(this.cust_contact);
            this.Controls.Add(this.cust_name);
            this.Controls.Add(this.cust_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_customer";
            this.Text = "ADD CUSTOMER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox cust_address;
        private System.Windows.Forms.TextBox cust_contact;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}