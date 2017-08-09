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
    public partial class customer_info : Form
    {
        string staffid;
        DataTable dbdataset;
        string searchBy = "";

        public customer_info()
        {
            InitializeComponent();
        }

        public customer_info(string getStaffID)
        {
            staffid = getStaffID;
            InitializeComponent();
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
        private void customer_info_Load(object sender, EventArgs e)
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("" + searchBy + " LIKE  '{0}%'", search.Text);
            CustomerView.DataSource = DV;
        }

        private void customer_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



      

    }
}
