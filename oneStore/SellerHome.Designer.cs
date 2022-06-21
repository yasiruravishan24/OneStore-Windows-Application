
namespace oneStore
{
    partial class SellerHome
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
            this.seller_pb = new System.Windows.Forms.PictureBox();
            this.btn_pofile_settings = new MetroFramework.Controls.MetroTile();
            this.btn_logout = new MetroFramework.Controls.MetroTile();
            this.btn_sell_item = new MetroFramework.Controls.MetroTile();
            this.btn_loyalty_reg = new MetroFramework.Controls.MetroTile();
            this.btn_view_item = new MetroFramework.Controls.MetroTile();
            this.btn_reports = new MetroFramework.Controls.MetroTile();
            this.lbl_homename = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.seller_home_control = new JDragControl.JDragControl(this.components);
            this.panel_logout = new System.Windows.Forms.Panel();
            this.panel_logout_second = new System.Windows.Forms.Panel();
            this.lbl_logout_second = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.ArduinoUno = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.seller_pb)).BeginInit();
            this.panel_logout.SuspendLayout();
            this.panel_logout_second.SuspendLayout();
            this.SuspendLayout();
            // 
            // seller_pb
            // 
            this.seller_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seller_pb.Image = global::oneStore.Properties.Resources.shome;
            this.seller_pb.Location = new System.Drawing.Point(0, 0);
            this.seller_pb.Name = "seller_pb";
            this.seller_pb.Size = new System.Drawing.Size(923, 552);
            this.seller_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.seller_pb.TabIndex = 0;
            this.seller_pb.TabStop = false;
            // 
            // btn_pofile_settings
            // 
            this.btn_pofile_settings.ActiveControl = null;
            this.btn_pofile_settings.Location = new System.Drawing.Point(23, 101);
            this.btn_pofile_settings.Name = "btn_pofile_settings";
            this.btn_pofile_settings.Size = new System.Drawing.Size(176, 50);
            this.btn_pofile_settings.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_pofile_settings.TabIndex = 1;
            this.btn_pofile_settings.Text = "PROFILE SETTINGS";
            this.btn_pofile_settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pofile_settings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_pofile_settings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_pofile_settings.UseSelectable = true;
            this.btn_pofile_settings.Click += new System.EventHandler(this.btn_pofile_settings_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.ActiveControl = null;
            this.btn_logout.Location = new System.Drawing.Point(23, 157);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(176, 50);
            this.btn_logout.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "LOG OUT";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_logout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_logout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_logout.UseSelectable = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_sell_item
            // 
            this.btn_sell_item.ActiveControl = null;
            this.btn_sell_item.Location = new System.Drawing.Point(233, 101);
            this.btn_sell_item.Name = "btn_sell_item";
            this.btn_sell_item.Size = new System.Drawing.Size(296, 50);
            this.btn_sell_item.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sell_item.TabIndex = 1;
            this.btn_sell_item.Text = "Sell Items";
            this.btn_sell_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sell_item.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sell_item.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sell_item.UseSelectable = true;
            this.btn_sell_item.Click += new System.EventHandler(this.btn_sell_item_Click);
            // 
            // btn_loyalty_reg
            // 
            this.btn_loyalty_reg.ActiveControl = null;
            this.btn_loyalty_reg.Location = new System.Drawing.Point(233, 166);
            this.btn_loyalty_reg.Name = "btn_loyalty_reg";
            this.btn_loyalty_reg.Size = new System.Drawing.Size(296, 50);
            this.btn_loyalty_reg.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_loyalty_reg.TabIndex = 1;
            this.btn_loyalty_reg.Text = "Register loyalty Card";
            this.btn_loyalty_reg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loyalty_reg.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_loyalty_reg.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_loyalty_reg.UseSelectable = true;
            this.btn_loyalty_reg.Click += new System.EventHandler(this.btn_loyalty_reg_Click);
            // 
            // btn_view_item
            // 
            this.btn_view_item.ActiveControl = null;
            this.btn_view_item.Location = new System.Drawing.Point(233, 232);
            this.btn_view_item.Name = "btn_view_item";
            this.btn_view_item.Size = new System.Drawing.Size(296, 50);
            this.btn_view_item.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_view_item.TabIndex = 1;
            this.btn_view_item.Text = "View Items";
            this.btn_view_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_item.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_view_item.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_view_item.UseSelectable = true;
            this.btn_view_item.Click += new System.EventHandler(this.btn_view_item_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.ActiveControl = null;
            this.btn_reports.Location = new System.Drawing.Point(233, 297);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(296, 50);
            this.btn_reports.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_reports.TabIndex = 1;
            this.btn_reports.Text = "Reports";
            this.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_reports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_reports.UseSelectable = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // lbl_homename
            // 
            this.lbl_homename.AutoSize = true;
            this.lbl_homename.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homename.Location = new System.Drawing.Point(238, 34);
            this.lbl_homename.Name = "lbl_homename";
            this.lbl_homename.Size = new System.Drawing.Size(253, 37);
            this.lbl_homename.TabIndex = 4;
            this.lbl_homename.Text = "SELLER HOME";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackgroundImage = global::oneStore.Properties.Resources.minimize;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(847, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_minimize.TabIndex = 5;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::oneStore.Properties.Resources.exit;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(883, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(32, 32);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // seller_home_control
            // 
            this.seller_home_control.GetForm = this;
            this.seller_home_control.TargetControl = this.seller_pb;
            // 
            // panel_logout
            // 
            this.panel_logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_logout.Controls.Add(this.panel_logout_second);
            this.panel_logout.Location = new System.Drawing.Point(136, 160);
            this.panel_logout.Name = "panel_logout";
            this.panel_logout.Size = new System.Drawing.Size(651, 232);
            this.panel_logout.TabIndex = 12;
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
            // SellerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.panel_logout);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.lbl_homename);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_view_item);
            this.Controls.Add(this.btn_loyalty_reg);
            this.Controls.Add(this.btn_sell_item);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_pofile_settings);
            this.Controls.Add(this.seller_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SallerHome";
            this.Load += new System.EventHandler(this.SellerHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seller_pb)).EndInit();
            this.panel_logout.ResumeLayout(false);
            this.panel_logout_second.ResumeLayout(false);
            this.panel_logout_second.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox seller_pb;
        private MetroFramework.Controls.MetroTile btn_pofile_settings;
        private MetroFramework.Controls.MetroTile btn_logout;
        private MetroFramework.Controls.MetroTile btn_sell_item;
        private MetroFramework.Controls.MetroTile btn_loyalty_reg;
        private MetroFramework.Controls.MetroTile btn_view_item;
        private MetroFramework.Controls.MetroTile btn_reports;
        private System.Windows.Forms.Label lbl_homename;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private JDragControl.JDragControl seller_home_control;
        private System.Windows.Forms.Panel panel_logout;
        private System.Windows.Forms.Panel panel_logout_second;
        private System.Windows.Forms.Label lbl_logout_second;
        private System.Windows.Forms.Label lbl_logout;
        private System.IO.Ports.SerialPort ArduinoUno;
    }
}