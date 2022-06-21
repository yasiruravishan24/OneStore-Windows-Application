
namespace oneStore
{
    partial class Reg_loyalty
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
            this.register_pb = new System.Windows.Forms.PictureBox();
            this.lbl_reg = new System.Windows.Forms.Label();
            this.btn_register = new MetroFramework.Controls.MetroTile();
            this.btn_view = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.regster_control = new JDragControl.JDragControl(this.components);
            this.panel_loyalty_view = new System.Windows.Forms.Panel();
            this.viewCustomer_dataGrid = new System.Windows.Forms.DataGridView();
            this.Customer_tel = new System.Windows.Forms.Label();
            this.txt_search_tel = new System.Windows.Forms.TextBox();
            this.btn_search = new MetroFramework.Controls.MetroTile();
            this.rad_showAll = new System.Windows.Forms.RadioButton();
            this.rad_phone = new System.Windows.Forms.RadioButton();
            this.panel_register = new System.Windows.Forms.Panel();
            this.lbl_cus_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_cus_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_cu_NIC = new System.Windows.Forms.Label();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.lbl_cus_tele = new System.Windows.Forms.Label();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.lbl_loy_no = new System.Windows.Forms.Label();
            this.txt_loy_no = new System.Windows.Forms.TextBox();
            this.btn_add = new MetroFramework.Controls.MetroTile();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_scan = new MetroFramework.Controls.MetroTile();
            this.panel_barcode_first = new System.Windows.Forms.Panel();
            this.panel_barcode_second = new System.Windows.Forms.Panel();
            this.btn_add_barcode = new MetroFramework.Controls.MetroTile();
            this.barcode_pb = new System.Windows.Forms.PictureBox();
            this.cmb_video_out = new MetroFramework.Controls.MetroComboBox();
            this.txt_barcode_add = new System.Windows.Forms.TextBox();
            this.btn_barcode_back = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.register_pb)).BeginInit();
            this.panel_loyalty_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomer_dataGrid)).BeginInit();
            this.panel_register.SuspendLayout();
            this.panel_barcode_first.SuspendLayout();
            this.panel_barcode_second.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // register_pb
            // 
            this.register_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.register_pb.Location = new System.Drawing.Point(0, 0);
            this.register_pb.Name = "register_pb";
            this.register_pb.Size = new System.Drawing.Size(923, 552);
            this.register_pb.TabIndex = 0;
            this.register_pb.TabStop = false;
            // 
            // lbl_reg
            // 
            this.lbl_reg.AutoSize = true;
            this.lbl_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg.Location = new System.Drawing.Point(235, 14);
            this.lbl_reg.Name = "lbl_reg";
            this.lbl_reg.Size = new System.Drawing.Size(343, 37);
            this.lbl_reg.TabIndex = 1;
            this.lbl_reg.Text = "Register Loyalty Card";
            // 
            // btn_register
            // 
            this.btn_register.ActiveControl = null;
            this.btn_register.Location = new System.Drawing.Point(12, 72);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(203, 50);
            this.btn_register.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register Customer";
            this.btn_register.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_register.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_register.UseSelectable = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_view
            // 
            this.btn_view.ActiveControl = null;
            this.btn_view.Location = new System.Drawing.Point(12, 128);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(203, 50);
            this.btn_view.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View Loyalty Details";
            this.btn_view.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_view.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_view.UseSelectable = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_back
            // 
            this.btn_back.ActiveControl = null;
            this.btn_back.Location = new System.Drawing.Point(26, 431);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(176, 50);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "BACK";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_back.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            // regster_control
            // 
            this.regster_control.GetForm = this;
            this.regster_control.TargetControl = this.register_pb;
            // 
            // panel_loyalty_view
            // 
            this.panel_loyalty_view.BackColor = System.Drawing.Color.Red;
            this.panel_loyalty_view.Controls.Add(this.rad_phone);
            this.panel_loyalty_view.Controls.Add(this.rad_showAll);
            this.panel_loyalty_view.Controls.Add(this.txt_search_tel);
            this.panel_loyalty_view.Controls.Add(this.Customer_tel);
            this.panel_loyalty_view.Controls.Add(this.viewCustomer_dataGrid);
            this.panel_loyalty_view.Controls.Add(this.btn_search);
            this.panel_loyalty_view.Location = new System.Drawing.Point(235, 72);
            this.panel_loyalty_view.Name = "panel_loyalty_view";
            this.panel_loyalty_view.Size = new System.Drawing.Size(680, 468);
            this.panel_loyalty_view.TabIndex = 4;
            // 
            // viewCustomer_dataGrid
            // 
            this.viewCustomer_dataGrid.AllowUserToAddRows = false;
            this.viewCustomer_dataGrid.AllowUserToDeleteRows = false;
            this.viewCustomer_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCustomer_dataGrid.Location = new System.Drawing.Point(6, 67);
            this.viewCustomer_dataGrid.Name = "viewCustomer_dataGrid";
            this.viewCustomer_dataGrid.ReadOnly = true;
            this.viewCustomer_dataGrid.Size = new System.Drawing.Size(669, 396);
            this.viewCustomer_dataGrid.TabIndex = 0;
            // 
            // Customer_tel
            // 
            this.Customer_tel.AutoSize = true;
            this.Customer_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_tel.Location = new System.Drawing.Point(15, 25);
            this.Customer_tel.Name = "Customer_tel";
            this.Customer_tel.Size = new System.Drawing.Size(152, 25);
            this.Customer_tel.TabIndex = 1;
            this.Customer_tel.Text = "Customer Tel";
            // 
            // txt_search_tel
            // 
            this.txt_search_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_tel.Location = new System.Drawing.Point(200, 23);
            this.txt_search_tel.Name = "txt_search_tel";
            this.txt_search_tel.Size = new System.Drawing.Size(192, 31);
            this.txt_search_tel.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.ActiveControl = null;
            this.btn_search.Location = new System.Drawing.Point(521, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(154, 50);
            this.btn_search.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "SEARCH";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_search.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rad_showAll
            // 
            this.rad_showAll.AutoSize = true;
            this.rad_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_showAll.Location = new System.Drawing.Point(409, 26);
            this.rad_showAll.Name = "rad_showAll";
            this.rad_showAll.Size = new System.Drawing.Size(96, 24);
            this.rad_showAll.TabIndex = 3;
            this.rad_showAll.TabStop = true;
            this.rad_showAll.Text = "Show All";
            this.rad_showAll.UseVisualStyleBackColor = true;
            this.rad_showAll.CheckedChanged += new System.EventHandler(this.rad_showAll_CheckedChanged);
            // 
            // rad_phone
            // 
            this.rad_phone.AutoSize = true;
            this.rad_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_phone.Location = new System.Drawing.Point(172, 32);
            this.rad_phone.Name = "rad_phone";
            this.rad_phone.Size = new System.Drawing.Size(14, 13);
            this.rad_phone.TabIndex = 3;
            this.rad_phone.TabStop = true;
            this.rad_phone.UseVisualStyleBackColor = true;
            this.rad_phone.CheckedChanged += new System.EventHandler(this.rad_phone_CheckedChanged);
            // 
            // panel_register
            // 
            this.panel_register.BackColor = System.Drawing.Color.Red;
            this.panel_register.Controls.Add(this.txt_loy_no);
            this.panel_register.Controls.Add(this.txt_tele);
            this.panel_register.Controls.Add(this.txt_nic);
            this.panel_register.Controls.Add(this.txt_name);
            this.panel_register.Controls.Add(this.btn_scan);
            this.panel_register.Controls.Add(this.btn_clear);
            this.panel_register.Controls.Add(this.btn_add);
            this.panel_register.Controls.Add(this.txt_id);
            this.panel_register.Controls.Add(this.lbl_loy_no);
            this.panel_register.Controls.Add(this.lbl_cus_tele);
            this.panel_register.Controls.Add(this.lbl_cu_NIC);
            this.panel_register.Controls.Add(this.lbl_cus_name);
            this.panel_register.Controls.Add(this.lbl_cus_id);
            this.panel_register.Location = new System.Drawing.Point(235, 72);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(680, 468);
            this.panel_register.TabIndex = 5;
            // 
            // lbl_cus_id
            // 
            this.lbl_cus_id.AutoSize = true;
            this.lbl_cus_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cus_id.Location = new System.Drawing.Point(28, 56);
            this.lbl_cus_id.Name = "lbl_cus_id";
            this.lbl_cus_id.Size = new System.Drawing.Size(141, 25);
            this.lbl_cus_id.TabIndex = 0;
            this.lbl_cus_id.Text = "Customer ID";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(271, 48);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(392, 31);
            this.txt_id.TabIndex = 1;
            // 
            // lbl_cus_name
            // 
            this.lbl_cus_name.AutoSize = true;
            this.lbl_cus_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cus_name.Location = new System.Drawing.Point(28, 109);
            this.lbl_cus_name.Name = "lbl_cus_name";
            this.lbl_cus_name.Size = new System.Drawing.Size(179, 25);
            this.lbl_cus_name.TabIndex = 0;
            this.lbl_cus_name.Text = "Customer Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(271, 103);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(392, 31);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_cu_NIC
            // 
            this.lbl_cu_NIC.AutoSize = true;
            this.lbl_cu_NIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cu_NIC.Location = new System.Drawing.Point(28, 167);
            this.lbl_cu_NIC.Name = "lbl_cu_NIC";
            this.lbl_cu_NIC.Size = new System.Drawing.Size(157, 25);
            this.lbl_cu_NIC.TabIndex = 0;
            this.lbl_cu_NIC.Text = "Customer NIC";
            // 
            // txt_nic
            // 
            this.txt_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nic.Location = new System.Drawing.Point(271, 161);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(392, 31);
            this.txt_nic.TabIndex = 1;
            // 
            // lbl_cus_tele
            // 
            this.lbl_cus_tele.AutoSize = true;
            this.lbl_cus_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cus_tele.Location = new System.Drawing.Point(28, 219);
            this.lbl_cus_tele.Name = "lbl_cus_tele";
            this.lbl_cus_tele.Size = new System.Drawing.Size(230, 25);
            this.lbl_cus_tele.TabIndex = 0;
            this.lbl_cus_tele.Text = "Customer Telephone";
            // 
            // txt_tele
            // 
            this.txt_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele.Location = new System.Drawing.Point(271, 213);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(392, 31);
            this.txt_tele.TabIndex = 1;
            // 
            // lbl_loy_no
            // 
            this.lbl_loy_no.AutoSize = true;
            this.lbl_loy_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loy_no.Location = new System.Drawing.Point(28, 270);
            this.lbl_loy_no.Name = "lbl_loy_no";
            this.lbl_loy_no.Size = new System.Drawing.Size(181, 25);
            this.lbl_loy_no.TabIndex = 0;
            this.lbl_loy_no.Text = "Loyalty Card No";
            // 
            // txt_loy_no
            // 
            this.txt_loy_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loy_no.Location = new System.Drawing.Point(271, 264);
            this.txt_loy_no.Name = "txt_loy_no";
            this.txt_loy_no.Size = new System.Drawing.Size(298, 31);
            this.txt_loy_no.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.ActiveControl = null;
            this.btn_add.Location = new System.Drawing.Point(137, 359);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(176, 50);
            this.btn_add.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_add.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(393, 359);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(176, 50);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_clear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.ActiveControl = null;
            this.btn_scan.Location = new System.Drawing.Point(575, 257);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(89, 46);
            this.btn_scan.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_scan.TabIndex = 2;
            this.btn_scan.Text = "SCAN";
            this.btn_scan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_scan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_scan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_scan.UseSelectable = true;
            this.btn_scan.Click += new System.EventHandler(this.SCAN_Click);
            // 
            // panel_barcode_first
            // 
            this.panel_barcode_first.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_barcode_first.Controls.Add(this.panel_barcode_second);
            this.panel_barcode_first.Location = new System.Drawing.Point(242, 72);
            this.panel_barcode_first.Name = "panel_barcode_first";
            this.panel_barcode_first.Size = new System.Drawing.Size(474, 404);
            this.panel_barcode_first.TabIndex = 7;
            // 
            // panel_barcode_second
            // 
            this.panel_barcode_second.BackColor = System.Drawing.Color.Red;
            this.panel_barcode_second.Controls.Add(this.btn_add_barcode);
            this.panel_barcode_second.Controls.Add(this.barcode_pb);
            this.panel_barcode_second.Controls.Add(this.cmb_video_out);
            this.panel_barcode_second.Controls.Add(this.txt_barcode_add);
            this.panel_barcode_second.Controls.Add(this.btn_barcode_back);
            this.panel_barcode_second.Location = new System.Drawing.Point(3, 3);
            this.panel_barcode_second.Name = "panel_barcode_second";
            this.panel_barcode_second.Size = new System.Drawing.Size(468, 397);
            this.panel_barcode_second.TabIndex = 0;
            // 
            // btn_add_barcode
            // 
            this.btn_add_barcode.ActiveControl = null;
            this.btn_add_barcode.Location = new System.Drawing.Point(22, 333);
            this.btn_add_barcode.Name = "btn_add_barcode";
            this.btn_add_barcode.Size = new System.Drawing.Size(176, 50);
            this.btn_add_barcode.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_add_barcode.TabIndex = 1;
            this.btn_add_barcode.Text = "ADD BARCODE";
            this.btn_add_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_barcode.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_barcode.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_add_barcode.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_add_barcode.UseSelectable = true;
            this.btn_add_barcode.Click += new System.EventHandler(this.btn_add_barcode_Click);
            // 
            // barcode_pb
            // 
            this.barcode_pb.BackColor = System.Drawing.Color.Gray;
            this.barcode_pb.Location = new System.Drawing.Point(22, 52);
            this.barcode_pb.Name = "barcode_pb";
            this.barcode_pb.Size = new System.Drawing.Size(425, 243);
            this.barcode_pb.TabIndex = 5;
            this.barcode_pb.TabStop = false;
            // 
            // cmb_video_out
            // 
            this.cmb_video_out.FormattingEnabled = true;
            this.cmb_video_out.ItemHeight = 23;
            this.cmb_video_out.Location = new System.Drawing.Point(22, 17);
            this.cmb_video_out.Name = "cmb_video_out";
            this.cmb_video_out.Size = new System.Drawing.Size(425, 29);
            this.cmb_video_out.TabIndex = 4;
            this.cmb_video_out.UseSelectable = true;
            // 
            // txt_barcode_add
            // 
            this.txt_barcode_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode_add.Location = new System.Drawing.Point(22, 301);
            this.txt_barcode_add.Name = "txt_barcode_add";
            this.txt_barcode_add.Size = new System.Drawing.Size(425, 26);
            this.txt_barcode_add.TabIndex = 2;
            // 
            // btn_barcode_back
            // 
            this.btn_barcode_back.ActiveControl = null;
            this.btn_barcode_back.Location = new System.Drawing.Point(271, 333);
            this.btn_barcode_back.Name = "btn_barcode_back";
            this.btn_barcode_back.Size = new System.Drawing.Size(176, 50);
            this.btn_barcode_back.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_barcode_back.TabIndex = 1;
            this.btn_barcode_back.Text = "CLOSE";
            this.btn_barcode_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_barcode_back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_barcode_back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_barcode_back.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_barcode_back.UseSelectable = true;
            this.btn_barcode_back.Click += new System.EventHandler(this.btn_barcode_back_Click);
            // 
            // Reg_loyalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.panel_barcode_first);
            this.Controls.Add(this.panel_register);
            this.Controls.Add(this.panel_loyalty_view);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_reg);
            this.Controls.Add(this.register_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reg_loyalty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reg_loyalty";
            this.Load += new System.EventHandler(this.Reg_loyalty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.register_pb)).EndInit();
            this.panel_loyalty_view.ResumeLayout(false);
            this.panel_loyalty_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomer_dataGrid)).EndInit();
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            this.panel_barcode_first.ResumeLayout(false);
            this.panel_barcode_second.ResumeLayout(false);
            this.panel_barcode_second.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox register_pb;
        private System.Windows.Forms.Label lbl_reg;
        private MetroFramework.Controls.MetroTile btn_register;
        private MetroFramework.Controls.MetroTile btn_view;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private JDragControl.JDragControl regster_control;
        private System.Windows.Forms.Panel panel_loyalty_view;
        private System.Windows.Forms.RadioButton rad_phone;
        private System.Windows.Forms.RadioButton rad_showAll;
        private System.Windows.Forms.TextBox txt_search_tel;
        private System.Windows.Forms.Label Customer_tel;
        private System.Windows.Forms.DataGridView viewCustomer_dataGrid;
        private MetroFramework.Controls.MetroTile btn_search;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.TextBox txt_loy_no;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.TextBox txt_name;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_add;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_loy_no;
        private System.Windows.Forms.Label lbl_cus_tele;
        private System.Windows.Forms.Label lbl_cu_NIC;
        private System.Windows.Forms.Label lbl_cus_name;
        private System.Windows.Forms.Label lbl_cus_id;
        private MetroFramework.Controls.MetroTile btn_scan;
        private System.Windows.Forms.Panel panel_barcode_first;
        private System.Windows.Forms.Panel panel_barcode_second;
        private MetroFramework.Controls.MetroTile btn_add_barcode;
        private System.Windows.Forms.PictureBox barcode_pb;
        private MetroFramework.Controls.MetroComboBox cmb_video_out;
        private System.Windows.Forms.TextBox txt_barcode_add;
        private MetroFramework.Controls.MetroTile btn_barcode_back;
    }
}