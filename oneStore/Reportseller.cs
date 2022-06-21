using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneStore
{
    public partial class Reportseller : Form
    {
        public Reportseller()
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

        private void Reportseller_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                report_pb.Image = Properties.Resources.Red6;
                panel_login.BackColor = Color.Red;
                panel_sell.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                report_pb.Image = Properties.Resources.Yellow6;
                panel_login.BackColor = Color.FromArgb(255, 235, 20);
                panel_sell.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                report_pb.Image = Properties.Resources.Green6;
                panel_login.BackColor = Color.FromArgb(32, 236, 44);
                panel_sell.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                report_pb.Image = Properties.Resources.Cyan6;
                panel_login.BackColor = Color.Cyan;
                panel_sell.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                report_pb.Image = Properties.Resources.Blue6;
                panel_login.BackColor = Color.Blue;
                panel_sell.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                report_pb.Image = Properties.Resources.Megenta6;
                panel_login.BackColor = Color.Magenta;
                panel_sell.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            lbl_reports.Parent = report_pb;
            lbl_reports.BackColor = Color.Transparent;


            btn_exit.Parent = report_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = report_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            panel_login.Hide();
            panel_sell.Show();

            this.login_report_view.RefreshReport();
            this.selles_reportView.RefreshReport();
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

        private void btn_employee_report_Click(object sender, EventArgs e)
        {
            panel_login.Show();
            panel_sell.Hide();
        }

        private void btn_sell_report_Click(object sender, EventArgs e)
        {
            panel_login.Hide();
            panel_sell.Show();
        }

        private void btn_login_report_Click(object sender, EventArgs e)
        {
            if (cmb_login.SelectedItem == null)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    cmb_login.Focus();
                }
            }
            else
            {
                this.Employee_recordsTableAdapter.Fill(this.sellerLogin.Employee_records,EmpId.ToString(), cmb_login.SelectedItem.ToString());
                this.login_report_view.RefreshReport();
            }
        }

        private void btn_sells_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ProductID.Text)) 
            {
              DialogResult dr =  MetroFramework.MetroMessageBox.Show(this, "Please Select Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               if(dr == DialogResult.OK)
                {
                    txt_ProductID.Focus();
                }
            }
            else
            {
                this.Sales_recordsTableAdapter.Fill(this.SellsReport.Sales_records, EmpId.ToString(), txt_ProductID.Text.ToString());
                this.selles_reportView.RefreshReport();

            }
        }
    }
}
