using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageItems_Proj;

namespace oneStore
{
    public partial class viewItems : Form
    {
        public viewItems()
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

        private void viewItems_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                view_pb.Image = Properties.Resources.Red6;
                panel_perfumes.BackColor = Color.Red;
                panel_werable.BackColor = Color.Red;
                panel_shoes.BackColor = Color.Red;
                panel_women.BackColor = Color.Red;
                panel_men.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                view_pb.Image = Properties.Resources.Yellow6;
                panel_perfumes.BackColor = Color.FromArgb(255, 235, 20);
                panel_werable.BackColor = Color.FromArgb(255, 235, 20);
                panel_shoes.BackColor = Color.FromArgb(255, 235, 20);
                panel_women.BackColor = Color.FromArgb(255, 235, 20);
                panel_men.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                view_pb.Image = Properties.Resources.Green6;
                panel_perfumes.BackColor = Color.FromArgb(32, 236, 44);
                panel_werable.BackColor = Color.FromArgb(32, 236, 44);
                panel_shoes.BackColor = Color.FromArgb(32, 236, 44);
                panel_women.BackColor = Color.FromArgb(32, 236, 44);
                panel_men.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                view_pb.Image = Properties.Resources.Cyan6;
                panel_perfumes.BackColor = Color.Cyan;
                panel_werable.BackColor = Color.Cyan;
                panel_shoes.BackColor = Color.Cyan;
                panel_women.BackColor = Color.Cyan;
                panel_men.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                view_pb.Image = Properties.Resources.Blue6;
                panel_perfumes.BackColor = Color.Blue;
                panel_werable.BackColor = Color.Blue;
                panel_shoes.BackColor = Color.Blue;
                panel_women.BackColor = Color.Blue;
                panel_men.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                view_pb.Image = Properties.Resources.Megenta6;
                panel_perfumes.BackColor = Color.Magenta;
                panel_werable.BackColor = Color.Magenta;
                panel_shoes.BackColor = Color.Magenta;
                panel_women.BackColor = Color.Magenta;
                panel_men.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            lbl_view.Parent = view_pb;
            lbl_view.BackColor = Color.Transparent;


            btn_exit.Parent = view_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = view_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;

            panel_perfumes.Hide();
            panel_werable.Hide();
            panel_shoes.Hide();
            panel_women.Hide();
            panel_men.Show();
            btn_men.PerformClick();
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

        private void btn_wearbles_Click(object sender, EventArgs e)
        {
            try
            {
                panel_perfumes.Hide();
                panel_werable.Show();
                panel_shoes.Hide();
                panel_women.Hide();
                panel_men.Hide();

                ManageItems mi1 = new ManageItems();
                DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Wearables'");

                wearable_datagrid.DataSource = dt;
            }
            catch { }

        }

        private void btn_perfumes_Click(object sender, EventArgs e)
        {
            try
            {
                panel_perfumes.Show();
                panel_werable.Hide();
                panel_shoes.Hide();
                panel_women.Hide();
                panel_men.Hide();

                ManageItems mi1 = new ManageItems();
                DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Perfumes'");

                perfume_datagrid.DataSource = dt;
            }
            catch { }




        }

        private void btn_shoes_Click(object sender, EventArgs e)
        {
            try
            {
                panel_perfumes.Hide();
                panel_werable.Hide();
                panel_shoes.Show();
                panel_women.Hide();
                panel_men.Hide();

                ManageItems mi1 = new ManageItems();
                DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Shoes'");

                Shoes_dataGrid.DataSource = dt;
            }
            catch { }


        }

        private void btn_women_Click(object sender, EventArgs e)
        {
            try
            {
                panel_perfumes.Hide();
                panel_werable.Hide();
                panel_shoes.Hide();
                panel_women.Show();
                panel_men.Hide();

                ManageItems mi1 = new ManageItems();
                DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Women'");

                women_datagrid.DataSource = dt;
            }
            catch { }
        }

        private void btn_men_Click(object sender, EventArgs e)
        {
            try
            {
                panel_perfumes.Hide();
                panel_werable.Hide();
                panel_shoes.Hide();
                panel_women.Hide();
                panel_men.Show();

                ManageItems mi1 = new ManageItems();
                DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Men'");

                men_datagrid.DataSource = dt;
            }
            catch { }
        }

        private void btn_sort_perfume_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_perfume.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_perfume.Focus();
                    }
                }
                else
                {
                    ManageItems mi1 = new ManageItems();
                    DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Perfumes' and Brand = '" + cmb_perfume.SelectedItem + "'");

                    perfume_datagrid.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    cmb_perfume.Focus();
                }
            }
        }

        private void btn_sort_werable_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_wearable_brand.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_wearable_brand.Focus();
                    }
                }
                else
                {
                    ManageItems mi1 = new ManageItems();
                    DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Wearables' and Brand = '" + cmb_wearable_brand.SelectedItem + "'");

                    perfume_datagrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    cmb_wearable_brand.Focus();
                }
            }
        }

        private void wearable_datagrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void perfume_datagrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_sort_shoes_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_shoes.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_shoes.Focus();
                    }
                }
                else
                {
                    ManageItems mi1 = new ManageItems();
                    DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Shoes' and Brand = '" + cmb_shoes.SelectedItem + "'");

                    Shoes_dataGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    cmb_shoes.Focus();
                }
            }
        }

        private void Shoes_dataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_sort_women_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_women.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_women.Focus();
                    }
                }
                else
                {
                    ManageItems mi1 = new ManageItems();
                    DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Women' and Brand = '" + cmb_women.SelectedItem + "'");

                    Shoes_dataGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    cmb_women.Focus();
                }
            }
        }

        private void men_datagrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btn_sort_men_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_men.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_men.Focus();
                    }
                }
                else
                {
                    ManageItems mi1 = new ManageItems();
                    DataTable dt = mi1.ViewProduct("select * from Product where Category = 'Men' and Brand = '" + cmb_men.SelectedItem + "'");

                    men_datagrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    cmb_men.Focus();
                }
            }
        }
    }
}
