
namespace oneStore
{
    partial class AdminHome
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
            this.components = new System.ComponentModel.Container();
            this.btn_mg_employee = new MetroFramework.Controls.MetroTile();
            this.btn_mg_product = new MetroFramework.Controls.MetroTile();
            this.btn_social_media = new MetroFramework.Controls.MetroTile();
            this.btn_Reports = new MetroFramework.Controls.MetroTile();
            this.btn_light_color = new MetroFramework.Controls.MetroTile();
            this.btn_Logout = new MetroFramework.Controls.MetroTile();
            this.btn_pofile_settings = new MetroFramework.Controls.MetroTile();
            this.adminHome_control = new JDragControl.JDragControl(this.components);
            this.adminh_pb = new System.Windows.Forms.PictureBox();
            this.lbl_homename = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_logout = new System.Windows.Forms.Panel();
            this.panel_logout_second = new System.Windows.Forms.Panel();
            this.lbl_logout_second = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.ArduinoUno = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adminh_pb)).BeginInit();
            this.panel_logout.SuspendLayout();
            this.panel_logout_second.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mg_employee
            // 
            this.btn_mg_employee.ActiveControl = null;
            this.btn_mg_employee.Location = new System.Drawing.Point(233, 231);
            this.btn_mg_employee.Name = "btn_mg_employee";
            this.btn_mg_employee.Size = new System.Drawing.Size(296, 50);
            this.btn_mg_employee.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_mg_employee.TabIndex = 5;
            this.btn_mg_employee.Text = "Manage Employee";
            this.btn_mg_employee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_mg_employee.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_mg_employee.UseSelectable = true;
            this.btn_mg_employee.Click += new System.EventHandler(this.btn_mg_employee_Click);
            // 
            // btn_mg_product
            // 
            this.btn_mg_product.ActiveControl = null;
            this.btn_mg_product.Location = new System.Drawing.Point(233, 101);
            this.btn_mg_product.Name = "btn_mg_product";
            this.btn_mg_product.Size = new System.Drawing.Size(296, 50);
            this.btn_mg_product.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_mg_product.TabIndex = 5;
            this.btn_mg_product.Text = "Manage Sell Items";
            this.btn_mg_product.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_mg_product.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_mg_product.UseSelectable = true;
            this.btn_mg_product.Click += new System.EventHandler(this.btn_mg_product_Click);
            // 
            // btn_social_media
            // 
            this.btn_social_media.ActiveControl = null;
            this.btn_social_media.Location = new System.Drawing.Point(233, 297);
            this.btn_social_media.Name = "btn_social_media";
            this.btn_social_media.Size = new System.Drawing.Size(296, 50);
            this.btn_social_media.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_social_media.TabIndex = 5;
            this.btn_social_media.Text = "Store Social Media";
            this.btn_social_media.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_social_media.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_social_media.UseSelectable = true;
            this.btn_social_media.Click += new System.EventHandler(this.btn_social_media_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.ActiveControl = null;
            this.btn_Reports.Location = new System.Drawing.Point(233, 166);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(296, 50);
            this.btn_Reports.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_Reports.TabIndex = 5;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Reports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Reports.UseSelectable = true;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_light_color
            // 
            this.btn_light_color.ActiveControl = null;
            this.btn_light_color.Location = new System.Drawing.Point(233, 362);
            this.btn_light_color.Name = "btn_light_color";
            this.btn_light_color.Size = new System.Drawing.Size(296, 50);
            this.btn_light_color.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_light_color.TabIndex = 5;
            this.btn_light_color.Text = "Store Light And Application Color";
            this.btn_light_color.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_light_color.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_light_color.UseSelectable = true;
            this.btn_light_color.Click += new System.EventHandler(this.btn_ligth_color_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.ActiveControl = null;
            this.btn_Logout.Location = new System.Drawing.Point(23, 162);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(176, 50);
            this.btn_Logout.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "LOG OUT";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Logout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Logout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Logout.UseSelectable = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click_1);
            // 
            // btn_pofile_settings
            // 
            this.btn_pofile_settings.ActiveControl = null;
            this.btn_pofile_settings.Location = new System.Drawing.Point(23, 101);
            this.btn_pofile_settings.Name = "btn_pofile_settings";
            this.btn_pofile_settings.Size = new System.Drawing.Size(176, 50);
            this.btn_pofile_settings.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_pofile_settings.TabIndex = 5;
            this.btn_pofile_settings.Text = "PROFILE SETTINGS";
            this.btn_pofile_settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pofile_settings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_pofile_settings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_pofile_settings.UseSelectable = true;
            this.btn_pofile_settings.Click += new System.EventHandler(this.btn_pofile_settings_Click);
            // 
            // adminHome_control
            // 
            this.adminHome_control.GetForm = this;
            this.adminHome_control.TargetControl = this.adminh_pb;
            // 
            // adminh_pb
            // 
            this.adminh_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminh_pb.Image = global::oneStore.Properties.Resources.adminhome11;
            this.adminh_pb.Location = new System.Drawing.Point(0, 0);
            this.adminh_pb.Name = "adminh_pb";
            this.adminh_pb.Size = new System.Drawing.Size(923, 552);
            this.adminh_pb.TabIndex = 6;
            this.adminh_pb.TabStop = false;
            // 
            // lbl_homename
            // 
            this.lbl_homename.AutoSize = true;
            this.lbl_homename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_homename.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homename.Location = new System.Drawing.Point(238, 34);
            this.lbl_homename.Name = "lbl_homename";
            this.lbl_homename.Size = new System.Drawing.Size(234, 37);
            this.lbl_homename.TabIndex = 10;
            this.lbl_homename.Text = "ADMIN HOME";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::oneStore.Properties.Resources.minimize;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(847, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_minimize.TabIndex = 9;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::oneStore.Properties.Resources.exit;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(883, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(32, 32);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // panel_logout
            // 
            this.panel_logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_logout.Controls.Add(this.panel_logout_second);
            this.panel_logout.Location = new System.Drawing.Point(144, 172);
            this.panel_logout.Name = "panel_logout";
            this.panel_logout.Size = new System.Drawing.Size(651, 232);
            this.panel_logout.TabIndex = 11;
            // 
            // panel_logout_second
            // 
            this.panel_logout_second.BackColor = System.Drawing.Color.Red;
            this.panel_logout_second.Controls.Add(this.lbl_logout_second);
            this.panel_logout_second.Controls.Add(this.lbl_logout);
            this.panel_logout_second.Location = new System.Drawing.Point(3, 3);
            this.panel_logout_second.Name = "panel_logout_second";
            this.panel_logout_second.Size = new System.Drawing.Size(645, 226);
            this.panel_logout_second.TabIndex = 0;
            // 
            // lbl_logout_second
            // 
            this.lbl_logout_second.AutoSize = true;
            this.lbl_logout_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout_second.Location = new System.Drawing.Point(33, 109);
            this.lbl_logout_second.Name = "lbl_logout_second";
            this.lbl_logout_second.Size = new System.Drawing.Size(269, 25);
            this.lbl_logout_second.TabIndex = 0;
            this.lbl_logout_second.Text = " Arduino code uploading....";
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(33, 36);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(164, 31);
            this.lbl_logout.TabIndex = 0;
            this.lbl_logout.Text = "Please wait";
            // 
            // ArduinoUno
            // 
            this.ArduinoUno.PortName = "COM4";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.panel_logout);
            this.Controls.Add(this.lbl_homename);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_pofile_settings);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_light_color);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_social_media);
            this.Controls.Add(this.btn_mg_product);
            this.Controls.Add(this.btn_mg_employee);
            this.Controls.Add(this.adminh_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminh_pb)).EndInit();
            this.panel_logout.ResumeLayout(false);
            this.panel_logout_second.ResumeLayout(false);
            this.panel_logout_second.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_mg_employee;
        private System.Windows.Forms.PictureBox adminh_pb;
        private MetroFramework.Controls.MetroTile btn_mg_product;
        private MetroFramework.Controls.MetroTile btn_social_media;
        private MetroFramework.Controls.MetroTile btn_Reports;
        private MetroFramework.Controls.MetroTile btn_light_color;
        private MetroFramework.Controls.MetroTile btn_Logout;
        private MetroFramework.Controls.MetroTile btn_pofile_settings;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_minimize;
        private JDragControl.JDragControl adminHome_control;
        private System.Windows.Forms.Label lbl_homename;
        private System.Windows.Forms.Panel panel_logout;
        private System.Windows.Forms.Panel panel_logout_second;
        private System.Windows.Forms.Label lbl_logout_second;
        private System.Windows.Forms.Label lbl_logout;
        private System.IO.Ports.SerialPort ArduinoUno;
    }
}