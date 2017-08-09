namespace Department_Store
{
    partial class customer_info
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
            this.search = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CustomerView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Keyword";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(272, 45);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(125, 20);
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
            this.comboBox1.Location = new System.Drawing.Point(272, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
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
            this.CustomerView.Location = new System.Drawing.Point(0, 112);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.ReadOnly = true;
            this.CustomerView.ShowEditingIcon = false;
            this.CustomerView.Size = new System.Drawing.Size(599, 378);
            this.CustomerView.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search By";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(494, 78);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // customer_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 490);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CustomerView);
            this.Controls.Add(this.label1);
            this.Name = "customer_info";
            this.Text = "CUSTOMER INFO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.customer_info_FormClosed);
            this.Load += new System.EventHandler(this.customer_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView CustomerView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}