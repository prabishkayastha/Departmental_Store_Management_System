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
    public partial class modify_staff : Form
    {
        string staffid;
        DataTable dbdataset;
        string searchBy = "";

        public modify_staff()
        {
            InitializeComponent();
            AutoCompleteText_StaffID();
            AutoCompleteText_StaffName();
        }

        public modify_staff(string getStaffID)
        {
            staffid = getStaffID;
            InitializeComponent();
            AutoCompleteText_StaffID();
            AutoCompleteText_StaffName();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text)
            {
                case "Staff ID":
                    searchBy = "Staff_ID";
                    break;

                case "Staff Name":
                    searchBy = "staff_name";
                    break;

                case "Designation":
                    searchBy = "Designation";
                    break;

                case "Phone Num":
                    searchBy = "phone_num";
                    break;

                case "Address":
                    searchBy = "address";
                    break;

                case "Salary":
                    searchBy = "salary";
                    break;
            }
        }

           private void SearchButton_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from department_store.staff where " + searchBy + " = '"+ this.SearchStaff.Text +"';", Con);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                StaffGrid.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modify_staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page form = new main_page(staffid);
            form.Show();

        }

        private void staff_id_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Staff_ID LIKE  '{0}%'", staff_id.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM department_store.staff where Staff_ID = '" + this.staff_id.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.staff_name.Text = myReader.GetString("staff_name");
                    this.designation.Text = myReader.GetString("Designation");
                    this.phone_number.Text = myReader.GetString("phone_num");
                    this.address.Text = myReader.GetString("address");
                    this.salary.Text = myReader.GetString("salary");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void staff_name_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("staff_name LIKE  '{0}%'", staff_name.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM department_store.staff where staff_name = '" + this.staff_name.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.staff_id.Text = myReader.GetString("Staff_ID");
                    this.designation.Text = myReader.GetString("Designation");
                    this.phone_number.Text = myReader.GetString("phone_num");
                    this.address.Text = myReader.GetString("address");
                    this.salary.Text = myReader.GetString("salary");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void AutoCompleteText_StaffID()
        {

            staff_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            staff_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("SELECT * FROM department_store.staff;", Con);
            MySqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = command.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("Staff_ID");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            staff_id.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }

        void AutoCompleteText_StaffName()
        {

            staff_name.AutoCompleteMode = AutoCompleteMode.Suggest;
            staff_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("SELECT * FROM department_store.staff;", Con);
            MySqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = command.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("staff_name");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            staff_name.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            int salary = parseSalary(this.salary.Text);
            string query = "UPDATE department_store.staff SET staff_name = '" + this.staff_name.Text + "', Designation = '" + this.designation.Text + "', phone_num = '" + this.phone_number.Text + "', address = '" + this.address.Text + "', salary = " + salary + " where Staff_ID = '" + this.staff_id.Text + "'";
           
            MySqlCommand command = new MySqlCommand(query, Con);
            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                this.Message.Text = "UPDATE SUCCESS!!";

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public int parseSalary(string sal)
        {
            int salary = 0;
            try
            {
                salary = (int)Convert.ToInt32(sal.Trim());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return salary;
        }

        private void staff_id_Click(object sender, EventArgs e)
        {
            this.staff_id.Text = "";
            this.staff_name.Text = "";
            this.designation.Text = "";
            this.phone_number.Text = "";
            this.address.Text = "";
            this.salary.Text = "";
            this.Message.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string position = "";
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            int salary = parseSalary(this.salary.Text);
            string query = "SELECT * FROM department_store.staff where Staff_ID = '" + this.staff_id.Text + "';";
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();


                while (myReader.Read())
                {
                    position = myReader.GetString("Designation").ToLower();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            if (position == "manager")
            {
                this.Message.Text = "Manager Cannot be Removed ";
            }
            else
            {
                //USING ON DELETE CASCADE
                MySqlCommand delete_staff = new MySqlCommand("DELETE FROM department_store.staff where Staff_ID = '" + this.staff_id.Text + "';", Con);
                try
                {
                    Con.Open();
                    delete_staff.ExecuteNonQuery();
                    this.Message.Text = "STAFF DELETED!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.staff_id.Text = "";
            this.staff_name.Text = "";
            this.designation.Text = "";
            this.phone_number.Text = "";
            this.address.Text = "";
            this.salary.Text = "";
            this.Message.Text = "";
        }
       
    }
}
