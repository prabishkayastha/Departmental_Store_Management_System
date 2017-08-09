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
    public partial class billing : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;" );  
        MySqlCommand command;                                                                                         //for sql connection
        MySqlDataAdapter adapt;

        string product_name="";                 //product_name variable used in updating and inserting record

        Boolean check = false;              //for checking whether the data has been saved to sales data
        
        string staffid;             //for login 
        DataTable dbdataset;
        string item_unit_price; // used to store the price of an item from item detail 
        string item_quantity; //used to store the quantity of an item that are going to be purchased by customer from item detail 
        public billing()
        {
            InitializeComponent();
            AutoCompleteText_item_name();
            AutoCompleteText_CustId();
            DisplayCartData();                      // to display the data in cart to the datagridview
        }
        public billing(string StaffID)
        {
            InitializeComponent();
            staffid = StaffID;
            AutoCompleteText_item_name();
            AutoCompleteText_CustId();  
            DisplayCartData();                             // to display the data in cart to the datagridview
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from department_store." + this.comboBox1.Text + ";", Con);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DisplayCartData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM department_store.cart", connection);
            adapt.Fill(dt);
            dataGridCart.DataSource = dt;
            connection.Close();  
        }
        void AutoCompleteText_item_name()
        {
            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            item_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            item_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
             
            // for union

            string beverage = "select item_name from department_store.beverage";
            string bakery = "select item_name from department_store.bakery";
            string cereal = "select item_name from department_store.cereal";
            string chocolate = "select item_name from department_store.chocolate";
            string dairy = "select item_name from department_store.dairy";
            string grains = "select item_name from department_store.grains";
            string jarred__canned = "select item_name from department_store.jarred__canned";
            string junk_food = "select item_name from department_store.junk_food";
            string toiletaries = "select item_name from department_store.toiletaries";
            // Query to union all the tables and do mind the syntax...this query solves the "every table must have its own alias" problem
            // grand_table is the alias here...Alias is the reference word for the derived table
            string query = "SELECT grand_table.* from (" + beverage + " UNION " + bakery + " UNION " + cereal + " UNION " + chocolate + " UNION " + dairy + " UNION " + grains + " UNION " + jarred__canned + " UNION " + junk_food + " UNION " + toiletaries + ") as grand_table where grand_table.item_name = '"+ this.item_name_txt.Text +"';";
          

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("" + beverage + " UNION " + bakery + " UNION " + cereal + " UNION " + chocolate + " UNION " + dairy + " UNION " + grains + " UNION " + jarred__canned + " UNION " + junk_food + " UNION " + toiletaries + "", Con);
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

            item_name_txt.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }
        

       
        private void billing_Load(object sender, EventArgs e)
        {
            this.discount_label.Visible = false;
            AutoCompleteText_CustId();
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from department_store." + this.comboBox1.Text + ";", Con);
            Con.Open();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.date_txt.Text = DateTime.Now.ToString("yyyy/MM/dd");
            
            
            MySqlCommand com1 = new MySqlCommand("select * from department_store.sales_data where bill_no = (select MAX(bill_no) from department_store.sales_data) ;",Con);
            MySqlDataReader myReader;
            string string_bill_no = "";
            try
            {
                 myReader = com1.ExecuteReader();
                while(myReader.Read())
                {
                     string_bill_no = myReader.GetString("bill_no");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int bill_no = 0;
            bill_no = parse_quant(string_bill_no);
            bill_no += 1;
            this.bill_num_txt.Text = bill_no.ToString();

        }

       

        private void item_name_txt_TextChanged(object sender, EventArgs e)
        {

            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("item_name LIKE  '{0}%'", keyword.Text);
            // for union

            string beverage = "select * from department_store.beverage";
            string bakery = "select * from department_store.bakery";
            string cereal = "select * from department_store.cereal";
            string chocolate = "select * from department_store.chocolate";
            string dairy = "select * from department_store.dairy";
            string grains = "select * from department_store.grains";
            string jarred__canned = "select * from department_store.jarred__canned";
            string junk_food = "select * from department_store.junk_food";
            string toiletaries = "select * from department_store.toiletaries";
            // Query to union all the tables and do mind the syntax...this query solves the "every table must have its own alias" problem
            // grand_table is the alias here...Alias is the reference word for the derived table
            string query = "SELECT grand_table.* from (" + beverage + " UNION " + bakery + " UNION " + cereal + " UNION " + chocolate + " UNION " + dairy + " UNION " + grains + " UNION " + jarred__canned + " UNION " + junk_food + " UNION " + toiletaries + ") as grand_table where grand_table.item_name = '" + this.item_name_txt.Text + "';";
          
            
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.unit_price_txt.Text = myReader.GetString("price");
                    item_unit_price = myReader.GetString("price");
                    this.available_quantity_txt.Text = myReader.GetString("quantity");
                    item_quantity = myReader.GetString("quantity");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salequantity_txt_TextChanged(object sender, EventArgs e)
        {
            float item_price = 0;     //this is the product of unit price and the quantity
            float parsed_unit_price = parse_price(item_unit_price);
            int parsed_sale_quantity = parse_quant(this.salequantity_txt.Text);
            item_price = parsed_unit_price * parsed_sale_quantity;
            this.totalamount_txt.Text = item_price.ToString();
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
        
         void ClearData(){
             this.item_name_txt.Text = "";
             this.salequantity_txt.Text = "";
             this.unit_price_txt.Text = "";
             this.available_quantity_txt.Text = "";
             this.totalamount_txt.Text = "";
             product_name = "";
         }
         void ClearAllData()
         {
             this.customerName_txt.Text = "";
             this.cust_id_txt.Text = "";
             this.phone_num_txt.Text = "";
             this.GrandTotal_txt.Text = "";
             ClearData();
         }

        private void addtocart_button_Click(object sender, EventArgs e)
        {
            check = true;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "INSERT INTO department_store.cart values('"+ this.item_name_txt.Text +"',"+ this.salequantity_txt.Text +","+ this.totalamount_txt.Text +");";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);

            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                this.info_txt.Text = "Added to Cart Successfully!!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Con.Close();
            DisplayCartData();
            ClearData();  
        }

        private void dataGridCart_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            product_name = dataGridCart.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.item_name_txt.Text = product_name;
            this.salequantity_txt.Text = dataGridCart.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.totalamount_txt.Text = dataGridCart.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.addtocart_button.Enabled = false;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("UPDATE department_store.cart set quantity_added=@quantity ,amount = @amount where item_name=@name", connection);
            connection.Open();
            command.Parameters.AddWithValue("@name", product_name);
            command.Parameters.AddWithValue("@quantity", salequantity_txt.Text);
            command.Parameters.AddWithValue("@amount", totalamount_txt.Text);
            try 
            {
                command.ExecuteNonQuery();
                this.info_txt.Text = "Cart Update Successful!!!";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            connection.Close();
            DisplayCartData();
            this.addtocart_button.Enabled = true;
            ClearData();  
        }

        

        private void salequantity_txt_Click(object sender, EventArgs e)
        {
            this.info_txt.Text = "";
        }

        private void item_name_txt_Click(object sender, EventArgs e)
        {
            this.info_txt.Text = "";
        }


        public void delete_from_cart()
        {
            string query = "DELETE FROM department_store.cart ;";
            command = new MySqlCommand(query, connection);
            
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            DisplayCartData();
            ClearAllData();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (check)
            {
                DialogResult result = MessageBox.Show("New Bill Without Saving?","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    delete_from_cart();
                    
                }
            }
                                 
         }

        private void button5_Click(object sender, EventArgs e)
        {
            
            check = false;
            string query = "";
            string timestamp = DateTime.Today.ToString("yyyy/MM/dd");
            connection.Open();
            
            if(this.cust_id_txt.Text != "" && this.customerName_txt.Text != "" && this.phone_num_txt.Text !="")
            {
                
                query = "INSERT INTO department_store.sales_data (amount,cust_id,timestamp) values ("+ this.GrandTotal_txt.Text +",'"+ this.cust_id_txt.Text +"','"+ timestamp +"' );";
                command = new MySqlCommand(query, connection);
                
            
                try
                {
                    
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("Data saved Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if ( this.customerName_txt.Text == "" && this.phone_num_txt.Text == "")
            {
                query = "INSERT INTO department_store.sales_data (amount,timestamp) values ("+ this.GrandTotal_txt.Text +",'"+ timestamp +"');";
                command = new MySqlCommand(query, connection);
               
                
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            connection.Close();
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand com1 = new MySqlCommand("select * from department_store.sales_data where bill_no = (select MAX(bill_no) from department_store.sales_data) ;",Con);
            MySqlDataReader myReader;
            string string_bill_no = "";
            Con.Open();
            try
            {
                
                 myReader = com1.ExecuteReader();
                while(myReader.Read())
                {
                     string_bill_no = myReader.GetString("bill_no");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            int bill_no = 0;
            bill_no = parse_quant(string_bill_no);
            bill_no += 1;
            this.bill_num_txt.Text = bill_no.ToString();
            read_from_cart();
            connection.Close();
            delete_from_cart();
            DisplayCartData();
           
        }
        public int get_number_ofdata_cart()
        {
            MySqlCommand com = new MySqlCommand("select item_name, quantity_added from department_store.cart", connection);
            MySqlDataReader myReader;
             int count = 0;
            try
            {
                connection.Open();
                myReader = com.ExecuteReader();
                while (myReader.Read())
                {
                    count += 1;

                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            connection.Close();
            return count;
        }
        public void read_from_cart()
        {         
            MySqlCommand com = new MySqlCommand("select item_name, quantity_added from department_store.cart", connection);
            MySqlDataReader myReader;
            int data_number = get_number_ofdata_cart();
            string[] item_name_array = new string [data_number];
            string[] quantity_array = new string[data_number];
            int i = 0;
            try
            {
                connection.Open();
                myReader = com.ExecuteReader();
                while (myReader.Read())
                {
                    item_name_array[i] = myReader.GetString("item_name");
                    quantity_array[i] = myReader.GetString("quantity_added");
                    i += 1;
                    
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            connection.Close();
            find_table_todecrease(item_name_array, quantity_array);
            
            
        }

        public void find_table_todecrease(string[] item_name_cart, string[] quantity_added_cart)
        {
            string item_table_quantity="";
            string[] table_name = new string[9] { "chocolate", "bakery", "cereal","beverage", "dairy", "grains", "jarred__canned", "junk_food", "toiletaries" };
            string table_name_value = "", item_name_value = "";
            
            for ( int i = 0; i < item_name_cart.Length; i++)
            {
                for ( int j = 0; j < table_name.Length; j++)
                {
                    MySqlCommand com1 = new MySqlCommand("select * from department_store."+ table_name[j] +" where item_name='" + item_name_cart[i] + "';", connection);
                    MySqlDataReader findtableReader;
                    
                    
                    try
                    {
                        connection.Open();
                        findtableReader = com1.ExecuteReader();
                       
                        while (findtableReader.Read())
                        {
                            item_table_quantity = findtableReader.GetString("quantity");
                           
                        }
                        findtableReader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connection.Close();
                    table_name_value = table_name[j];
                    item_name_value = item_name_cart[i];
                    if (item_table_quantity != null)
                    {
                        quantity_decrease(table_name_value, item_name_value, quantity_added_cart[i]);
                    }
                    else { }
                }
            }
        }

        private void quantity_decrease(string table_name, string item_name_cart, string quantity_added_cart)
        {
            connection.Open();
            MySqlCommand com = new MySqlCommand("UPDATE department_store." + table_name + " SET quantity = quantity-" + parse_quant(quantity_added_cart) + " where item_name = '" + item_name_cart + "' ", connection);
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
       
        private void calculate_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand com = new MySqlCommand("select * from department_store.cart;", Con);
            MySqlDataReader myReader;
            string  amount = "";
            float grand_total = 0;
            Con.Open();
            try
            {
                myReader = com.ExecuteReader();
                while (myReader.Read())
                {
                    amount = myReader.GetString("amount");
                    
                    if(this.customerName_txt.Text =="")
                    {
                        grand_total += parse_price(amount);

                    }
                    else if (this.customerName_txt.Text != "")
                    {
                        grand_total += parse_price(amount);
                        grand_total = grand_total - (grand_total * (float)0.05);
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            this.GrandTotal_txt.Text = grand_total.ToString();
            
        }

        void AutoCompleteText_CustId()
        {
            cust_id_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            cust_id_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("SELECT * FROM department_store.customer;", Con);
            MySqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = command.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("cust_id");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            cust_id_txt.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }


        private void cust_id_txt_TextChanged(object sender, EventArgs e)
        {
            this.customerName_txt.Text ="";
            this.phone_num_txt.Text ="";
            DataView DV = new DataView(dbdataset);
            //DV.RowFilter = string.Format("cust_id LIKE  '{0}%'", cust_id_txt.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM department_store.customer where cust_id = '" + this.cust_id_txt.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.customerName_txt.Text = myReader.GetString("customer_name");
                    this.phone_num_txt.Text = myReader.GetString("phone_number");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void keyword_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("item_name LIKE  '{0}%'", keyword.Text);
            dataGridView1.DataSource = DV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllData();
            delete_from_cart();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            order fm = new order();
            fm.Show();

        }

        private void cashed_txt_TextChanged(object sender, EventArgs e)
        {
            float grand_total = parse_price(this.GrandTotal_txt.Text);
            int cashed = parse_quant(this.cashed_txt.Text);
            float returned_cash = cashed - grand_total;
            this.returned_cash_txt.Text = returned_cash.ToString();
        }

        private void customerName_txt_TextChanged(object sender, EventArgs e)
        {
            if(this.customerName_txt.Text != "")
            {
                this.discount_label.Visible = true;
            }
            else if (this.customerName_txt.Text == "")
            {
                this.discount_label.Visible = false;
            }
        }
         
       
    }
}
