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
    public partial class add_product : Form
    {
        public add_product()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string quant = this.Quantity.Text;
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("INSERT INTO department_store." + this.category.Text + " values('" + this.product_name.Text + "'," + quant + ", '" + this.manufacturer.Text + "'," + this.Rate.Text + ");", Con);
            
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

            this.category.Text = "none";
            this.product_name.Text = "";
            this.Quantity.Text="";
            this.Rate.Text="";
            this.manufacturer.Text = "";
            if (count == 1)
            {
                this.status.Text = "Item Addition Success!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            main_page form = new main_page();
            form.Show();
        }

        private void add_product_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

      
    }
}
