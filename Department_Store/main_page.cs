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
    public partial class main_page : Form
    {
        string staffid;

        public main_page()
        {
            InitializeComponent();
        }

        public main_page(string getstaffid)
        {
            staffid = getstaffid;
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_product form = new add_product();
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form form = new login_form();
            form.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_info form = new Product_info(staffid);
            form.Show();

        }

        private void productUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_update form = new Product_update();
            form.Show();
        }

        private void main_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_staff form = new add_staff(staffid);
            form.Show();
        }

        private void staffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            modify_staff form = new modify_staff(staffid);
            form.Show();
        }

        private void main_page_Load(object sender, EventArgs e)
        {
            string designation="";
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT staff.Designation FROM department_store.staff, department_store.login where staff.Staff_ID = '"+staffid+"' AND login.staff_id = '"+staffid+"'";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    designation = myReader.GetString("Designation").ToLower();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (designation == "manager")
            {
                staffToolStripMenuItem.Visible = true;
            }
            else
                staffToolStripMenuItem.Visible = false;
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_customer form = new add_customer(staffid);
            form.Show();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_info form = new customer_info(staffid);
            form.Show();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit_customer form = new edit_customer(staffid);
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            billing fm = new billing(staffid);
            fm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            billing fm = new billing(staffid);
            fm.Show();
        }

        private void salesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_data form = new sales_data();
            form.Show();
        }
      
    }
}
