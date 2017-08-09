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
    public partial class edit_customer : Form
    {
        string staffid;
        DataTable dbdataset;
        string searchBy="";
        public edit_customer()
        {
            InitializeComponent();
            
            AutoCompleteText_CustID();
            AutoCompleteText_CustName();
        }

        public edit_customer(string getStaffID)
        {
            staffid = getStaffID;
            InitializeComponent();
            LoadData();
            AutoCompleteText_CustID();
            AutoCompleteText_CustName();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text)
            {
                case "Customer ID":
                    searchBy = "cust_id";
                    break;

                case "Name":
                    searchBy = "customer_name";
                    break;

                case "Phone Num":
                    searchBy = "phone_number";
                    break;

                case "Address":
                    searchBy = "address";
                    break;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("" + searchBy + " LIKE  '{0}%'", search.Text);
            CustomerView.DataSource = DV;
        }

        public void LoadData()
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from department_store.customer;", Con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                CustomerView.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page form = new main_page(staffid);
            form.Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            string query = "UPDATE department_store.customer SET customer_name = '" + this.cust_name.Text + "', address = '" + this.cust_address.Text + "', phone_number = '" + this.cust_contact.Text + "' where cust_id = '" + this.cust_id.Text + "'";

            MySqlCommand command = new MySqlCommand(query, Con);
            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                this.Message.Text = "UPDATE SUCCESS!!";
                LoadData();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        void AutoCompleteText_CustID()
        {

            cust_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cust_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            cust_id.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }

        void AutoCompleteText_CustName()
        {

            cust_name.AutoCompleteMode = AutoCompleteMode.Suggest;
            cust_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
                    string sName = myreader.GetString("customer_name");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            cust_name.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }

        private void cust_id_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("cust_id LIKE  '{0}%'", cust_id.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM department_store.customer where cust_id = '" + this.cust_id.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.cust_name.Text = myReader.GetString("customer_name");
                    this.cust_contact.Text = myReader.GetString("phone_number");
                    this.cust_address.Text = myReader.GetString("address");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cust_name_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("customer_name LIKE  '{0}%'", cust_name.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM department_store.customer where customer_name = '" + this.cust_name.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.cust_id.Text = myReader.GetString("cust_id");
                    this.cust_contact.Text = myReader.GetString("phone_number");
                    this.cust_address.Text = myReader.GetString("address");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cust_id_Click(object sender, EventArgs e)
        {
            this.cust_id.Text = "";
            this.cust_name.Text="";
            this.cust_address.Text = "";
            this.cust_contact.Text="";
            this.Message.Text="";
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string query = "";
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            query = "DELETE FROM department_store.customer where cust_id = '" + this.cust_id.Text + "'";
            MySqlCommand command = new MySqlCommand(query, Con);
            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                 this.cust_id.Text = "";
                 this.cust_name.Text="";
                 this.cust_address.Text = "";
                 this.cust_contact.Text="";
                 LoadData();
                 this.Message.Text = "CUSTOMER DELETED!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            }

        private void edit_customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        }
    }
