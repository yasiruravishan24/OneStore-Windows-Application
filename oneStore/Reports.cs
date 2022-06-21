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
    public partial class Reports : Form
    {
        public Reports()
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

        private void Reports_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                report_pb.Image = Properties.Resources.Red6;
                panel_database.BackColor = Color.Red;
                panel_login_report.BackColor = Color.Red;
                panel_sell_report.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                report_pb.Image = Properties.Resources.Yellow6;
                panel_database.BackColor = Color.FromArgb(255, 235, 20);
                panel_login_report.BackColor = Color.FromArgb(255, 235, 20);
                panel_sell_report.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                report_pb.Image = Properties.Resources.Green6;
                panel_database.BackColor = Color.FromArgb(32, 236, 44);
                panel_login_report.BackColor = Color.FromArgb(32, 236, 44);
                panel_sell_report.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                report_pb.Image = Properties.Resources.Cyan6;
                panel_database.BackColor = Color.Cyan;
                panel_login_report.BackColor = Color.Cyan;
                panel_sell_report.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                report_pb.Image = Properties.Resources.Blue6;
                panel_database.BackColor = Color.Blue;
                panel_login_report.BackColor = Color.Blue;
                panel_sell_report.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                report_pb.Image = Properties.Resources.Megenta6;
                panel_database.BackColor = Color.Magenta;
                panel_login_report.BackColor = Color.Magenta;
                panel_sell_report.BackColor = Color.Magenta;
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

            panel_database.Hide();
            this.DatabaseReportView.RefreshReport();

            panel_login_report.Hide();
            panel_database.Hide();
            panel_sell_report.Show();
            this.SellesReportViewer.RefreshReport();
            this.LogingReportViewer.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
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

        private void btn_employe_report_Click(object sender, EventArgs e)
        {
            panel_database.Hide();
            panel_login_report.Show();
            panel_sell_report.Hide();
        }

        private void btn_sell_report_Click(object sender, EventArgs e)
        {
            panel_database.Hide();
            panel_login_report.Hide();
            panel_sell_report.Show();
        }

        private void btn_databasereport_Click(object sender, EventArgs e)
        {
            panel_database.Show();
            panel_login_report.Hide();
            panel_sell_report.Hide();

        }

        private void btn_database_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_database_EID.Text) && cmb_search_operation.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Enter Employee ID or selete Operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_database_EID.Focus();
                    }
                }
                else if (txt_database_EID.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee ID cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_database_EID.Focus();
                    }
                }
                else
                {
                    this.Database_recordsTableAdapter.Fill(this.DataBaseReport.Database_records, txt_database_EID.Text.ToString(), cmb_search_operation.SelectedItem.ToString());
                    this.DatabaseReportView.RefreshReport();




                }
            }
            catch(Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_database_EID.Focus();
                    txt_database_EID.Clear();
                    cmb_search_operation.SelectedItem = null;

                }
            }
           


        }

        private void btn_login_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_login_EID.Text) && cmb_login_operation.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Enter Employee ID or selete Operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_login_EID.Focus();
                    }
                }
                else if (txt_login_EID.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee ID cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_login_EID.Focus();
                    }
                }
                else
                {
                    this.Employee_recordsTableAdapter.Fill(this.LoginReport.Employee_records, txt_login_EID.Text.ToString(), cmb_login_operation.SelectedItem.ToString());
                    this.LogingReportViewer.RefreshReport();




                }
            }
            catch(Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_login_EID.Focus();
                    txt_login_EID.Clear();
                    cmb_login_operation.SelectedItem = null;

                }
            }
          
        }

        private void btn_sells_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_selles_EID.Text) && string.IsNullOrEmpty(txt_ProductID.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Enter Employee ID or Product ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_selles_EID.Focus();
                    }
                }
                else if (txt_selles_EID.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Employee ID cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_selles_EID.Focus();
                    }
                }
                else
                {
                    this.Sales_recordsTableAdapter.Fill(this.sellerSell.Sales_records, txt_ProductID.Text.ToString(),txt_selles_EID.Text.ToString());
                    this.SellesReportViewer.RefreshReport();




                }
            }
            catch(Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_selles_EID.Focus();
                    txt_selles_EID.Clear();
                    

                }
            }
          
        }
    }
}
