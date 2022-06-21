
namespace oneStore
{
    partial class sellItems
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
            this.sell_pb = new System.Windows.Forms.PictureBox();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.lbl_sell = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.sellItems_control = new JDragControl.JDragControl(this.components);
            this.billing_grid = new System.Windows.Forms.DataGridView();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_barcodeOrID = new System.Windows.Forms.TextBox();
            this.lbl_barCodeOrId = new System.Windows.Forms.Label();
            this.panel_adding = new System.Windows.Forms.Panel();
            this.panel_barcode_first = new System.Windows.Forms.Panel();
            this.panel_barcode_second = new System.Windows.Forms.Panel();
            this.btn_add_barcode = new MetroFramework.Controls.MetroTile();
            this.barcode_pb = new System.Windows.Forms.PictureBox();
            this.cmb_video_out = new MetroFramework.Controls.MetroComboBox();
            this.txt_barcode_add = new System.Windows.Forms.TextBox();
            this.btn_barcode_back = new MetroFramework.Controls.MetroTile();
            this.btn_add_details = new MetroFramework.Controls.MetroTile();
            this.txt_sub_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_quantiy = new System.Windows.Forms.Label();
            this.btn_scan = new MetroFramework.Controls.MetroTile();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_Payments = new MetroFramework.Controls.MetroTile();
            this.btn_adding = new MetroFramework.Controls.MetroTile();
            this.panel_bill = new System.Windows.Forms.Panel();
            this.panel_bill_bar1 = new System.Windows.Forms.Panel();
            this.panel_bill_bar_2 = new System.Windows.Forms.Panel();
            this.btn_bill_add_barcode = new MetroFramework.Controls.MetroTile();
            this.bill_barcode_pb = new System.Windows.Forms.PictureBox();
            this.cmb_bill_brcode = new MetroFramework.Controls.MetroComboBox();
            this.txt_bill_barCode = new System.Windows.Forms.TextBox();
            this.btn__barcode2_back = new MetroFramework.Controls.MetroTile();
            this.txt_loyalty_no = new System.Windows.Forms.TextBox();
            this.rad_no_need = new System.Windows.Forms.RadioButton();
            this.rad_have = new System.Windows.Forms.RadioButton();
            this.txt_return_amount = new System.Windows.Forms.TextBox();
            this.txt_paid_amount = new System.Windows.Forms.TextBox();
            this.txt_bill_sub = new System.Windows.Forms.TextBox();
            this.lbl_return_amount = new System.Windows.Forms.Label();
            this.btn_clear_bill = new MetroFramework.Controls.MetroTile();
            this.btn_scan_loyalty = new MetroFramework.Controls.MetroTile();
            this.btn_pay = new MetroFramework.Controls.MetroTile();
            this.lbl_paid_amount = new System.Windows.Forms.Label();
            this.lbl_LoyaltyTeleNo = new System.Windows.Forms.Label();
            this.lbl_loyalty = new System.Windows.Forms.Label();
            this.lbl_sub_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sell_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_grid)).BeginInit();
            this.panel_adding.SuspendLayout();
            this.panel_barcode_first.SuspendLayout();
            this.panel_barcode_second.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_pb)).BeginInit();
            this.panel_bill.SuspendLayout();
            this.panel_bill_bar1.SuspendLayout();
            this.panel_bill_bar_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_barcode_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // sell_pb
            // 
            this.sell_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sell_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.sell_pb.Location = new System.Drawing.Point(0, 0);
            this.sell_pb.Name = "sell_pb";
            this.sell_pb.Size = new System.Drawing.Size(923, 552);
            this.sell_pb.TabIndex = 0;
            this.sell_pb.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.ActiveControl = null;
            this.btn_back.Location = new System.Drawing.Point(25, 451);
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
            // lbl_sell
            // 
            this.lbl_sell.AutoSize = true;
            this.lbl_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sell.Location = new System.Drawing.Point(235, 14);
            this.lbl_sell.Name = "lbl_sell";
            this.lbl_sell.Size = new System.Drawing.Size(165, 37);
            this.lbl_sell.TabIndex = 2;
            this.lbl_sell.Text = "Sell Items";
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
            // sellItems_control
            // 
            this.sellItems_control.GetForm = this;
            this.sellItems_control.TargetControl = this.sell_pb;
            // 
            // billing_grid
            // 
            this.billing_grid.AllowUserToAddRows = false;
            this.billing_grid.AllowUserToDeleteRows = false;
            this.billing_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billing_grid.Location = new System.Drawing.Point(8, 13);
            this.billing_grid.Name = "billing_grid";
            this.billing_grid.ReadOnly = true;
            this.billing_grid.Size = new System.Drawing.Size(669, 206);
            this.billing_grid.TabIndex = 4;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(278, 238);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(179, 31);
            this.txt_Quantity.TabIndex = 5;
            // 
            // txt_barcodeOrID
            // 
            this.txt_barcodeOrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcodeOrID.Location = new System.Drawing.Point(51, 238);
            this.txt_barcodeOrID.Name = "txt_barcodeOrID";
            this.txt_barcodeOrID.Size = new System.Drawing.Size(187, 31);
            this.txt_barcodeOrID.TabIndex = 5;
            // 
            // lbl_barCodeOrId
            // 
            this.lbl_barCodeOrId.AutoSize = true;
            this.lbl_barCodeOrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barCodeOrId.Location = new System.Drawing.Point(38, 279);
            this.lbl_barCodeOrId.Name = "lbl_barCodeOrId";
            this.lbl_barCodeOrId.Size = new System.Drawing.Size(216, 24);
            this.lbl_barCodeOrId.TabIndex = 6;
            this.lbl_barCodeOrId.Text = "Product ID or Barcode";
            // 
            // panel_adding
            // 
            this.panel_adding.BackColor = System.Drawing.Color.Red;
            this.panel_adding.Controls.Add(this.panel_barcode_first);
            this.panel_adding.Controls.Add(this.btn_add_details);
            this.panel_adding.Controls.Add(this.billing_grid);
            this.panel_adding.Controls.Add(this.txt_sub_total);
            this.panel_adding.Controls.Add(this.lbl_total);
            this.panel_adding.Controls.Add(this.lbl_quantiy);
            this.panel_adding.Controls.Add(this.btn_scan);
            this.panel_adding.Controls.Add(this.btn_clear);
            this.panel_adding.Controls.Add(this.lbl_barCodeOrId);
            this.panel_adding.Controls.Add(this.txt_Quantity);
            this.panel_adding.Controls.Add(this.txt_barcodeOrID);
            this.panel_adding.Location = new System.Drawing.Point(235, 72);
            this.panel_adding.Name = "panel_adding";
            this.panel_adding.Size = new System.Drawing.Size(680, 468);
            this.panel_adding.TabIndex = 7;
            // 
            // panel_barcode_first
            // 
            this.panel_barcode_first.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_barcode_first.Controls.Add(this.panel_barcode_second);
            this.panel_barcode_first.Location = new System.Drawing.Point(48, 20);
            this.panel_barcode_first.Name = "panel_barcode_first";
            this.panel_barcode_first.Size = new System.Drawing.Size(474, 404);
            this.panel_barcode_first.TabIndex = 9;
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
            // btn_add_details
            // 
            this.btn_add_details.ActiveControl = null;
            this.btn_add_details.Location = new System.Drawing.Point(169, 385);
            this.btn_add_details.Name = "btn_add_details";
            this.btn_add_details.Size = new System.Drawing.Size(160, 50);
            this.btn_add_details.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_add_details.TabIndex = 1;
            this.btn_add_details.Text = "ADD";
            this.btn_add_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_details.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_add_details.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_add_details.UseSelectable = true;
            this.btn_add_details.Click += new System.EventHandler(this.btn_add_details_Click);
            // 
            // txt_sub_total
            // 
            this.txt_sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_total.Location = new System.Drawing.Point(500, 238);
            this.txt_sub_total.Name = "txt_sub_total";
            this.txt_sub_total.Size = new System.Drawing.Size(176, 31);
            this.txt_sub_total.TabIndex = 8;
            this.txt_sub_total.Text = "0";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(533, 279);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(91, 24);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Sub total";
            // 
            // lbl_quantiy
            // 
            this.lbl_quantiy.AutoSize = true;
            this.lbl_quantiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantiy.Location = new System.Drawing.Point(314, 279);
            this.lbl_quantiy.Name = "lbl_quantiy";
            this.lbl_quantiy.Size = new System.Drawing.Size(86, 24);
            this.lbl_quantiy.TabIndex = 6;
            this.lbl_quantiy.Text = "Quantity";
            // 
            // btn_scan
            // 
            this.btn_scan.ActiveControl = null;
            this.btn_scan.Location = new System.Drawing.Point(93, 306);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(111, 47);
            this.btn_scan.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_scan.TabIndex = 1;
            this.btn_scan.Text = "SCAN";
            this.btn_scan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_scan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_scan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_scan.UseSelectable = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(393, 385);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(160, 50);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_clear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Payments
            // 
            this.btn_Payments.ActiveControl = null;
            this.btn_Payments.Location = new System.Drawing.Point(12, 167);
            this.btn_Payments.Name = "btn_Payments";
            this.btn_Payments.Size = new System.Drawing.Size(203, 50);
            this.btn_Payments.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_Payments.TabIndex = 1;
            this.btn_Payments.Text = "Payments";
            this.btn_Payments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Payments.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Payments.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_Payments.UseSelectable = true;
            this.btn_Payments.Click += new System.EventHandler(this.btn_blilling_Click);
            // 
            // btn_adding
            // 
            this.btn_adding.ActiveControl = null;
            this.btn_adding.Location = new System.Drawing.Point(12, 112);
            this.btn_adding.Name = "btn_adding";
            this.btn_adding.Size = new System.Drawing.Size(203, 50);
            this.btn_adding.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_adding.TabIndex = 1;
            this.btn_adding.Text = "Place the Bill";
            this.btn_adding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_adding.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_adding.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_adding.UseSelectable = true;
            this.btn_adding.Click += new System.EventHandler(this.btn_adding_Click);
            // 
            // panel_bill
            // 
            this.panel_bill.BackColor = System.Drawing.Color.Red;
            this.panel_bill.Controls.Add(this.panel_bill_bar1);
            this.panel_bill.Controls.Add(this.txt_loyalty_no);
            this.panel_bill.Controls.Add(this.rad_no_need);
            this.panel_bill.Controls.Add(this.rad_have);
            this.panel_bill.Controls.Add(this.txt_return_amount);
            this.panel_bill.Controls.Add(this.txt_paid_amount);
            this.panel_bill.Controls.Add(this.txt_bill_sub);
            this.panel_bill.Controls.Add(this.lbl_return_amount);
            this.panel_bill.Controls.Add(this.btn_clear_bill);
            this.panel_bill.Controls.Add(this.btn_scan_loyalty);
            this.panel_bill.Controls.Add(this.btn_pay);
            this.panel_bill.Controls.Add(this.lbl_paid_amount);
            this.panel_bill.Controls.Add(this.lbl_LoyaltyTeleNo);
            this.panel_bill.Controls.Add(this.lbl_loyalty);
            this.panel_bill.Controls.Add(this.lbl_sub_total);
            this.panel_bill.Location = new System.Drawing.Point(235, 72);
            this.panel_bill.Name = "panel_bill";
            this.panel_bill.Size = new System.Drawing.Size(680, 468);
            this.panel_bill.TabIndex = 8;
            // 
            // panel_bill_bar1
            // 
            this.panel_bill_bar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_bill_bar1.Controls.Add(this.panel_bill_bar_2);
            this.panel_bill_bar1.Location = new System.Drawing.Point(48, 20);
            this.panel_bill_bar1.Name = "panel_bill_bar1";
            this.panel_bill_bar1.Size = new System.Drawing.Size(474, 404);
            this.panel_bill_bar1.TabIndex = 10;
            // 
            // panel_bill_bar_2
            // 
            this.panel_bill_bar_2.BackColor = System.Drawing.Color.Red;
            this.panel_bill_bar_2.Controls.Add(this.btn_bill_add_barcode);
            this.panel_bill_bar_2.Controls.Add(this.bill_barcode_pb);
            this.panel_bill_bar_2.Controls.Add(this.cmb_bill_brcode);
            this.panel_bill_bar_2.Controls.Add(this.txt_bill_barCode);
            this.panel_bill_bar_2.Controls.Add(this.btn__barcode2_back);
            this.panel_bill_bar_2.Location = new System.Drawing.Point(3, 3);
            this.panel_bill_bar_2.Name = "panel_bill_bar_2";
            this.panel_bill_bar_2.Size = new System.Drawing.Size(468, 397);
            this.panel_bill_bar_2.TabIndex = 0;
            // 
            // btn_bill_add_barcode
            // 
            this.btn_bill_add_barcode.ActiveControl = null;
            this.btn_bill_add_barcode.Location = new System.Drawing.Point(22, 333);
            this.btn_bill_add_barcode.Name = "btn_bill_add_barcode";
            this.btn_bill_add_barcode.Size = new System.Drawing.Size(176, 50);
            this.btn_bill_add_barcode.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_bill_add_barcode.TabIndex = 1;
            this.btn_bill_add_barcode.Text = "ADD BARCODE";
            this.btn_bill_add_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bill_add_barcode.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bill_add_barcode.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_bill_add_barcode.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_bill_add_barcode.UseSelectable = true;
            this.btn_bill_add_barcode.Click += new System.EventHandler(this.btn_bill_add_barcode_Click);
            // 
            // bill_barcode_pb
            // 
            this.bill_barcode_pb.BackColor = System.Drawing.Color.Gray;
            this.bill_barcode_pb.Location = new System.Drawing.Point(22, 52);
            this.bill_barcode_pb.Name = "bill_barcode_pb";
            this.bill_barcode_pb.Size = new System.Drawing.Size(425, 243);
            this.bill_barcode_pb.TabIndex = 5;
            this.bill_barcode_pb.TabStop = false;
            // 
            // cmb_bill_brcode
            // 
            this.cmb_bill_brcode.FormattingEnabled = true;
            this.cmb_bill_brcode.ItemHeight = 23;
            this.cmb_bill_brcode.Location = new System.Drawing.Point(22, 17);
            this.cmb_bill_brcode.Name = "cmb_bill_brcode";
            this.cmb_bill_brcode.Size = new System.Drawing.Size(425, 29);
            this.cmb_bill_brcode.TabIndex = 4;
            this.cmb_bill_brcode.UseSelectable = true;
            // 
            // txt_bill_barCode
            // 
            this.txt_bill_barCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill_barCode.Location = new System.Drawing.Point(22, 301);
            this.txt_bill_barCode.Name = "txt_bill_barCode";
            this.txt_bill_barCode.Size = new System.Drawing.Size(425, 26);
            this.txt_bill_barCode.TabIndex = 2;
            // 
            // btn__barcode2_back
            // 
            this.btn__barcode2_back.ActiveControl = null;
            this.btn__barcode2_back.Location = new System.Drawing.Point(271, 333);
            this.btn__barcode2_back.Name = "btn__barcode2_back";
            this.btn__barcode2_back.Size = new System.Drawing.Size(176, 50);
            this.btn__barcode2_back.Style = MetroFramework.MetroColorStyle.Black;
            this.btn__barcode2_back.TabIndex = 1;
            this.btn__barcode2_back.Text = "CLOSE";
            this.btn__barcode2_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn__barcode2_back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn__barcode2_back.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn__barcode2_back.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn__barcode2_back.UseSelectable = true;
            this.btn__barcode2_back.Click += new System.EventHandler(this.btn__barcode2_back_Click);
            // 
            // txt_loyalty_no
            // 
            this.txt_loyalty_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loyalty_no.Location = new System.Drawing.Point(232, 144);
            this.txt_loyalty_no.Name = "txt_loyalty_no";
            this.txt_loyalty_no.Size = new System.Drawing.Size(261, 31);
            this.txt_loyalty_no.TabIndex = 4;
            // 
            // rad_no_need
            // 
            this.rad_no_need.AutoSize = true;
            this.rad_no_need.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_no_need.Location = new System.Drawing.Point(425, 97);
            this.rad_no_need.Name = "rad_no_need";
            this.rad_no_need.Size = new System.Drawing.Size(94, 24);
            this.rad_no_need.TabIndex = 3;
            this.rad_no_need.TabStop = true;
            this.rad_no_need.Text = "No need";
            this.rad_no_need.UseVisualStyleBackColor = true;
            this.rad_no_need.CheckedChanged += new System.EventHandler(this.rad_no_need_CheckedChanged);
            // 
            // rad_have
            // 
            this.rad_have.AutoSize = true;
            this.rad_have.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_have.Location = new System.Drawing.Point(231, 97);
            this.rad_have.Name = "rad_have";
            this.rad_have.Size = new System.Drawing.Size(163, 24);
            this.rad_have.TabIndex = 3;
            this.rad_have.TabStop = true;
            this.rad_have.Text = "Have loyalty card";
            this.rad_have.UseVisualStyleBackColor = true;
            this.rad_have.CheckedChanged += new System.EventHandler(this.rad_have_CheckedChanged);
            // 
            // txt_return_amount
            // 
            this.txt_return_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_return_amount.Location = new System.Drawing.Point(232, 272);
            this.txt_return_amount.Name = "txt_return_amount";
            this.txt_return_amount.Size = new System.Drawing.Size(398, 31);
            this.txt_return_amount.TabIndex = 2;
            // 
            // txt_paid_amount
            // 
            this.txt_paid_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paid_amount.Location = new System.Drawing.Point(232, 210);
            this.txt_paid_amount.Name = "txt_paid_amount";
            this.txt_paid_amount.Size = new System.Drawing.Size(398, 31);
            this.txt_paid_amount.TabIndex = 2;
            // 
            // txt_bill_sub
            // 
            this.txt_bill_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill_sub.Location = new System.Drawing.Point(232, 40);
            this.txt_bill_sub.Name = "txt_bill_sub";
            this.txt_bill_sub.Size = new System.Drawing.Size(398, 31);
            this.txt_bill_sub.TabIndex = 2;
            // 
            // lbl_return_amount
            // 
            this.lbl_return_amount.AutoSize = true;
            this.lbl_return_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_return_amount.Location = new System.Drawing.Point(37, 279);
            this.lbl_return_amount.Name = "lbl_return_amount";
            this.lbl_return_amount.Size = new System.Drawing.Size(168, 25);
            this.lbl_return_amount.TabIndex = 0;
            this.lbl_return_amount.Text = "Return Amount";
            // 
            // btn_clear_bill
            // 
            this.btn_clear_bill.ActiveControl = null;
            this.btn_clear_bill.Location = new System.Drawing.Point(393, 359);
            this.btn_clear_bill.Name = "btn_clear_bill";
            this.btn_clear_bill.Size = new System.Drawing.Size(176, 50);
            this.btn_clear_bill.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_clear_bill.TabIndex = 1;
            this.btn_clear_bill.Text = "CLEAR";
            this.btn_clear_bill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear_bill.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_clear_bill.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_clear_bill.UseSelectable = true;
            this.btn_clear_bill.Click += new System.EventHandler(this.btn_clear_bill_Click);
            // 
            // btn_scan_loyalty
            // 
            this.btn_scan_loyalty.ActiveControl = null;
            this.btn_scan_loyalty.Location = new System.Drawing.Point(500, 135);
            this.btn_scan_loyalty.Name = "btn_scan_loyalty";
            this.btn_scan_loyalty.Size = new System.Drawing.Size(130, 50);
            this.btn_scan_loyalty.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_scan_loyalty.TabIndex = 1;
            this.btn_scan_loyalty.Text = "SCAN";
            this.btn_scan_loyalty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_scan_loyalty.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_scan_loyalty.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_scan_loyalty.UseSelectable = true;
            this.btn_scan_loyalty.Click += new System.EventHandler(this.btn_scan_loyalty_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.ActiveControl = null;
            this.btn_pay.Location = new System.Drawing.Point(134, 359);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(176, 50);
            this.btn_pay.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "PAY";
            this.btn_pay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_pay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_pay.UseSelectable = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // lbl_paid_amount
            // 
            this.lbl_paid_amount.AutoSize = true;
            this.lbl_paid_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paid_amount.Location = new System.Drawing.Point(37, 210);
            this.lbl_paid_amount.Name = "lbl_paid_amount";
            this.lbl_paid_amount.Size = new System.Drawing.Size(145, 25);
            this.lbl_paid_amount.TabIndex = 0;
            this.lbl_paid_amount.Text = "Paid Amount";
            // 
            // lbl_LoyaltyTeleNo
            // 
            this.lbl_LoyaltyTeleNo.AutoSize = true;
            this.lbl_LoyaltyTeleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoyaltyTeleNo.Location = new System.Drawing.Point(37, 147);
            this.lbl_LoyaltyTeleNo.Name = "lbl_LoyaltyTeleNo";
            this.lbl_LoyaltyTeleNo.Size = new System.Drawing.Size(185, 25);
            this.lbl_LoyaltyTeleNo.TabIndex = 0;
            this.lbl_LoyaltyTeleNo.Text = "Loyalty / Tel No ";
            // 
            // lbl_loyalty
            // 
            this.lbl_loyalty.AutoSize = true;
            this.lbl_loyalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loyalty.Location = new System.Drawing.Point(37, 95);
            this.lbl_loyalty.Name = "lbl_loyalty";
            this.lbl_loyalty.Size = new System.Drawing.Size(145, 25);
            this.lbl_loyalty.TabIndex = 0;
            this.lbl_loyalty.Text = "Loyalty Card";
            // 
            // lbl_sub_total
            // 
            this.lbl_sub_total.AutoSize = true;
            this.lbl_sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub_total.Location = new System.Drawing.Point(37, 40);
            this.lbl_sub_total.Name = "lbl_sub_total";
            this.lbl_sub_total.Size = new System.Drawing.Size(113, 25);
            this.lbl_sub_total.TabIndex = 0;
            this.lbl_sub_total.Text = "Sub Total";
            // 
            // sellItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.panel_bill);
            this.Controls.Add(this.panel_adding);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_adding);
            this.Controls.Add(this.btn_Payments);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.lbl_sell);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.sell_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sellItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellItems";
            this.Load += new System.EventHandler(this.sellItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sell_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billing_grid)).EndInit();
            this.panel_adding.ResumeLayout(false);
            this.panel_adding.PerformLayout();
            this.panel_barcode_first.ResumeLayout(false);
            this.panel_barcode_second.ResumeLayout(false);
            this.panel_barcode_second.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_pb)).EndInit();
            this.panel_bill.ResumeLayout(false);
            this.panel_bill.PerformLayout();
            this.panel_bill_bar1.ResumeLayout(false);
            this.panel_bill_bar_2.ResumeLayout(false);
            this.panel_bill_bar_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_barcode_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sell_pb;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Label lbl_sell;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private JDragControl.JDragControl sellItems_control;
        private System.Windows.Forms.Panel panel_adding;
        private System.Windows.Forms.DataGridView billing_grid;
        private System.Windows.Forms.Label lbl_barCodeOrId;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_barcodeOrID;
        private System.Windows.Forms.Label lbl_quantiy;
        private MetroFramework.Controls.MetroTile btn_clear;
        private MetroFramework.Controls.MetroTile btn_add_details;
        private System.Windows.Forms.TextBox txt_sub_total;
        private MetroFramework.Controls.MetroTile btn_Payments;
        private MetroFramework.Controls.MetroTile btn_adding;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel panel_barcode_first;
        private System.Windows.Forms.Panel panel_barcode_second;
        private MetroFramework.Controls.MetroTile btn_add_barcode;
        private System.Windows.Forms.PictureBox barcode_pb;
        private MetroFramework.Controls.MetroComboBox cmb_video_out;
        private System.Windows.Forms.TextBox txt_barcode_add;
        private MetroFramework.Controls.MetroTile btn_barcode_back;
        private MetroFramework.Controls.MetroTile btn_scan;
        private System.Windows.Forms.Panel panel_bill;
        private System.Windows.Forms.TextBox txt_loyalty_no;
        private System.Windows.Forms.RadioButton rad_no_need;
        private System.Windows.Forms.RadioButton rad_have;
        private System.Windows.Forms.TextBox txt_return_amount;
        private System.Windows.Forms.TextBox txt_paid_amount;
        private System.Windows.Forms.TextBox txt_bill_sub;
        private System.Windows.Forms.Label lbl_return_amount;
        private MetroFramework.Controls.MetroTile btn_clear_bill;
        private MetroFramework.Controls.MetroTile btn_scan_loyalty;
        private MetroFramework.Controls.MetroTile btn_pay;
        private System.Windows.Forms.Label lbl_paid_amount;
        private System.Windows.Forms.Label lbl_LoyaltyTeleNo;
        private System.Windows.Forms.Label lbl_loyalty;
        private System.Windows.Forms.Label lbl_sub_total;
        private System.Windows.Forms.Panel panel_bill_bar1;
        private System.Windows.Forms.Panel panel_bill_bar_2;
        private MetroFramework.Controls.MetroTile btn_bill_add_barcode;
        private System.Windows.Forms.PictureBox bill_barcode_pb;
        private MetroFramework.Controls.MetroComboBox cmb_bill_brcode;
        private System.Windows.Forms.TextBox txt_bill_barCode;
        private MetroFramework.Controls.MetroTile btn__barcode2_back;
    }
}