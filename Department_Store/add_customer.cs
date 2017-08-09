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
    public partial class add_customer : Form
    {
        string staffid;
        public add_customer()
        {
            InitializeComponent();
        }
        public add_customer(string getStaffID)
        {
            staffid = getStaffID;
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page fm = new main_page(staffid);
            fm.Show();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int count = 0;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("INSERT INTO department_store.customer values('" + this.cust_id.Text + "','" + this.cust_name.Text + "', '" + this.cust_contact.Text + "','" + this.cust_address.Text + "');", Con);

            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                count = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Con.Close();


            this.cust_id.Text = "";
            this.cust_name.Text = "";
            this.cust_contact.Text = "";
            this.cust_address.Text = "";
            if (count == 1)
            {
                this.status.Text = "Item Addition Success!!";
            }
        }

        private void cust_id_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
        }
    }
}
