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
    public partial class add_staff : Form
    {
        string staffid;
        public add_staff()
        {
            InitializeComponent();
        }

        public add_staff(string getStaffID)
        {
            staffid = getStaffID;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO department_store.staff values ('" + this.staff_id.Text + "','" + this.staff_name.Text + "','" + this.sex.Text + "','" + this.designation.Text + "','" + this.phone_number.Text + "','" + this.address.Text + "'," + this.salary.Text + ");", Con);
            try
            {
                Con.Open();

                cmd.ExecuteNonQuery();

                if (this.designation.Text == "Cashier")
                {
                    new_login form = new new_login(this.staff_id.Text);
                    form.Show();
                }
                else
                    this.messagebox.Text = "STAFF ADDED SUCCESSFULLY!!!";
            }

            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Please Input All the Details!!");
            }
            Con.Close();

            this.staff_id.Text = "";
            this.staff_name.Text = "";
            this.sex.Text = "";
            this.designation.Text = "";
            this.phone_number.Text = "";
            this.address.Text = "";
            this.salary.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.staff_id.Text = "";
            this.staff_name.Text = "";
            this.designation.Text = "";
            this.phone_number.Text = "";
            this.address.Text = "";
            this.salary.Text = "";
            this.messagebox.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            main_page form = new main_page(staffid);
            form.Show();
        }

        public void getStatus()
        {
            MessageBox.Show("New Cashier Added!");
        }
        private void add_staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
