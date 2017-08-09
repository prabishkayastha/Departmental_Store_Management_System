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
    public partial class Product_update : Form
    {
        DataTable dbdataset;
        public Product_update()
        {
            InitializeComponent();
        }

        void AutoCompleteText(){
            
            product_name.AutoCompleteMode = AutoCompleteMode.Suggest;
            product_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);         
            MySqlCommand command = new MySqlCommand("SELECT * FROM department_store." + this.category.Text + ";", Con);
            MySqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = command.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("item_name");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            product_name.AutoCompleteCustomSource = coll;       //loading coll to the customsource

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCompleteText();
        }

        private void product_name_TextChanged_1(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("item_name LIKE  '{0}%'", product_name.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM department_store." + this.category.Text + " where item_name = '" + this.product_name.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.current_quant.Text = "Current Stock Quantity " + myReader.GetString("quantity").ToString() + "";
                    this.old_price.Text = "Current Price: Rs." + myReader.GetFloat("price").ToString() + "";        //getting float value from database and converting to string
                    Price.Text = myReader.GetFloat("price").ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            int count = 0;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "DELETE FROM department_store." + this.category.Text + " where item_name = '" + this.product_name.Text + "';";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
           
            MySqlCommand command = new MySqlCommand(query, Con);

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

            if (count == 1)
            {
                this.status.Text = "Item Deletion Success!!";
            }
            this.category.Text = "";
            this.Quantity.Text = "";
            this.Price.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            main_page form = new main_page();
            form.Show();
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            string query ="";
           
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlDataReader myReader;
            int new_quantity = 0;
            float new_price = 0;

            if (this.Quantity.Text != "" && this.Price.Text != "")
            {
                new_quantity = parse_quant(this.Quantity.Text);
                new_price = parse_price(this.Price.Text);
                query = "UPDATE department_store." + this.category.Text + " SET quantity = quantity + " + new_quantity + ", price = " + new_price + " where item_name = '" + this.product_name.Text + "'";
                this.status.Text = "Price and Quantity UPDATED!!";
            }
            else if (this.Quantity.Text == "" && this.Price.Text == "")
            {
                MessageBox.Show("Enter Details!", "Please provide Quantity or Price to Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                query = "";
            }
            else if(this.Quantity.Text!= "")
                {
                    new_quantity = parse_quant(this.Quantity.Text);
                    query = "UPDATE department_store." + this.category.Text + " SET quantity = quantity + " + new_quantity + " where item_name = '" + this.product_name.Text + "'";
                    this.status.Text = "Quantity UPDATED!!";    
            }
            else if (this.Price.Text != "")
                {
                    new_price = parse_price(this.Price.Text);
                    query = "UPDATE department_store." + this.category.Text + " SET price = " + new_price + " where item_name = '" + this.product_name.Text + "'";
                    this.status.Text = "Price UPDATED!!";
            }
            
            MySqlCommand command = new MySqlCommand(query, Con);

            try
            {
                Con.Open();
                myReader = command.ExecuteReader();
                //this.status.Text = new_price.ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            Con.Close();
            this.current_quant.Text = "";
            this.product_name.Text = "";
            this.Quantity.Text = "";
            this.Price.Text = "";
            this.current_quant.Text = "";
            this.old_price.Text = "";

        }

        float getPrice()
        {
            float get_price = 0;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM department_store." +this.category.Text+ " where item_name = '" + this.product_name.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    get_price = myReader.GetFloat("price");        //getting float value from database and converting to string
                    this.status.Text = get_price.ToString();
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return get_price;
        }

        int parse_quant(string quant)
        {
            int new_quantity = 0;
            try
            {
                    new_quantity = (int)Convert.ToInt32(quant.Trim());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new_quantity;
        }

        float parse_price(string getPrice)
        {
            float parsed_price = 0;

            try
            {
                parsed_price = (float)Convert.ToDouble(getPrice.Trim());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return parsed_price;
        }

        private void product_name_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
        }

        private void Quantity_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
        }

        private void Price_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
        }

        private void category_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
        }

        private void Product_update_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page form = new main_page();
            form.Show();
        }
    }
}
