using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Department_Store
{
    public partial class login_form : Form
    {   
        public login_form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string staffid;
                int count = 0;
                string myconn = "datasource=localhost;port=3306;username=root;password=";
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                MySqlConnection Con = new MySqlConnection(myconn);
                MySqlCommand command = new MySqlCommand("SELECT * from department_store.login WHERE Username='" + this.username_box.Text + "' AND Password = '" + this.password_box.Text + "' ;", Con);
                MySqlDataReader myReader;
            try{
                Con.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    count = 1;
                }
                if (count == 1)
                {
                    staffid = myReader.GetString("staff_id");
                    this.Hide();
                    main_page form2 = new main_page(staffid);
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password","Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
