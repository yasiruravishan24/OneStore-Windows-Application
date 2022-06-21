using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using ManageItems_Proj;
using CustomerRegister_Proj;

namespace oneStore
{
    public partial class sellItems : Form
    {
        public sellItems()
        {
            InitializeComponent();
        }
        public void SetData(string emp_ID, string fname, string sname)
        {
            EmpId = emp_ID;
            UFName = fname;
            USName = sname;
        }

        public string EmpId;
        public string UFName;
        public string USName;
        public string PcName;
        public string Operation;

        FilterInfoCollection Filter;
        VideoCaptureDevice videoCap;

        private void sellItems_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                sell_pb.Image = Properties.Resources.Red6;
                panel_adding.BackColor = Color.Red;
                panel_barcode_second.BackColor = Color.Red;
                panel_bill.BackColor = Color.Red;
                panel_bill_bar_2.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                sell_pb.Image = Properties.Resources.Yellow6;
                panel_adding.BackColor = Color.FromArgb(255, 235, 20);
                panel_barcode_second.BackColor = Color.FromArgb(255, 235, 20);
                panel_bill.BackColor = Color.FromArgb(255, 235, 20);
                panel_bill_bar_2.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                sell_pb.Image = Properties.Resources.Green6;
                panel_adding.BackColor = Color.FromArgb(32, 236, 44);
                panel_barcode_second.BackColor = Color.FromArgb(32, 236, 44);
                panel_bill.BackColor = Color.FromArgb(32, 236, 44);
                panel_bill_bar_2.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                sell_pb.Image = Properties.Resources.Cyan6;
                panel_adding.BackColor = Color.Cyan;
                panel_barcode_second.BackColor = Color.Cyan;
                panel_bill.BackColor = Color.Cyan;
                panel_bill_bar_2.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                sell_pb.Image = Properties.Resources.Blue6;
                panel_adding.BackColor = Color.Blue;
                panel_barcode_second.BackColor = Color.Blue;
                panel_bill.BackColor = Color.Blue;
                panel_bill_bar_2.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                sell_pb.Image = Properties.Resources.Megenta6;
                panel_adding.BackColor = Color.Magenta;
                panel_barcode_second.BackColor = Color.Magenta;
                panel_bill.BackColor = Color.Magenta;
                panel_bill_bar_2.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            Filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in Filter)
            {
                cmb_video_out.Items.Add(device.Name);
                cmb_video_out.SelectedIndex = 0;
                cmb_bill_brcode.Items.Add(device.Name);
                cmb_bill_brcode.SelectedIndex = 0;
            }

            lbl_sell.Parent = sell_pb;
            lbl_sell.BackColor = Color.Transparent;


            btn_exit.Parent = sell_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = sell_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            panel_barcode_first.Hide();
            panel_barcode_second.Hide();

            panel_bill_bar1.Hide();
            panel_bill_bar_2.Hide();

            txt_sub_total.Enabled = false;
            txt_bill_sub.Enabled = false;



            addData.Columns.Add("Biil NO");

            addData.Columns.Add("Product Id");

            addData.Columns.Add("Prodouct name");

            addData.Columns.Add("Price");

            addData.Columns.Add("Quantity");

            addData.Columns.Add("Total");


            addData.Columns.Add("Date Time");

            panel_bill.Hide();
            panel_adding.Show();

            rad_no_need.Checked = true;


        }

        private void btn_minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SellerHome sh = new SellerHome();
            sh.Show();
            this.Hide();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_barcodeOrID.Clear();
            txt_Quantity.Clear();
            txt_barcodeOrID.Enabled = true;
        }

        public int billNo;
        public string Pro_id;
        public string Product_name;
        public int price;
        public double total;
        public double quantity;
        DataTable addData = new DataTable();

        private void btn_add_details_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_barcodeOrID.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID Or Barcode cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_barcodeOrID.Focus();
                    }
                }
                else if (txt_barcodeOrID.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID Or Barcode cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_barcodeOrID.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_Quantity.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Quantity cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_Quantity.Focus();
                    }
                }
                else if (txt_Quantity.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Quantity cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_Quantity.Focus();
                    }
                }
                else if (txt_Quantity.Text.Any(char.IsLetter))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Quantity cannot have letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_Quantity.Focus();
                    }
                }
                else
                {
                    ManageItems mi = new ManageItems();
                    DataTable dt = mi.ViewProduct("select * From Product where Pro_ID = '" + txt_barcodeOrID.Text + "' OR Barcode = '" + txt_barcodeOrID.Text + "'");

                    if (dt.Rows.Count == 1)
                    {
                        databaseclass db1 = new databaseclass();
                        DataTable dtt = db1.database_record("select Max(Bill_No) From Sales_records");

                        if (dtt.Rows.Count >0)
                        {
                            String No = dtt.Rows[0][0].ToString(); 
                            int newNo= Convert.ToInt32(No);
                            billNo = newNo + 1;
                        }
                        else
                        {
                            billNo = 1;
                        }

                        Pro_id = dt.Rows[0]["Pro_ID"].ToString();
                        Product_name = dt.Rows[0]["Pro_Name"].ToString();
                        price = Convert.ToInt32(dt.Rows[0]["Price"]);

                        total = price * Convert.ToDouble((txt_Quantity.Text));
                        quantity = Convert.ToDouble(txt_Quantity.Text);
                        double subtotal = Convert.ToDouble(txt_sub_total.Text);
                        subtotal = subtotal + total;

                        addData.Rows.Add(billNo, Pro_id, Product_name, price, txt_Quantity.Text, total, DateTime.Now);

                        billing_grid.DataSource = addData;

                        txt_sub_total.Text = subtotal.ToString();
                        txt_bill_sub.Text = subtotal.ToString();

                        txt_barcodeOrID.Clear();
                        txt_Quantity.Clear();

                    }
                    else
                    {

                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Invalid barcode or Product Id.please check", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_barcodeOrID.Focus();
                        }



                    }
                }

            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btn_adding_Click(object sender, EventArgs e)
        {
            panel_bill.Hide();
            panel_adding.Show();
        }

        private void btn_blilling_Click(object sender, EventArgs e)
        {
            panel_bill.Show();
            panel_adding.Hide();
        }

        private void btn_barcode_back_Click(object sender, EventArgs e)
        {
            if (videoCap != null)
            {
                if (videoCap.IsRunning)
                {
                    videoCap.Stop();
                }

            }

            panel_barcode_first.Hide();
            panel_barcode_second.Hide();
            

            btn_adding.Enabled = true;
            btn_clear.Enabled = true;
            btn_add_details.Enabled = true;
            btn_Payments.Enabled = true;
            btn_back.Enabled = true;
           
        }

        private void rad_pro_id_CheckedChanged(object sender, EventArgs e)
        {
            txt_barcodeOrID.Enabled = true;
            panel_barcode_first.Hide();
            panel_barcode_second.Hide();
            txt_barcodeOrID.Focus();
           
            
        }
        private void videoCap_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {

                txt_barcode_add.Invoke(new MethodInvoker(delegate ()
                {
                    txt_barcode_add.Text = result.ToString();
                }));
            }
            barcode_pb.Image = bitmap;

        }
        private void BillvideoCap_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {

                txt_bill_barCode.Invoke(new MethodInvoker(delegate ()
                {
                    txt_bill_barCode.Text = result.ToString();
                }));
            }
            bill_barcode_pb.Image = bitmap;

        }
        private void btn_add_barcode_Click(object sender, EventArgs e)
        {
            if (txt_barcode_add.Text != null)
            {
                string barcode = txt_barcode_add.Text.ToString();
                txt_barcodeOrID.Text = barcode;

            }
            panel_barcode_first.Hide();
            panel_barcode_second.Hide();

            btn_adding.Enabled = true;
            btn_clear.Enabled = true;
            btn_add_details.Enabled = true;
            btn_Payments.Enabled = true;
            btn_back.Enabled = true;
           
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            try
            {
                videoCap = new VideoCaptureDevice(Filter[cmb_video_out.SelectedIndex].MonikerString);
                videoCap.NewFrame += videoCap_NewFrame;
                videoCap.Start();


                panel_barcode_first.Show();
                panel_barcode_second.Show();

                btn_adding.Enabled = false;
                btn_clear.Enabled = false;
                btn_add_details.Enabled = false;
                btn_Payments.Enabled = false;
                btn_back.Enabled = false;
                
       
            }
            catch (Exception)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode Reading camera not detected.please check camera or insert barcode ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    btn_adding.Enabled = true;
                    btn_clear.Enabled = true;
                    btn_add_details.Enabled = true;
                    btn_Payments.Enabled = true;
                    btn_back.Enabled = true;
                   

                    txt_barcodeOrID.Focus();

                    panel_barcode_first.Hide();
                    panel_barcode_second.Hide();

                }


            }

        }
        private void btn_scan_loyalty_Click(object sender, EventArgs e)
        {
            try
            {
                videoCap = new VideoCaptureDevice(Filter[cmb_bill_brcode.SelectedIndex].MonikerString);
                videoCap.NewFrame += BillvideoCap_NewFrame;
                videoCap.Start();

                panel_bill_bar1.Show();
                panel_bill_bar_2.Show();

                btn_adding.Enabled = false;
                btn_clear_bill.Enabled = false;
                btn_pay.Enabled = false;
                btn_add_details.Enabled = false;
                btn_Payments.Enabled = false;
                btn_back.Enabled = false;

            }
            catch (Exception)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode Reading camera not detected.please check camera or insert barcode ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    btn_adding.Enabled = true;
                    btn_clear_bill.Enabled = true;
                    btn_pay.Enabled = true;
                    btn_add_details.Enabled = true;
                    btn_Payments.Enabled = true;
                    btn_back.Enabled = true;


                    txt_bill_barCode.Focus();

                    panel_bill_bar1.Hide();
                    panel_bill_bar_2.Hide();

                }


            }
        }

        private void btn_clear_bill_Click(object sender, EventArgs e)
        {
            txt_loyalty_no.Clear();
            txt_return_amount.Clear();
            txt_paid_amount.Clear();
            rad_no_need.Checked = true;
        }
        private void rad_no_need_CheckedChanged(object sender, EventArgs e)
        {
            txt_loyalty_no.Enabled = false;
            btn_scan_loyalty.Enabled = false;
        }

        private void rad_have_CheckedChanged(object sender, EventArgs e)
        {
            btn_scan_loyalty.Enabled = true;
            txt_loyalty_no.Enabled = true;
            txt_loyalty_no.Focus();
        }

        private void btn__barcode2_back_Click(object sender, EventArgs e)
        {
            panel_bill_bar1.Hide();
            panel_bill_bar_2.Hide();

            if (videoCap != null)
            {
                if (videoCap.IsRunning)
                {
                    videoCap.Stop();
                }

            }


            btn_adding.Enabled = true;
            btn_clear_bill.Enabled = true;
            btn_pay.Enabled = true;
            btn_add_details.Enabled = true;
            btn_Payments.Enabled = true;
            btn_back.Enabled = true;
        }

        private void btn_bill_add_barcode_Click(object sender, EventArgs e)
        {
            if (txt_bill_barCode.Text != null)
            {
                string barcode = txt_bill_barCode.Text.ToString();
                txt_loyalty_no.Text = barcode;

            }
            panel_bill_bar1.Hide();
            panel_bill_bar_2.Hide();

            btn_pay.Enabled = true;
            btn_adding.Enabled = true;
            btn_clear_bill.Enabled = true;
            btn_adding.Enabled = true;
            btn_clear.Enabled = true;
            btn_add_details.Enabled = true;
            btn_Payments.Enabled = true;
            btn_back.Enabled = true;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            try
            {
                if(rad_have.Checked == true)
                {

                    if (string.IsNullOrEmpty(txt_loyalty_no.Text))
                    {
                       DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Loyalty card No or customer telephone number cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if(dr == DialogResult.OK)
                        {
                            txt_barcodeOrID.Focus();
                        }
                    }
                    else if (txt_loyalty_no.Text.Any(char.IsWhiteSpace))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Loyalty card No or customer telephone number cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_barcodeOrID.Focus();
                        }
                    }
                    else if (string.IsNullOrEmpty(txt_paid_amount.Text))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Paid Amount  cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_paid_amount.Focus();
                        }

                    }
                    else if (txt_paid_amount.Text.Any(char.IsWhiteSpace))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Paid Amount  cannot have blanks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_paid_amount.Focus();
                        }

                    }
                    else if (txt_paid_amount.Text.Any(char.IsLetter))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Paid Amount  cannot have letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_paid_amount.Focus();
                        }

                    }
                    else
                    {

                        double subTotal = Convert.ToDouble(txt_sub_total.Text);
                        double paidAmount = Convert.ToDouble(txt_paid_amount.Text);

                        if (subTotal > paidAmount)
                        {
                            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Paid Amount is less than the Sub total.please check", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (dr == DialogResult.OK)
                            {
                                txt_paid_amount.Focus();
                            }
                        }
                        else
                        {

                            txt_return_amount.Text = (paidAmount - subTotal).ToString();

                            CustomerRegister cr = new CustomerRegister();
                            DataTable dt = cr.ViewLoyalty("select * from Customer where Loyalty_Card_No ='" + txt_loyalty_no.Text+ "'  or Cus_Tel = '"+Convert.ToInt64(txt_loyalty_no.Text)+"' ");

                            if(dt.Rows.Count == 1)
                            {
                                int points = Convert.ToInt32(dt.Rows[0]["Points"]);
                                points = points + 10;

                                int i = cr.RegisterdCustomer(" Update Customer set Points = '"+points+"' where Loyalty_Card_No ='" + txt_loyalty_no.Text+ "' or  Cus_Tel = '" + Convert.ToInt64(txt_loyalty_no.Text) + "'  ");

                                if(i == 1)
                                {
                                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Payment successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (dr == DialogResult.OK)
                                    {




                                        databaseclass db1 = new databaseclass();
                                        db1.database_record("Insert into Sales_records (Bill_No,Pro_ID,Pro_Name,Price,Quantity,Total_Bill,Seller_ID,Seller_Name ,Pc_Name,DateTime)values('" + billNo + "','" + Pro_id + "', '" + Product_name + "','" + price + "','" + quantity + "', '" + total + "', '" + EmpId + "', '" + UFName + "','" + System.Environment.MachineName + "', '" + DateTime.Now + "')   ");



                                        txt_loyalty_no.Clear();
                                        txt_paid_amount.Clear();
                                        txt_bill_sub.Clear();
                                        txt_barcodeOrID.Clear();
                                        txt_Quantity.Clear();
                                        txt_return_amount.Clear();
                                        txt_sub_total.Clear();
                                        txt_barcode_add.Clear();

                                        panel_adding.Hide();
                                        panel_bill.Show();

                                        billing_grid.DataSource = null;
                                        billing_grid.Refresh();

                                    }
                                }



                            }
                            else
                            {
                                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Invalid loyalty card No or invalid telephone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (dr == DialogResult.OK)
                                {
                                    txt_loyalty_no.Focus();
                                }
                            }


                        }



                    }
                }
                else if(string.IsNullOrEmpty(txt_paid_amount.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Paid Amount  cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_paid_amount.Focus();
                    }

                }
                else if (txt_paid_amount.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Paid Amount  cannot have blanks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_paid_amount.Focus();
                    }

                }
                else if (txt_paid_amount.Text.Any(char.IsLetter))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Paid Amount  cannot have letter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_paid_amount.Focus();
                    }

                }
                else
                {

                    double subTotal = Convert.ToDouble(txt_sub_total.Text);
                    double paidAmount = Convert.ToDouble(txt_paid_amount.Text);

                    if(subTotal > paidAmount)
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Paid Amount is less than the Sub total.please check", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_paid_amount.Focus();
                        }
                    }
                    else
                    {

                        txt_return_amount.Text = (paidAmount - subTotal).ToString();
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Payment successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {

                            databaseclass db1 = new databaseclass();
                            db1.database_record("Insert into Sales_records (Bill_No,Pro_ID,Pro_Name,Price,Quantity,Total_Bill,Seller_ID,Seller_Name ,Pc_Name,DateTime)values('" + billNo + "','" + Pro_id + "', '" + Product_name + "','" + price + "','" + quantity + "', '" + total + "', '" + EmpId + "', '" + UFName + "','" + System.Environment.MachineName + "', '" + DateTime.Now + "')   ");

                            txt_loyalty_no.Clear();
                            txt_paid_amount.Clear();
                            txt_bill_sub.Clear();
                            txt_barcodeOrID.Clear();
                            txt_Quantity.Clear();
                            txt_return_amount.Clear();
                            txt_sub_total.Clear();
                            txt_barcode_add.Clear();

                            panel_adding.Hide();
                            panel_bill.Show();

                            billing_grid.DataSource = null;
                            billing_grid.Refresh();

                        }

                    }



                }

            }
            catch(Exception ex)
            {
               DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dr == DialogResult.OK)
                {
                    txt_sub_total.Focus();
                }

            }

        }
    }
}
