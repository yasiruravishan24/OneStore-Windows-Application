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
using System.IO;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using System.Data.SqlClient;

namespace oneStore
{
    public partial class manage_sell_items : Form
    {
        public manage_sell_items()
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

        private void btn_back_f_sell_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }

        FilterInfoCollection Filter;
        VideoCaptureDevice videoCap;

        private void manage_sell_items_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Red")
            {
                manageSell_pb.Image = Properties.Resources.Red6;
                panel_view_product.BackColor = Color.Red;
                Panel_Update_prduct.BackColor = Color.Red;
                panel_barcode_second.BackColor = Color.Red;
                panel_delete.BackColor = Color.Red;
                panel_add_product.BackColor = Color.Red;
                this.Icon = Properties.Resources.RedIcon;
            }
            else if (Properties.Settings.Default.Theme == "Yellow")
            {
                manageSell_pb.Image = Properties.Resources.Yellow6;
                panel_view_product.BackColor = Color.FromArgb(255, 235, 20);
                Panel_Update_prduct.BackColor = Color.FromArgb(255, 235, 20);
                panel_barcode_second.BackColor = Color.FromArgb(255, 235, 20);
                panel_delete.BackColor = Color.FromArgb(255, 235, 20);
                panel_add_product.BackColor = Color.FromArgb(255, 235, 20);
                this.Icon = Properties.Resources.YellowIcon;
            }
            else if (Properties.Settings.Default.Theme == "Green")
            {
                manageSell_pb.Image = Properties.Resources.Green6;
                panel_view_product.BackColor = Color.FromArgb(32, 236, 44);
                Panel_Update_prduct.BackColor = Color.FromArgb(32, 236, 44);
                panel_barcode_second.BackColor = Color.FromArgb(32, 236, 44);
                panel_delete.BackColor = Color.FromArgb(32, 236, 44);
                panel_add_product.BackColor = Color.FromArgb(32, 236, 44);
                this.Icon = Properties.Resources.GreenIcon;
            }
            else if (Properties.Settings.Default.Theme == "Cyan")
            {
                manageSell_pb.Image = Properties.Resources.Cyan6;
                panel_view_product.BackColor = Color.Cyan;
                Panel_Update_prduct.BackColor = Color.Cyan;
                panel_barcode_second.BackColor = Color.Cyan;
                panel_delete.BackColor = Color.Cyan;
                panel_add_product.BackColor = Color.Cyan;
                this.Icon = Properties.Resources.CyanIcon;
            }
            else if (Properties.Settings.Default.Theme == "Blue")
            {
                manageSell_pb.Image = Properties.Resources.Blue6;
                panel_view_product.BackColor = Color.Blue;
                Panel_Update_prduct.BackColor = Color.Blue;
                panel_barcode_second.BackColor = Color.Blue;
                panel_delete.BackColor = Color.Blue;
                panel_add_product.BackColor = Color.Blue;
                this.Icon = Properties.Resources.BlueIcon;
            }
            else if (Properties.Settings.Default.Theme == "Magenta")
            {
                manageSell_pb.Image = Properties.Resources.Megenta6;
                panel_view_product.BackColor = Color.Magenta;
                Panel_Update_prduct.BackColor = Color.Magenta;
                panel_barcode_second.BackColor = Color.Magenta;
                panel_delete.BackColor = Color.Magenta;
                panel_add_product.BackColor = Color.Magenta;
                this.Icon = Properties.Resources.MagentaIcon;
            }

            Filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in Filter)
            {
                cmb_video_out.Items.Add(device.Name);
                cmb_video_out.SelectedIndex = 0;
            }


            lbl_sell.Parent = manageSell_pb;
            lbl_sell.BackColor = Color.Transparent;


            btn_exit.Parent = manageSell_pb;
            btn_exit.BackColor = Color.Transparent;

            btn_minimize.Parent = manageSell_pb;
            btn_minimize.BackColor = Color.Transparent;

            btn_minimize.TabStop = false;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatAppearance.BorderSize = 0;

            btn_exit.TabStop = false;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.FlatAppearance.BorderSize = 0;


            panel_view_product.Hide();
            Panel_Update_prduct.Hide();
            panel_delete.Hide();
            panel_add_product.Show();

            txt_update_image.Enabled = false;

            panel_barcode_first.Hide();
            panel_barcode_second.Hide();

            updateImage_full.Visible = false;
            updateImage_pb.Hide();

            add_image.Hide();
            add_image_Full.Visible = false;

            rad_showAll.Checked = true;

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

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            panel_view_product.Hide();
            Panel_Update_prduct.Hide();
            panel_add_product.Show();
            panel_delete.Hide();
            txt_add_barcode.Clear();
        }

        private void btn_delete_product_Click(object sender, EventArgs e)
        {
            panel_view_product.Hide();
            Panel_Update_prduct.Hide();
            panel_add_product.Hide();
            panel_delete.Show();
        }

        private void btn_update_product_Click(object sender, EventArgs e)
        {
            Panel_Update_prduct.Show();
            panel_view_product.Hide();
            panel_add_product.Hide();
            panel_delete.Hide();
            txt_update_barcode.Clear();
        }

        private void btn_view_product_Click(object sender, EventArgs e)
        {
            panel_view_product.Show();
            Panel_Update_prduct.Hide();
            panel_add_product.Hide();
            panel_delete.Hide();
        }

        private void rad_PID_CheckedChanged(object sender, EventArgs e)
        {
            cmd_serch_brands.Enabled = false;
            txt_seach_PID.Enabled = true;
            cmd_serch_brands.SelectedItem = null;
        }
    
        private void btn_serch_Click(object sender, EventArgs e)
        {
            try
            {
                if (rad_PID.Checked == true)
                {
                    if (String.IsNullOrEmpty(txt_seach_PID.Text))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_seach_PID.Focus();
                        }
                    }
                    else if (txt_seach_PID.Text.Any(char.IsWhiteSpace))
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_seach_PID.Focus();
                        }
                    }
                    else
                    {
                        ManageItems mi1 = new ManageItems();
                        DataTable dt = mi1.ViewProduct("Select * From Product Where Pro_ID = '" + txt_seach_PID.Text + "'");
                        product_grid.DataSource = dt;
                        
                    }


                }
                else if (rad_band.Checked == true)
                {
                    if (cmd_serch_brands.SelectedItem == null)
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please select brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            cmd_serch_brands.Focus();
                        }
                    }
                    else
                    {
                        ManageItems mi1 = new ManageItems();
                        DataTable dt = mi1.ViewProduct("Select * From Product Where Brand = '" + cmd_serch_brands.SelectedItem + "'");
                        product_grid.DataSource = dt;
                        

                    }
                }
                else
                {
                    ManageItems mi1 = new ManageItems();
                    DataTable dt = mi1.ViewProduct("Select * From Product");
                    product_grid.DataSource = dt;
                }

            }
            catch(System.FormatException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_seach_PID.Clear();
                    cmd_serch_brands.SelectedItem = null;
                }

            }
            catch(Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_seach_PID.Clear();
                    cmd_serch_brands.SelectedItem = null;
                }
            }
            

        }

        private void rad_showAll_CheckedChanged(object sender, EventArgs e)
        {
            txt_seach_PID.Enabled = false;
            cmd_serch_brands.Enabled = false;
            txt_seach_PID.Clear();
            cmd_serch_brands.SelectedItem = null;
        }

        private void rad_band_CheckedChanged(object sender, EventArgs e)
        {
            txt_seach_PID.Enabled = false;
            cmd_serch_brands.Enabled = true;
            txt_seach_PID.Clear();
          
        }

        private void btn_update_scan_Click(object sender, EventArgs e)
        {
            try
            {
                videoCap = new VideoCaptureDevice(Filter[cmb_video_out.SelectedIndex].MonikerString);
                videoCap.NewFrame += videoCap_NewFrame;
                videoCap.Start();

                panel_barcode_first.Show();
                panel_barcode_second.Show();
                txt_barcode_add.Clear();




                btn_add_product.Enabled = false;
                btn_delete_product.Enabled = false;
                btn_update_product.Enabled = false;
                btn_view_product.Enabled = false;
                btn_back_f_sell.Enabled = false;
                btn_update_scan.Enabled = false;
                btn_update_image.Enabled = false;
                btn_update_clear.Enabled = false;
                btn_update.Enabled = false;

                btn_add_barcode.Enabled = true;
            }
            catch(Exception)
            {
                panel_barcode_first.Hide();
                panel_barcode_second.Hide();

                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode Reading camera not detected.please check camera or insert barcode ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(dr == DialogResult.OK)
                {
                    txt_update_barcode.Focus();

                    txt_barcode_add.Clear();
                    btn_add_product.Enabled = true;
                    btn_delete_product.Enabled = true;
                    btn_update_product.Enabled = true;
                    btn_view_product.Enabled = true;
                    btn_back_f_sell.Enabled = true;
                    btn_update_scan.Enabled = true;
                    btn_update_image.Enabled = true;
                    btn_update_clear.Enabled = true;
                    btn_update.Enabled = true;
                }
            }

            
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
        byte[] convertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }

        public Image ConvertbyteArraryToImage(byte data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                Image img = Image.FromStream(ms);
                return img;
            }
        }
        private void btn_update_image_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp", Multiselect = false })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string filename = dialog.FileName;
                        txt_update_image.Text = filename;
                        updateImage_pb.Show();
                        updateImage_pb.Image = Image.FromFile(dialog.FileName);
                        updateImage_full.Image = Image.FromFile(dialog.FileName);

                    }
                }

            }
            catch (System.FormatException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_update_image.Focus();
                    txt_update_image.Clear();
                }
            }
            catch (OutOfMemoryException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_update_image.Focus();
                    txt_update_image.Clear();
                }
            }
            catch (NotSupportedException)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Image Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_update_image.Focus();
                    txt_update_image.Clear();
                }
            }
            catch (FileNotFoundException)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Image Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_update_image.Focus();
                    txt_update_image.Clear();
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_update_image.Focus();
                    txt_update_image.Clear();
                }
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_update_PID.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this,"Product ID cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_seach_PID.Focus();
                    }
                }
                else if(txt_update_PID.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_seach_PID.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_update_name.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product Name cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_update_name.Focus();
                    }
                }
                else if (txt_update_name.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product Name cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_update_name.Focus();
                    }
                }
                else if(cmb_update_brand.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please select brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_update_brand.Focus();
                    }
                }
                else if (cmb_update_category.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please select category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                       cmb_update_category.Focus();
                    }
                }
                else if(string.IsNullOrEmpty(txt_update_barcode.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_update_barcode.Focus();
                    }
                }
                else if (txt_update_barcode.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_update_barcode.Focus();
                    }
                }
                else if(string.IsNullOrEmpty(txt_update_price.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Price cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_update_price.Focus();
                    }
                }
                else if(txt_update_price.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Price cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_update_price.Focus();
                    }
                }
                else if (txt_update_price.Text.Any(char.IsLetter))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Price cannot have letter.number only", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_update_price.Focus();
                    }
                }
                else if(string.IsNullOrEmpty(txt_update_image.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        btn_update_image.Focus();
                    }
                }
                else
                {
                    ManageItems mi1 = new ManageItems();
                    int i = mi1.UpdateProduct("Update Product set Pro_Name = '"+txt_update_name.Text+ "',Brand = '"+cmb_update_brand.Text+ "',Category = '"+cmb_update_category.Text+ "',Barcode = '"+txt_update_barcode.Text+ "',Price = '"+txt_update_price.Text+ "',Pro_Image = '"+convertImageToByte(updateImage_pb.Image)+"'  where Pro_ID = '"+txt_update_PID.Text+"' ");

                    if(i==1)
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product update successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            PcName = Environment.MachineName;
                            Operation = "Update";
                            tableName = "Product";


                            databaseclass db1 = new databaseclass();
                            db1.database_record("insert into Database_records (Emp_ID,Emp_First_Name,Emp_Second_Name,Pc_Name,Operation,TableName ) values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "','" + tableName + "' )");


                            txt_update_PID.Clear();
                            txt_update_price.Clear();
                            txt_update_name.Clear();
                            cmb_update_brand.SelectedItem = null;
                            cmb_update_category.SelectedItem = null;
                            txt_update_barcode.Clear();
                            txt_update_image.Clear();
                            updateImage_full.Image = null;
                            updateImage_pb.Image = null;
                            updateImage_pb.Hide();
                        }
                    }
                    else
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Cannot update Product.check again ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dr == DialogResult.OK)
                        {
                            txt_update_PID.Clear();
                            txt_update_price.Clear();
                            txt_update_name.Clear();
                            cmb_update_brand.SelectedItem = null;
                            cmb_update_category.SelectedItem = null;
                            txt_update_barcode.Clear();
                            txt_update_image.Clear();
                            updateImage_full.Image = null;
                            updateImage_pb.Image = null;
                            updateImage_pb.Hide();
                        }
                    }

                }

            }
            catch(System.FormatException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dr == DialogResult.OK)
                {
                    txt_update_PID.Clear();
                    txt_update_price.Clear();
                    txt_update_name.Clear();
                    cmb_update_brand.SelectedItem = null;
                    cmb_update_category.SelectedItem = null;
                    txt_update_barcode.Clear();
                    txt_update_image.Clear();
                    updateImage_full.Image = null;
                    updateImage_pb.Image = null;
                    updateImage_pb.Hide();
                }
            }
            catch(OutOfMemoryException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_update_PID.Clear();
                    txt_update_price.Clear();
                    txt_update_name.Clear();
                    cmb_update_brand.SelectedItem = null;
                    cmb_update_category.SelectedItem = null;
                    txt_update_barcode.Clear();
                    txt_update_image.Clear();
                    updateImage_full.Image = null;
                    updateImage_pb.Image = null;
                    updateImage_pb.Hide();
                }
            }
            catch(NotSupportedException)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this,"Please Select Image Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    btn_update_image.Focus();
                }
            }
            catch(FileNotFoundException)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Image Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    btn_update_image.Focus();
                }
            }
            catch(Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_update_PID.Clear();
                    txt_update_price.Clear();
                    txt_update_name.Clear();
                    cmb_update_brand.SelectedItem = null;
                    cmb_update_category.SelectedItem = null;
                    txt_update_barcode.Clear();
                    txt_update_image.Clear();
                    updateImage_full.Image = null;
                    updateImage_pb.Image = null;
                    updateImage_pb.Hide();
                }
            }
        }

        private void btn_update_clear_Click(object sender, EventArgs e)
        {
            txt_update_PID.Clear();
            txt_update_price.Clear();
            txt_update_name.Clear();
            cmb_update_brand.SelectedItem = null;
            cmb_update_category.SelectedItem = null;
            txt_update_barcode.Clear();
            txt_update_image.Clear();
            updateImage_full.Image = null;
            updateImage_pb.Image = null;
            updateImage_pb.Hide();
        }


        private void btn_barcode_back_Click(object sender, EventArgs e)
        {
            panel_barcode_first.Hide();
            panel_barcode_second.Hide();
            txt_barcode_add.Clear();

            if (videoCap != null)
            {
                if (videoCap.IsRunning)
                {
                    videoCap.Stop();
                }

            }
            btn_add_product.Enabled = true;
            btn_delete_product.Enabled = true;
            btn_update_product.Enabled = true;
            btn_view_product.Enabled = true;
            btn_back_f_sell.Enabled = true;
            btn_update_scan.Enabled = true;
            btn_update_image.Enabled = true;
            btn_update_clear.Enabled = true;
            btn_update.Enabled = true;


            btn_addImage.Enabled = true;
            btn_add.Enabled = true;
            btn_add.Enabled = true;
            btn_clear.Enabled = true;

        }

        private void btn_add_barcode_Click(object sender, EventArgs e)
        {
            if(txt_barcode_add.Text != null)
            {
                string barcode = txt_barcode_add.Text.ToString();
                txt_update_barcode.Text = barcode;

                txt_add_barcode.Text = barcode;
            }
            panel_barcode_first.Hide();
            panel_barcode_second.Hide();

            btn_add_product.Enabled = true;
            btn_delete_product.Enabled = true;
            btn_update_product.Enabled = true;
            btn_view_product.Enabled = true;
            btn_back_f_sell.Enabled = true;
            btn_update_scan.Enabled = true;
            btn_update_image.Enabled = true;
            btn_update_clear.Enabled = true;
            btn_update.Enabled = true;

            btn_addImage.Enabled = true;
            btn_add.Enabled = true;
            btn_add.Enabled = true;
            btn_clear.Enabled = true;

        }

        private void manage_sell_items_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCap != null)
            {
                if (videoCap.IsRunning)
                {
                    videoCap.Stop();
                }

            }
        }

        private void updateImage_pb_MouseEnter(object sender, EventArgs e)
        {
            if(updateImage_pb.Image !=null)
            {
                updateImage_full.Visible = true;

            }


        }

        private void updateImage_pb_MouseLeave(object sender, EventArgs e)
        {
            updateImage_full.Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_delete_PID.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_delete_PID.Focus();
                    }
                }
                else if(txt_delete_PID.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_delete_PID.Focus();
                    }
                }
                else
                {
                    ManageItems mi2 = new ManageItems();
                    DataTable dt = mi2.ViewProduct("Select * from Product where Pro_ID = '" + txt_delete_PID.Text + "' ");

                    if (dt.Rows.Count == 1)
                    {
                        int i = mi2.DeleteProduct("Delete From Product where Pro_ID = '" + txt_delete_PID.Text + "'   ");
                        if (i == 1)
                        {
                            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dr == DialogResult.OK)
                            {
                                PcName = Environment.MachineName;
                                Operation = "Delete";
                                tableName = "Product";


                                databaseclass db1 = new databaseclass();
                                db1.database_record("insert into Database_records (Emp_ID,Emp_First_Name,Emp_Second_Name,Pc_Name,Operation,TableName ) values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "','" + tableName + "' )");

                                txt_delete_PID.Clear();
                            }
                        }
                        else
                        {
                            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "cannot delete data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (dr == DialogResult.OK)
                            {
                                txt_delete_PID.Focus();
                            }
                        }


                    }
                    else
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please check Product ID.no data found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            txt_delete_PID.Focus();
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_delete_PID.Clear();                }
            }

        }

        private void btn_delete_clear_Click(object sender, EventArgs e)
        {
            txt_delete_PID.Clear();
        }

        private void add_barcode_Click(object sender, EventArgs e)
        {
            try
            {
                videoCap = new VideoCaptureDevice(Filter[cmb_video_out.SelectedIndex].MonikerString);
                videoCap.NewFrame += videoCap_NewFrame;
                videoCap.Start();

                panel_barcode_first.Show();
                panel_barcode_second.Show();
                txt_barcode_add.Clear();




                btn_add_product.Enabled = false;
                btn_delete_product.Enabled = false;
                btn_update_product.Enabled = false;
                btn_view_product.Enabled = false;
                btn_back_f_sell.Enabled = false;
                btn_update_scan.Enabled = false;
                btn_update_image.Enabled = false;
                btn_update_clear.Enabled = false;
                btn_update.Enabled = false;

                btn_addImage.Enabled = false;
                btn_add.Enabled = false;
                btn_add_barcode.Enabled = false;
                btn_clear.Enabled = false;

                btn_add_barcode.Enabled = true;
            }
            catch (Exception)
            {
                panel_barcode_first.Hide();
                panel_barcode_second.Hide();

                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode Reading camera not detected.please check camera or insert barcode ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    txt_update_barcode.Focus();

                    txt_barcode_add.Clear();
                    btn_add_product.Enabled = true;
                    btn_delete_product.Enabled = true;
                    btn_update_product.Enabled = true;
                    btn_view_product.Enabled = true;
                    btn_back_f_sell.Enabled = true;
                    btn_update_scan.Enabled = true;
                    btn_update_image.Enabled = true;
                    btn_update_clear.Enabled = true;
                    btn_update.Enabled = true;

                    btn_addImage.Enabled = true;
                    btn_add.Enabled = true;
                    btn_add.Enabled = true;
                    btn_clear.Enabled = true;
                }
            }
        }
        public string imagecode;
        private void btn_addImage_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp", Multiselect = false })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string filename = dialog.FileName;
                       
                        add_image.Show();
                        imagecode  = Convert.ToBase64String(File.ReadAllBytes(filename));
                        txt_add_Image.Text = filename;
                        add_image_Full.Image = Image.FromFile(dialog.FileName);
                        add_image.Image = Image.FromFile(dialog.FileName);

                    }
                }

            }
            catch (System.FormatException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_add_Image.Focus();
                    txt_add_Image.Clear();
                }
            }
            catch (OutOfMemoryException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_add_Image.Focus();
                    txt_add_Image.Clear();
                }
            }
            catch (NotSupportedException)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Image Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_add_Image.Focus();
                    txt_add_Image.Clear();
                }
            }
            catch (FileNotFoundException)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Image Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_add_Image.Focus();
                    txt_add_Image.Clear();
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_add_Image.Focus();
                    txt_add_Image.Clear();
                }
            }
        }

        private void add_image_MouseEnter(object sender, EventArgs e)
        {
            if(add_image.Image != null)
            {
                add_image_Full.Visible = true;
            }

        }

        private void add_image_MouseLeave(object sender, EventArgs e)
        {
            add_image_Full.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_add_PID.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_add_PID.Focus();
                    }
                }
                else if (txt_add_PID.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product ID cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_add_PID.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_add_name.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product Name cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_add_name.Focus();
                    }
                }
                else if (txt_add_name.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product Name cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_add_name.Focus();
                    }
                }
                else if (cmb_add_brand.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please select brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_add_brand.Focus();
                    }
                }
                else if (cmb_add_category.SelectedItem == null)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please select category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        cmb_add_category.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_add_barcode.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_add_barcode.Focus();
                    }
                }
                else if (txt_add_barcode.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Barcode cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_add_barcode.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_add_price.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Price  cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_add_price.Focus();
                    }
                }
                else if (txt_add_price.Text.Any(char.IsWhiteSpace))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Price  cannot have space", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_add_price.Focus();
                    }
                }
                else if (txt_add_price.Text.Any(char.IsLetter))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Price  cannot have letter.number only", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        txt_update_price.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txt_add_Image.Text))
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        btn_addImage.Focus();
                    }
                }
                else
                {
                    ManageItems mi1 = new ManageItems();
                    int i = mi1.AddProduct("Insert into Product values('"+txt_add_PID.Text+"','"+txt_add_name.Text+"','"+cmb_add_brand.SelectedItem+"','"+cmb_add_category.SelectedItem+"','"+txt_add_barcode.Text+"','"+txt_add_price.Text+"','"+imagecode+"')"); 

                    if (i == 1)
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Product Add successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            PcName = Environment.MachineName;
                            Operation = "Insert";
                            tableName = "Product";


                            databaseclass db1 = new databaseclass();
                            db1.database_record("insert into Database_records (Emp_ID,Emp_First_Name,Emp_Second_Name,Pc_Name,Operation,TableName ) values('" + EmpId + "','" + UFName + "','" + USName + "','" + PcName + "','" + Operation + "','" + tableName + "' )");

                            txt_add_PID.Clear();
                            txt_add_Image.Clear();
                            txt_add_name.Clear();
                            cmb_add_brand.SelectedItem = null;
                            cmb_add_category.SelectedItem = null;
                            txt_add_price.Clear();
                            txt_add_barcode.Clear();
                            add_image.Image = null;
                            add_image_Full.Image = null;
                            add_image.Hide();
                        }
                    }
                    else
                    {
                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Cannot add Product.check again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dr == DialogResult.OK)
                        {
                            txt_add_PID.Clear();
                            txt_add_Image.Clear();
                            txt_add_name.Clear();
                            cmb_add_brand.SelectedItem = null;
                            cmb_add_category.SelectedItem = null;
                            txt_add_price.Clear();
                            txt_add_barcode.Clear();
                            add_image.Image = null;
                            add_image_Full.Image = null;
                            add_image.Hide();
                        }
                    }

                }

            }
            catch (System.FormatException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_add_PID.Clear();
                    txt_add_Image.Clear();
                    txt_add_name.Clear();
                    cmb_add_brand.SelectedItem = null;
                    cmb_add_category.SelectedItem = null;
                    txt_add_price.Clear();
                    txt_add_barcode.Clear();
                    add_image.Image = null;
                    add_image_Full.Image = null;
                    add_image.Hide();
                }
            }
            catch (OutOfMemoryException ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_add_PID.Clear();
                    txt_add_Image.Clear();
                    txt_add_name.Clear();
                    cmb_add_brand.SelectedItem = null;
                    cmb_add_category.SelectedItem = null;
                    txt_add_price.Clear();
                    txt_add_barcode.Clear();
                    add_image.Image = null;
                    add_image_Full.Image = null;
                    add_image.Hide();
                }
            }
            catch (NotSupportedException)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Image Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    btn_update_image.Focus();
                }
            }
            catch (FileNotFoundException)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Please Select Image Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    btn_update_image.Focus();
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    txt_add_PID.Clear();
                    txt_add_Image.Clear();
                    txt_add_name.Clear();
                    cmb_add_brand.SelectedItem = null;
                    cmb_add_category.SelectedItem = null;
                    txt_add_price.Clear();
                    txt_add_barcode.Clear();
                    add_image.Image = null;
                    add_image_Full.Image = null;
                    add_image.Hide();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_add_PID.Clear();
            txt_add_Image.Clear();
            txt_add_name.Clear();
            cmb_add_brand.SelectedItem = null;
            cmb_add_category.SelectedItem = null;
            txt_add_price.Clear();
            txt_add_barcode.Clear();
            add_image.Image = null;
            add_image_Full.Image = null;
            add_image.Hide();
        }

        private void product_grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           e.Cancel = true;
        }
    }
}
