using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerRegister_Proj;
using System.Text.RegularExpressions;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace oneStore
{
    public partial class Reg_loyalty : Form
    {
        public Reg_loyalty()
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
        public string tableName;

        FilterInfoCollection Filter;
        VideoCaptureDevice videoCap;

        private void Reg_loyalty_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                register_pb.Image = Properties.Resources.Red6;
                panel_loyalty_view.BackColor = Color.Red;
                panel_register.BackColor = Color.Red;
                panel_barcode_second.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                register_pb.Image = Properties.Resources.Yellow6;
                panel_loyalty_view.BackColor = Color.FromArgb(255, 235, 20);
                panel_register.BackColor = Color.FromArgb(255, 235, 20);
                panel_barcode_second.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                register_pb.Image = Properties.Resources.Green6;
                panel_loyalty_view.BackColor = Color.FromArgb(32, 236, 44);
                panel_register.BackColor = Color.FromArgb(32, 236, 44);
                panel_barcode_second.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                register_pb.Image = Properties.Resources.Cyan6;
                panel_loyalty_view.BackColor = Color.Cyan;
                panel_register.BackColor = Color.Cyan;
                panel_barcode_second.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                register_pb.Image = Properties.Resources.Blue6;
                panel_loyalty_view.BackColor = Color.Blue;
                panel_register.BackColor = Color.Blue;
                panel_barcode_second.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                register_pb.Image = Properties.Resources.Megenta6;
                panel_loyalty_view.BackColor = Color.Magenta;
                panel_register.BackColor = Color.Magenta;
                panel_barcode_second.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            Filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in Filter)
            {
                cmb_video_out.Items.Add(device.Name);
                cmb_video_out.SelectedIndex = 0;
            }

            lbl_reg.Parent = register_pb;
            lbl_reg.BackColor = Color.Transparent;


            btn_exit.Parent = register_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = register_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            rad_showAll.Checked = true;

            panel_loyalty_view.Hide();
            panel_register.Show();

            panel_barcode_first.Hide();
            panel_barcode_second.Hide();
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

        private void btn_register_Click(object sender, EventArgs e)
        {
            panel_loyalty_view.Hide();
            panel_register.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            panel_loyalty_view.Show();
            panel_register.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (rad_showAll.Checked == true)
                {
                    CustomerRegister cr1 = new CustomerRegister();
                    DataTable dt = cr1.ViewLoyalty("select * from Customer");

                    viewCustomer_dataGrid.DataSource = dt;
                }
                else
                {
                    if (String.IsNullOrEmpty(txt_search_tel.Text))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Tel number cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_search_tel.Focus();
                            txt_search_tel.Clear();
                        }

                    }
                    else if (txt_search_tel.Text.Any(char.IsWhiteSpace))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Tel number cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_search_tel.Focus();
                            txt_search_tel.Clear();
                        }
                    }
                    else if (txt_search_tel.Text.Any(char.IsLetter))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Tel number cannot have letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_search_tel.Focus();
                            txt_search_tel.Clear();
                        }
                    }
                    else if (!Regex.IsMatch(txt_search_tel.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Tel number invalid.please check cutomer number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_search_tel.Focus();
                            txt_search_tel.Clear();
                        }
                    }
                    else
                    {
                        CustomerRegister cr2 = new CustomerRegister();
                        DataTable dt = cr2.ViewLoyalty("select * from Customer where Cus_Tel = '" + txt_search_tel.Text + "'");

                        viewCustomer_dataGrid.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    txt_search_tel.Focus();
                    txt_search_tel.Clear();
                }
            }
        }

        private void rad_showAll_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_tel.Enabled = false;
            txt_search_tel.Clear();
        }

        private void rad_phone_CheckedChanged(object sender, EventArgs e)
        {
            txt_search_tel.Enabled = true;
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_id.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer ID cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_id.Focus();
                    }

                }
                else if (txt_id.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer ID cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_id.Focus();
                        txt_id.Clear();
                    }
                }
                else if (String.IsNullOrEmpty(txt_name.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Name cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_name.Focus();
                    }

                }
                else if (txt_name.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Name cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_name.Focus();
                    }
                }
                else if (txt_name.Text.Any(char.IsDigit))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Name cannot have number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_name.Focus();
                        txt_name.Clear();
                    }
                }
                else if (String.IsNullOrEmpty(txt_nic.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer NIC cannot be blanks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_nic.Focus();
                    }

                }
                else if (txt_nic.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer NIC cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_nic.Focus();
                    }
                }
                else if (String.IsNullOrEmpty(txt_tele.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Telephpne number cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tele.Focus();
                    }

                }
                else if (txt_tele.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Telephpne number cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tele.Focus();
                    }
                }
                else if (txt_tele.Text.Any(char.IsLetter))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Telephpne number cannot have letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tele.Clear();
                        txt_tele.Focus();
                    }
                }
                else if (!Regex.IsMatch(txt_tele.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer Telephpne number invalid.please check cutomer number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_tele.Clear();
                        txt_tele.Focus();
                    }
                }
                else if (String.IsNullOrEmpty(txt_loy_no.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Loyalty card number cannot be blank.please enter card number or scan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_loy_no.Focus();
                    }
                }
                else if (txt_loy_no.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Loyalty card number cannot have space.please check card number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_loy_no.Focus();
                    }
                }
                else
                {
                    CustomerRegister cr1 = new CustomerRegister();
                     int i = cr1.RegisterdCustomer("Insert into Customer (Cus_ID,Cus_Name,NIC,Cus_Tel,Loyalty_Card_No,Points) values('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_nic.Text + "', '" + txt_tele.Text + "','" + txt_loy_no.Text + "','"+0+"')  ");

                    if(i==1)
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Customer add successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       if(dr == DialogResult.OK)
                        {
                            PcName = Environment.MachineName;
                            Operation = "Insert";
                            tableName = "Customer";


                            databaseclass db1 = new databaseclass();
                            db1.database_record("insert into Database_records (Emp_ID,Emp_First_Name,Emp_Second_Name,Pc_Name,Operation,TableName ) values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "','" + tableName + "' )");


                            txt_id.Clear();
                            txt_name.Clear();
                            txt_nic.Clear();
                            txt_tele.Clear();
                            txt_loy_no.Clear();


                        }
                      
                    }
                    else
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Cannot insert Customer.Please try agian.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_id.Clear();
                            txt_name.Clear();
                            txt_nic.Clear();
                            txt_tele.Clear();
                            txt_loy_no.Clear();


                        }
                    }

                }

            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    txt_id.Clear();
                    txt_name.Clear();
                    txt_nic.Clear();
                    txt_tele.Clear();
                    txt_loy_no.Clear();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_nic.Clear();
            txt_tele.Clear();
            txt_loy_no.Clear();

        }

        private void SCAN_Click(object sender, EventArgs e)
        {
            try
            {
           


                videoCap = new VideoCaptureDevice(Filter[cmb_video_out.SelectedIndex].MonikerString);
                videoCap.NewFrame += videoCap_NewFrame;
                videoCap.Start();

                panel_barcode_first.Show();
                panel_barcode_second.Show();
                txt_barcode_add.Clear();


                btn_add.Enabled = false;
                btn_clear.Enabled= false;
                btn_back.Enabled = false;
                btn_scan.Enabled = false;
                btn_register.Enabled = false;
                btn_view.Enabled = false;
            }
            catch(Exception)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode Reading camera not detected.please check camera or insert barcode ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    panel_barcode_first.Hide();
                    panel_barcode_second.Hide();

                    btn_add.Enabled = true;
                    btn_clear.Enabled = true;
                    btn_back.Enabled = true;
                    btn_scan.Enabled = true;
                    btn_register.Enabled = true;
                    btn_view.Enabled = true;
                    

                    txt_barcode_add.Focus();

                }
            }
        }

        private void btn_barcode_back_Click(object sender, EventArgs e)
        {
            panel_barcode_first.Hide();
            panel_barcode_second.Hide();
            txt_barcode_add.Clear();

            btn_add.Enabled = true;
            btn_clear.Enabled = true;
            btn_back.Enabled = true;
            btn_scan.Enabled = true;
            btn_register.Enabled = true;
            btn_view.Enabled = true;


            if (videoCap != null)
            {
                if (videoCap.IsRunning)
                {
                    videoCap.Stop();
                }

            }
        }

        private void btn_add_barcode_Click(object sender, EventArgs e)
        {
            if (txt_barcode_add.Text != null)
            {
                string barcode = txt_barcode_add.Text.ToString();
                txt_loy_no.Text = barcode;
            }
            panel_barcode_first.Hide();
            panel_barcode_second.Hide();

            btn_add.Enabled = true;
            btn_clear.Enabled = true;
            btn_back.Enabled = true;
            btn_scan.Enabled = true;
            btn_register.Enabled = true;
            btn_view.Enabled = true;


        }
    }
}
