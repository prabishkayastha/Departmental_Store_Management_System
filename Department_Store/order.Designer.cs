namespace Department_Store
{
    partial class order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.order_id_txt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cust_id_txt = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.customerName_txt = new System.Windows.Forms.TextBox();
            this.phone_num_txt = new System.Windows.Forms.TextBox();
            this.bill_num_txt = new System.Windows.Forms.TextBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.info_txt = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.addtocart_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.totalamount_txt = new System.Windows.Forms.TextBox();
            this.available_quantity_txt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.salequantity_txt = new System.Windows.Forms.TextBox();
            this.unit_price_txt = new System.Windows.Forms.TextBox();
            this.item_name_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.discount_label = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.GrandTotal_txt = new System.Windows.Forms.TextBox();
            this.returned_cash_txt = new System.Windows.Forms.TextBox();
            this.cashed_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delivery_btn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox5.Controls.Add(this.order_id_txt);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.address_txt);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.cust_id_txt);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.customerName_txt);
            this.groupBox5.Controls.Add(this.phone_num_txt);
            this.groupBox5.Controls.Add(this.bill_num_txt);
            this.groupBox5.Controls.Add(this.date_txt);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(465, 225);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BILLING";
            // 
            // order_id_txt
            // 
            this.order_id_txt.Enabled = false;
            this.order_id_txt.Location = new System.Drawing.Point(97, 75);
            this.order_id_txt.Name = "order_id_txt";
            this.order_id_txt.Size = new System.Drawing.Size(163, 20);
            this.order_id_txt.TabIndex = 34;
            this.order_id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Order ID";
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(97, 181);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(163, 20);
            this.address_txt.TabIndex = 32;
            this.address_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address_txt.TextChanged += new System.EventHandler(this.address_txt_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 31;
            this.button1.Text = "CLEAR ORDER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cust_id_txt
            // 
            this.cust_id_txt.Location = new System.Drawing.Point(97, 100);
            this.cust_id_txt.Name = "cust_id_txt";
            this.cust_id_txt.Size = new System.Drawing.Size(163, 20);
            this.cust_id_txt.TabIndex = 1;
            this.cust_id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cust_id_txt.TextChanged += new System.EventHandler(this.cust_id_txt_TextChanged_1);
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(317, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 36);
            this.button5.TabIndex = 29;
            this.button5.Text = "SAVE ORDER";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Customer ID";
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(317, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 38);
            this.button4.TabIndex = 28;
            this.button4.Text = "NEW ORDER";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // customerName_txt
            // 
            this.customerName_txt.Location = new System.Drawing.Point(97, 127);
            this.customerName_txt.Name = "customerName_txt";
            this.customerName_txt.Size = new System.Drawing.Size(163, 20);
            this.customerName_txt.TabIndex = 2;
            this.customerName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerName_txt.TextChanged += new System.EventHandler(this.customerName_txt_TextChanged);
            // 
            // phone_num_txt
            // 
            this.phone_num_txt.Location = new System.Drawing.Point(97, 155);
            this.phone_num_txt.Name = "phone_num_txt";
            this.phone_num_txt.Size = new System.Drawing.Size(163, 20);
            this.phone_num_txt.TabIndex = 3;
            this.phone_num_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phone_num_txt.TextChanged += new System.EventHandler(this.phone_num_txt_TextChanged);
            // 
            // bill_num_txt
            // 
            this.bill_num_txt.Enabled = false;
            this.bill_num_txt.Location = new System.Drawing.Point(97, 49);
            this.bill_num_txt.Name = "bill_num_txt";
            this.bill_num_txt.Size = new System.Drawing.Size(163, 20);
            this.bill_num_txt.TabIndex = 0;
            this.bill_num_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date_txt
            // 
            this.date_txt.Enabled = false;
            this.date_txt.Location = new System.Drawing.Point(97, 23);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(163, 20);
            this.date_txt.TabIndex = 30;
            this.date_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Invoice ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Phone No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.info_txt);
            this.groupBox3.Controls.Add(this.update_btn);
            this.groupBox3.Controls.Add(this.addtocart_button);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.totalamount_txt);
            this.groupBox3.Controls.Add(this.available_quantity_txt);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.salequantity_txt);
            this.groupBox3.Controls.Add(this.unit_price_txt);
            this.groupBox3.Controls.Add(this.item_name_txt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 198);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ITEM DETAIL";
            // 
            // info_txt
            // 
            this.info_txt.AutoSize = true;
            this.info_txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_txt.Location = new System.Drawing.Point(39, 111);
            this.info_txt.Name = "info_txt";
            this.info_txt.Size = new System.Drawing.Size(0, 15);
            this.info_txt.TabIndex = 21;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(217, 147);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(166, 42);
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Update Cart";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // addtocart_button
            // 
            this.addtocart_button.Location = new System.Drawing.Point(12, 150);
            this.addtocart_button.Name = "addtocart_button";
            this.addtocart_button.Size = new System.Drawing.Size(166, 42);
            this.addtocart_button.TabIndex = 5;
            this.addtocart_button.Text = "Add to Cart";
            this.addtocart_button.UseVisualStyleBackColor = true;
            this.addtocart_button.Click += new System.EventHandler(this.addtocart_button_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Amount Rs.";
            // 
            // totalamount_txt
            // 
            this.totalamount_txt.Enabled = false;
            this.totalamount_txt.Location = new System.Drawing.Point(276, 73);
            this.totalamount_txt.Name = "totalamount_txt";
            this.totalamount_txt.Size = new System.Drawing.Size(66, 20);
            this.totalamount_txt.TabIndex = 18;
            // 
            // available_quantity_txt
            // 
            this.available_quantity_txt.Enabled = false;
            this.available_quantity_txt.Location = new System.Drawing.Point(276, 49);
            this.available_quantity_txt.Name = "available_quantity_txt";
            this.available_quantity_txt.Size = new System.Drawing.Size(66, 20);
            this.available_quantity_txt.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(178, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Available Quantity";
            // 
            // salequantity_txt
            // 
            this.salequantity_txt.Location = new System.Drawing.Point(85, 49);
            this.salequantity_txt.Name = "salequantity_txt";
            this.salequantity_txt.Size = new System.Drawing.Size(83, 20);
            this.salequantity_txt.TabIndex = 5;
            this.salequantity_txt.Click += new System.EventHandler(this.salequantity_txt_Click);
            this.salequantity_txt.TextChanged += new System.EventHandler(this.salequantity_txt_TextChanged_1);
            // 
            // unit_price_txt
            // 
            this.unit_price_txt.Enabled = false;
            this.unit_price_txt.Location = new System.Drawing.Point(85, 73);
            this.unit_price_txt.Name = "unit_price_txt";
            this.unit_price_txt.Size = new System.Drawing.Size(83, 20);
            this.unit_price_txt.TabIndex = 12;
            // 
            // item_name_txt
            // 
            this.item_name_txt.Location = new System.Drawing.Point(85, 23);
            this.item_name_txt.Name = "item_name_txt";
            this.item_name_txt.Size = new System.Drawing.Size(150, 20);
            this.item_name_txt.TabIndex = 4;
            this.item_name_txt.Click += new System.EventHandler(this.item_name_txt_Click);
            this.item_name_txt.TextChanged += new System.EventHandler(this.item_name_txt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Sale Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Unit Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Item Name";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.discount_label);
            this.groupBox4.Controls.Add(this.calculate);
            this.groupBox4.Controls.Add(this.GrandTotal_txt);
            this.groupBox4.Controls.Add(this.returned_cash_txt);
            this.groupBox4.Controls.Add(this.cashed_txt);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(12, 521);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 130);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GRAND TOTAL";
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.discount_label.Location = new System.Drawing.Point(32, 66);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(89, 19);
            this.discount_label.TabIndex = 26;
            this.discount_label.Text = "5% Discount";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(2, 92);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(172, 31);
            this.calculate.TabIndex = 25;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // GrandTotal_txt
            // 
            this.GrandTotal_txt.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotal_txt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GrandTotal_txt.Location = new System.Drawing.Point(3, 16);
            this.GrandTotal_txt.Multiline = true;
            this.GrandTotal_txt.Name = "GrandTotal_txt";
            this.GrandTotal_txt.Size = new System.Drawing.Size(172, 46);
            this.GrandTotal_txt.TabIndex = 24;
            this.GrandTotal_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returned_cash_txt
            // 
            this.returned_cash_txt.Location = new System.Drawing.Point(351, 69);
            this.returned_cash_txt.Name = "returned_cash_txt";
            this.returned_cash_txt.Size = new System.Drawing.Size(117, 20);
            this.returned_cash_txt.TabIndex = 23;
            // 
            // cashed_txt
            // 
            this.cashed_txt.Location = new System.Drawing.Point(351, 20);
            this.cashed_txt.Name = "cashed_txt";
            this.cashed_txt.Size = new System.Drawing.Size(117, 20);
            this.cashed_txt.TabIndex = 20;
            this.cashed_txt.TextChanged += new System.EventHandler(this.cashed_txt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cash Returned ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cash Received ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 27);
            this.label17.TabIndex = 24;
            this.label17.Text = "BILLING";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "ADD PRODUCT TO CART";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "CALCULATION";
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridOrder.Location = new System.Drawing.Point(483, 94);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowTemplate.ReadOnly = true;
            this.dataGridOrder.ShowEditingIcon = false;
            this.dataGridOrder.Size = new System.Drawing.Size(734, 225);
            this.dataGridOrder.TabIndex = 28;
            this.dataGridOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridOrder_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "ORDERS PENDING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "SELECT A ROW AND PRESS DELIVERED BUTTON TO ";
            // 
            // delivery_btn
            // 
            this.delivery_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delivery_btn.Location = new System.Drawing.Point(1012, 50);
            this.delivery_btn.Name = "delivery_btn";
            this.delivery_btn.Size = new System.Drawing.Size(102, 38);
            this.delivery_btn.TabIndex = 31;
            this.delivery_btn.Text = "DELIVERED";
            this.delivery_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delivery_btn.UseVisualStyleBackColor = true;
            this.delivery_btn.Click += new System.EventHandler(this.delivery_btn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(700, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(940, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(727, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "ORDERS DELIVERED";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(705, 333);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(361, 27);
            this.label21.TabIndex = 36;
            this.label21.Text = "SELECT A ROW TO EDIT THE CART";
            // 
            // dataGridCart
            // 
            this.dataGridCart.AllowUserToAddRows = false;
            this.dataGridCart.AllowUserToDeleteRows = false;
            this.dataGridCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridCart.Location = new System.Drawing.Point(483, 360);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.ReadOnly = true;
            this.dataGridCart.RowTemplate.ReadOnly = true;
            this.dataGridCart.ShowEditingIcon = false;
            this.dataGridCart.Size = new System.Drawing.Size(734, 291);
            this.dataGridCart.TabIndex = 35;
            this.dataGridCart.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCart_RowHeaderMouseClick);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 655);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.delivery_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Name = "order";
            this.Text = "order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.order_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox cust_id_txt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox customerName_txt;
        private System.Windows.Forms.TextBox phone_num_txt;
        private System.Windows.Forms.TextBox bill_num_txt;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label info_txt;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button addtocart_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalamount_txt;
        private System.Windows.Forms.TextBox available_quantity_txt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox salequantity_txt;
        private System.Windows.Forms.TextBox unit_price_txt;
        private System.Windows.Forms.TextBox item_name_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox GrandTotal_txt;
        private System.Windows.Forms.TextBox returned_cash_txt;
        private System.Windows.Forms.TextBox cashed_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delivery_btn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox order_id_txt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridCart;
    }
}