
namespace oneStore
{
    partial class StoreLigth_appColor
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
            this.storeLightColor_pb = new System.Windows.Forms.PictureBox();
            this.btn_storeLigthColor = new MetroFramework.Controls.MetroTile();
            this.btn_appColor = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.lbl_storeLigthColor = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.storeLightColor = new JDragControl.JDragControl(this.components);
            this.light_panel = new System.Windows.Forms.Panel();
            this.lbl_magent = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_cyan = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_yellow = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_colorpanel = new System.Windows.Forms.Label();
            this.color_panel = new System.Windows.Forms.Panel();
            this.btn_cyan = new System.Windows.Forms.Button();
            this.btn_megenta = new System.Windows.Forms.Button();
            this.btn_lime = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.arduinoNano = new System.IO.Ports.SerialPort(this.components);
            this.applicationColor_panel = new System.Windows.Forms.Panel();
            this.cmb_colorPick = new MetroFramework.Controls.MetroComboBox();
            this.lbl_theme_color = new System.Windows.Forms.Label();
            this.btn_saveTheme = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.storeLightColor_pb)).BeginInit();
            this.light_panel.SuspendLayout();
            this.color_panel.SuspendLayout();
            this.applicationColor_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeLightColor_pb
            // 
            this.storeLightColor_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeLightColor_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.storeLightColor_pb.Location = new System.Drawing.Point(0, 0);
            this.storeLightColor_pb.Name = "storeLightColor_pb";
            this.storeLightColor_pb.Size = new System.Drawing.Size(923, 552);
            this.storeLightColor_pb.TabIndex = 0;
            this.storeLightColor_pb.TabStop = false;
            // 
            // btn_storeLigthColor
            // 
            this.btn_storeLigthColor.ActiveControl = null;
            this.btn_storeLigthColor.Location = new System.Drawing.Point(12, 72);
            this.btn_storeLigthColor.Name = "btn_storeLigthColor";
            this.btn_storeLigthColor.Size = new System.Drawing.Size(203, 50);
            this.btn_storeLigthColor.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_storeLigthColor.TabIndex = 1;
            this.btn_storeLigthColor.Text = "Store Light";
            this.btn_storeLigthColor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_storeLigthColor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_storeLigthColor.UseSelectable = true;
            this.btn_storeLigthColor.Click += new System.EventHandler(this.btn_storeLigthColor_Click);
            // 
            // btn_appColor
            // 
            this.btn_appColor.ActiveControl = null;
            this.btn_appColor.Location = new System.Drawing.Point(12, 128);
            this.btn_appColor.Name = "btn_appColor";
            this.btn_appColor.Size = new System.Drawing.Size(203, 50);
            this.btn_appColor.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_appColor.TabIndex = 1;
            this.btn_appColor.Text = "Application Color";
            this.btn_appColor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_appColor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_appColor.UseSelectable = true;
            this.btn_appColor.Click += new System.EventHandler(this.btn_appColor_Click);
            // 
            // btn_back
            // 
            this.btn_back.ActiveControl = null;
            this.btn_back.Location = new System.Drawing.Point(26, 431);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(176, 50);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "BACK";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_back.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_storeLigthColor
            // 
            this.lbl_storeLigthColor.AutoSize = true;
            this.lbl_storeLigthColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storeLigthColor.Location = new System.Drawing.Point(235, 14);
            this.lbl_storeLigthColor.Name = "lbl_storeLigthColor";
            this.lbl_storeLigthColor.Size = new System.Drawing.Size(535, 37);
            this.lbl_storeLigthColor.TabIndex = 2;
            this.lbl_storeLigthColor.Text = "Store Light And  Application Color";
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
            this.btn_minimize.TabIndex = 3;
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
            this.btn_exit.TabIndex = 3;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // storeLightColor
            // 
            this.storeLightColor.GetForm = this;
            this.storeLightColor.TargetControl = this.storeLightColor_pb;
            // 
            // light_panel
            // 
            this.light_panel.BackColor = System.Drawing.Color.Red;
            this.light_panel.Controls.Add(this.lbl_magent);
            this.light_panel.Controls.Add(this.lbl_blue);
            this.light_panel.Controls.Add(this.lbl_cyan);
            this.light_panel.Controls.Add(this.lbl_green);
            this.light_panel.Controls.Add(this.lbl_yellow);
            this.light_panel.Controls.Add(this.lbl_red);
            this.light_panel.Controls.Add(this.lbl_colorpanel);
            this.light_panel.Controls.Add(this.color_panel);
            this.light_panel.Location = new System.Drawing.Point(235, 72);
            this.light_panel.Name = "light_panel";
            this.light_panel.Size = new System.Drawing.Size(680, 468);
            this.light_panel.TabIndex = 4;
            // 
            // lbl_magent
            // 
            this.lbl_magent.AutoSize = true;
            this.lbl_magent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_magent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_magent.Location = new System.Drawing.Point(98, 368);
            this.lbl_magent.Name = "lbl_magent";
            this.lbl_magent.Size = new System.Drawing.Size(179, 24);
            this.lbl_magent.TabIndex = 2;
            this.lbl_magent.Text = "Magenta Led Strip";
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue.Location = new System.Drawing.Point(98, 311);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(141, 24);
            this.lbl_blue.TabIndex = 2;
            this.lbl_blue.Text = "Blue Led Strip";
            // 
            // lbl_cyan
            // 
            this.lbl_cyan.AutoSize = true;
            this.lbl_cyan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cyan.Location = new System.Drawing.Point(98, 254);
            this.lbl_cyan.Name = "lbl_cyan";
            this.lbl_cyan.Size = new System.Drawing.Size(146, 24);
            this.lbl_cyan.TabIndex = 2;
            this.lbl_cyan.Text = "Cyan Led Strip";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.BackColor = System.Drawing.Color.Transparent;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green.Location = new System.Drawing.Point(98, 194);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(157, 24);
            this.lbl_green.TabIndex = 2;
            this.lbl_green.Text = "Green Led Strip";
            // 
            // lbl_yellow
            // 
            this.lbl_yellow.AutoSize = true;
            this.lbl_yellow.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yellow.Location = new System.Drawing.Point(98, 134);
            this.lbl_yellow.Name = "lbl_yellow";
            this.lbl_yellow.Size = new System.Drawing.Size(161, 24);
            this.lbl_yellow.TabIndex = 2;
            this.lbl_yellow.Text = "Yellow Led Strip";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.BackColor = System.Drawing.Color.Transparent;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.Location = new System.Drawing.Point(98, 75);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(137, 24);
            this.lbl_red.TabIndex = 2;
            this.lbl_red.Text = "Red Led Strip";
            // 
            // lbl_colorpanel
            // 
            this.lbl_colorpanel.AutoSize = true;
            this.lbl_colorpanel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_colorpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_colorpanel.Location = new System.Drawing.Point(369, 28);
            this.lbl_colorpanel.Name = "lbl_colorpanel";
            this.lbl_colorpanel.Size = new System.Drawing.Size(119, 24);
            this.lbl_colorpanel.TabIndex = 2;
            this.lbl_colorpanel.Text = "Color Panel";
            // 
            // color_panel
            // 
            this.color_panel.BackColor = System.Drawing.Color.Black;
            this.color_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.color_panel.Controls.Add(this.btn_cyan);
            this.color_panel.Controls.Add(this.btn_megenta);
            this.color_panel.Controls.Add(this.btn_lime);
            this.color_panel.Controls.Add(this.btn_blue);
            this.color_panel.Controls.Add(this.btn_yellow);
            this.color_panel.Controls.Add(this.btn_red);
            this.color_panel.Location = new System.Drawing.Point(298, 55);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(288, 361);
            this.color_panel.TabIndex = 1;
            // 
            // btn_cyan
            // 
            this.btn_cyan.BackColor = System.Drawing.Color.Cyan;
            this.btn_cyan.Location = new System.Drawing.Point(4, 183);
            this.btn_cyan.Name = "btn_cyan";
            this.btn_cyan.Size = new System.Drawing.Size(278, 57);
            this.btn_cyan.TabIndex = 0;
            this.btn_cyan.UseVisualStyleBackColor = false;
            this.btn_cyan.Click += new System.EventHandler(this.btn_cyan_Click);
            // 
            // btn_megenta
            // 
            this.btn_megenta.BackColor = System.Drawing.Color.Magenta;
            this.btn_megenta.Location = new System.Drawing.Point(4, 297);
            this.btn_megenta.Name = "btn_megenta";
            this.btn_megenta.Size = new System.Drawing.Size(278, 57);
            this.btn_megenta.TabIndex = 0;
            this.btn_megenta.UseVisualStyleBackColor = false;
            this.btn_megenta.Click += new System.EventHandler(this.btn_megenta_Click);
            // 
            // btn_lime
            // 
            this.btn_lime.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_lime.Location = new System.Drawing.Point(4, 123);
            this.btn_lime.Name = "btn_lime";
            this.btn_lime.Size = new System.Drawing.Size(278, 57);
            this.btn_lime.TabIndex = 0;
            this.btn_lime.UseVisualStyleBackColor = false;
            this.btn_lime.Click += new System.EventHandler(this.btn_lime_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.BackColor = System.Drawing.Color.Blue;
            this.btn_blue.Location = new System.Drawing.Point(4, 240);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(278, 57);
            this.btn_blue.TabIndex = 0;
            this.btn_blue.UseVisualStyleBackColor = false;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow.Location = new System.Drawing.Point(4, 63);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(278, 57);
            this.btn_yellow.TabIndex = 0;
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.Location = new System.Drawing.Point(4, 4);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(278, 57);
            this.btn_red.TabIndex = 0;
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // arduinoNano
            // 
            this.arduinoNano.PortName = "COM18";
            // 
            // applicationColor_panel
            // 
            this.applicationColor_panel.BackColor = System.Drawing.Color.Red;
            this.applicationColor_panel.Controls.Add(this.cmb_colorPick);
            this.applicationColor_panel.Controls.Add(this.lbl_theme_color);
            this.applicationColor_panel.Controls.Add(this.btn_saveTheme);
            this.applicationColor_panel.Location = new System.Drawing.Point(235, 72);
            this.applicationColor_panel.Name = "applicationColor_panel";
            this.applicationColor_panel.Size = new System.Drawing.Size(680, 468);
            this.applicationColor_panel.TabIndex = 3;
            // 
            // cmb_colorPick
            // 
            this.cmb_colorPick.FormattingEnabled = true;
            this.cmb_colorPick.ItemHeight = 23;
            this.cmb_colorPick.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Green",
            "Cyan",
            "Blue",
            "Magenta"});
            this.cmb_colorPick.Location = new System.Drawing.Point(297, 78);
            this.cmb_colorPick.Name = "cmb_colorPick";
            this.cmb_colorPick.Size = new System.Drawing.Size(261, 29);
            this.cmb_colorPick.TabIndex = 2;
            this.cmb_colorPick.UseSelectable = true;
            // 
            // lbl_theme_color
            // 
            this.lbl_theme_color.AutoSize = true;
            this.lbl_theme_color.BackColor = System.Drawing.Color.Transparent;
            this.lbl_theme_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_theme_color.Location = new System.Drawing.Point(57, 82);
            this.lbl_theme_color.Name = "lbl_theme_color";
            this.lbl_theme_color.Size = new System.Drawing.Size(219, 25);
            this.lbl_theme_color.TabIndex = 0;
            this.lbl_theme_color.Text = "Select Theme Color";
            // 
            // btn_saveTheme
            // 
            this.btn_saveTheme.ActiveControl = null;
            this.btn_saveTheme.Location = new System.Drawing.Point(259, 312);
            this.btn_saveTheme.Name = "btn_saveTheme";
            this.btn_saveTheme.Size = new System.Drawing.Size(203, 66);
            this.btn_saveTheme.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_saveTheme.TabIndex = 1;
            this.btn_saveTheme.Text = "SAVE";
            this.btn_saveTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_saveTheme.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_saveTheme.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_saveTheme.UseSelectable = true;
            this.btn_saveTheme.Click += new System.EventHandler(this.btn_saveTheme_Click);
            // 
            // StoreLigth_appColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.applicationColor_panel);
            this.Controls.Add(this.light_panel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.lbl_storeLigthColor);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_appColor);
            this.Controls.Add(this.btn_storeLigthColor);
            this.Controls.Add(this.storeLightColor_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreLigth_appColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreLigth_appColor";
            this.Load += new System.EventHandler(this.StoreLigth_appColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeLightColor_pb)).EndInit();
            this.light_panel.ResumeLayout(false);
            this.light_panel.PerformLayout();
            this.color_panel.ResumeLayout(false);
            this.applicationColor_panel.ResumeLayout(false);
            this.applicationColor_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox storeLightColor_pb;
        private MetroFramework.Controls.MetroTile btn_storeLigthColor;
        private MetroFramework.Controls.MetroTile btn_appColor;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Label lbl_storeLigthColor;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private JDragControl.JDragControl storeLightColor;
        private System.Windows.Forms.Panel light_panel;
        private System.Windows.Forms.Label lbl_magent;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_cyan;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_yellow;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label lbl_colorpanel;
        private System.Windows.Forms.Panel color_panel;
        private System.Windows.Forms.Button btn_cyan;
        private System.Windows.Forms.Button btn_megenta;
        private System.Windows.Forms.Button btn_lime;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_red;
        private System.IO.Ports.SerialPort arduinoNano;
        private System.Windows.Forms.Panel applicationColor_panel;
        private MetroFramework.Controls.MetroComboBox cmb_colorPick;
        private System.Windows.Forms.Label lbl_theme_color;
        private MetroFramework.Controls.MetroTile btn_saveTheme;
    }
}