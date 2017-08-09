namespace Department_Store
{
    partial class new_login
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
            this.done_button = new System.Windows.Forms.Button();
            this.password_text = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(90, 139);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 11;
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(162, 111);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(75, 23);
            this.done_button.TabIndex = 10;
            this.done_button.Text = "DONE";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(162, 61);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(138, 20);
            this.password_text.TabIndex = 9;
            this.password_text.UseSystemPasswordChar = true;
            this.password_text.Enter += new System.EventHandler(this.password_text_Enter);
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(163, 26);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(138, 20);
            this.username_text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Setup New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Setup New Username:";
            // 
            // new_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 167);
            this.ControlBox = false;
            this.Controls.Add(this.status);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "new_login";
            this.Text = "NEW SIGNUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}