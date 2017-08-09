using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department_Store
{
    public partial class new_login : Form
    {
        string Staff_ID;
        string myconn = "datasource=localhost;port=3306;username=root;password=";
        MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
        MySqlConnection Con;  

        public new_login()
        {
            InitializeComponent();
        }

        public new_login(string ID)
        {
            Staff_ID = ID;
            InitializeComponent();
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            if (this.username_text.Text == "" && this.password_text.Text == "")
            {
                MessageBox.Show("Please Enter New Username AND Password", "USERNAME & PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (this.password_text.Text == "" && this.username_text.Text != "")
            {
                MessageBox.Show("Please Enter New Password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (this.password_text.Text != "" && this.username_text.Text == "")
            {
                MessageBox.Show("Please Enter New Username", "Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (this.username_text.Text != "" && this.password_text.Text != "" && this.status.Text == "")
            {
                Con = new MySqlConnection(myconn);
                MySqlCommand command = new MySqlCommand("INSERT INTO department_store.login VALUES('" + this.username_text.Text + "', '" + this.password_text.Text + "','" + Staff_ID + "');", Con);
                try
                {
                    Con.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
                add_staff form = new add_staff();
                //form.addStaff();
                form.getStatus();
                this.Close();
            } 
        }

        private void password_text_Enter(object sender, EventArgs e)
        {
            string username;
            Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("SELECT username FROM department_store.login;", Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    username = myReader.GetString("username");
                    if (this.username_text.Text == username)
                    {
                        this.status.Text = "Username Already Exists!!";
                    }
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }
    }
}
