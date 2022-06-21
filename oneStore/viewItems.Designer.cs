
namespace oneStore
{
    partial class viewItems
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
            this.view_pb = new System.Windows.Forms.PictureBox();
            this.lbl_view = new System.Windows.Forms.Label();
            this.btn_men = new MetroFramework.Controls.MetroTile();
            this.btn_women = new MetroFramework.Controls.MetroTile();
            this.btn_shoes = new MetroFramework.Controls.MetroTile();
            this.btn_wearbles = new MetroFramework.Controls.MetroTile();
            this.btn_perfumes = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.view_control = new JDragControl.JDragControl(this.components);
            this.panel_perfumes = new System.Windows.Forms.Panel();
            this.perfume_datagrid = new System.Windows.Forms.DataGridView();
            this.lbl_perfume = new System.Windows.Forms.Label();
            this.cmb_perfume = new MetroFramework.Controls.MetroComboBox();
            this.btn_sort_perfume = new MetroFramework.Controls.MetroTile();
            this.panel_werable = new System.Windows.Forms.Panel();
            this.cmb_wearable_brand = new MetroFramework.Controls.MetroComboBox();
            this.lbl_wearable = new System.Windows.Forms.Label();
            this.wearable_datagrid = new System.Windows.Forms.DataGridView();
            this.btn_sort_werable = new MetroFramework.Controls.MetroTile();
            this.panel_shoes = new System.Windows.Forms.Panel();
            this.cmb_shoes = new MetroFramework.Controls.MetroComboBox();
            this.lbl_shoes = new System.Windows.Forms.Label();
            this.Shoes_dataGrid = new System.Windows.Forms.DataGridView();
            this.btn_sort_shoes = new MetroFramework.Controls.MetroTile();
            this.panel_women = new System.Windows.Forms.Panel();
            this.cmb_women = new MetroFramework.Controls.MetroComboBox();
            this.lbl_women = new System.Windows.Forms.Label();
            this.women_datagrid = new System.Windows.Forms.DataGridView();
            this.btn_sort_women = new MetroFramework.Controls.MetroTile();
            this.panel_men = new System.Windows.Forms.Panel();
            this.cmb_men = new MetroFramework.Controls.MetroComboBox();
            this.label_men = new System.Windows.Forms.Label();
            this.men_datagrid = new System.Windows.Forms.DataGridView();
            this.btn_sort_men = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.view_pb)).BeginInit();
            this.panel_perfumes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_datagrid)).BeginInit();
            this.panel_werable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wearable_datagrid)).BeginInit();
            this.panel_shoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shoes_dataGrid)).BeginInit();
            this.panel_women.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.women_datagrid)).BeginInit();
            this.panel_men.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.men_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // view_pb
            // 
            this.view_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.view_pb.Location = new System.Drawing.Point(0, 0);
            this.view_pb.Name = "view_pb";
            this.view_pb.Size = new System.Drawing.Size(923, 552);
            this.view_pb.TabIndex = 0;
            this.view_pb.TabStop = false;
            // 
            // lbl_view
            // 
            this.lbl_view.AutoSize = true;
            this.lbl_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view.Location = new System.Drawing.Point(235, 14);
            this.lbl_view.Name = "lbl_view";
            this.lbl_view.Size = new System.Drawing.Size(182, 37);
            this.lbl_view.TabIndex = 1;
            this.lbl_view.Text = "View Items";
            // 
            // btn_men
            // 
            this.btn_men.ActiveControl = null;
            this.btn_men.Location = new System.Drawing.Point(12, 72);
            this.btn_men.Name = "btn_men";
            this.btn_men.Size = new System.Drawing.Size(203, 50);
            this.btn_men.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_men.TabIndex = 2;
            this.btn_men.Text = "Men";
            this.btn_men.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_men.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_men.UseSelectable = true;
            this.btn_men.Click += new System.EventHandler(this.btn_men_Click);
            // 
            // btn_women
            // 
            this.btn_women.ActiveControl = null;
            this.btn_women.Location = new System.Drawing.Point(12, 128);
            this.btn_women.Name = "btn_women";
            this.btn_women.Size = new System.Drawing.Size(203, 50);
            this.btn_women.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_women.TabIndex = 2;
            this.btn_women.Text = "Women";
            this.btn_women.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_women.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_women.UseSelectable = true;
            this.btn_women.Click += new System.EventHandler(this.btn_women_Click);
            // 
            // btn_shoes
            // 
            this.btn_shoes.ActiveControl = null;
            this.btn_shoes.Location = new System.Drawing.Point(12, 184);
            this.btn_shoes.Name = "btn_shoes";
            this.btn_shoes.Size = new System.Drawing.Size(203, 50);
            this.btn_shoes.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_shoes.TabIndex = 2;
            this.btn_shoes.Text = "Shoes";
            this.btn_shoes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_shoes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_shoes.UseSelectable = true;
            this.btn_shoes.Click += new System.EventHandler(this.btn_shoes_Click);
            // 
            // btn_wearbles
            // 
            this.btn_wearbles.ActiveControl = null;
            this.btn_wearbles.Location = new System.Drawing.Point(12, 240);
            this.btn_wearbles.Name = "btn_wearbles";
            this.btn_wearbles.Size = new System.Drawing.Size(203, 50);
            this.btn_wearbles.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_wearbles.TabIndex = 2;
            this.btn_wearbles.Text = "Wearables";
            this.btn_wearbles.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_wearbles.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_wearbles.UseSelectable = true;
            this.btn_wearbles.Click += new System.EventHandler(this.btn_wearbles_Click);
            // 
            // btn_perfumes
            // 
            this.btn_perfumes.ActiveControl = null;
            this.btn_perfumes.Location = new System.Drawing.Point(12, 296);
            this.btn_perfumes.Name = "btn_perfumes";
            this.btn_perfumes.Size = new System.Drawing.Size(203, 50);
            this.btn_perfumes.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_perfumes.TabIndex = 2;
            this.btn_perfumes.Text = "Perfumes";
            this.btn_perfumes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_perfumes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_perfumes.UseSelectable = true;
            this.btn_perfumes.Click += new System.EventHandler(this.btn_perfumes_Click);
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
            // view_control
            // 
            this.view_control.GetForm = this;
            this.view_control.TargetControl = this.view_pb;
            // 
            // panel_perfumes
            // 
            this.panel_perfumes.BackColor = System.Drawing.Color.Red;
            this.panel_perfumes.Controls.Add(this.cmb_perfume);
            this.panel_perfumes.Controls.Add(this.lbl_perfume);
            this.panel_perfumes.Controls.Add(this.perfume_datagrid);
            this.panel_perfumes.Controls.Add(this.btn_sort_perfume);
            this.panel_perfumes.Location = new System.Drawing.Point(235, 72);
            this.panel_perfumes.Name = "panel_perfumes";
            this.panel_perfumes.Size = new System.Drawing.Size(680, 468);
            this.panel_perfumes.TabIndex = 4;
            // 
            // perfume_datagrid
            // 
            this.perfume_datagrid.AllowUserToAddRows = false;
            this.perfume_datagrid.AllowUserToDeleteRows = false;
            this.perfume_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perfume_datagrid.Location = new System.Drawing.Point(3, 72);
            this.perfume_datagrid.Name = "perfume_datagrid";
            this.perfume_datagrid.ReadOnly = true;
            this.perfume_datagrid.Size = new System.Drawing.Size(673, 393);
            this.perfume_datagrid.TabIndex = 0;
            this.perfume_datagrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.perfume_datagrid_DataError);
            // 
            // lbl_perfume
            // 
            this.lbl_perfume.AutoSize = true;
            this.lbl_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfume.Location = new System.Drawing.Point(93, 23);
            this.lbl_perfume.Name = "lbl_perfume";
            this.lbl_perfume.Size = new System.Drawing.Size(74, 25);
            this.lbl_perfume.TabIndex = 1;
            this.lbl_perfume.Text = "Brand";
            // 
            // cmb_perfume
            // 
            this.cmb_perfume.FormattingEnabled = true;
            this.cmb_perfume.ItemHeight = 23;
            this.cmb_perfume.Items.AddRange(new object[] {
            "Addidas",
            "Armani",
            "Calvin Klein",
            "Casio",
            "Chanel",
            "Dior",
            "Hublot",
            "Levis",
            "Mugler",
            "Nike",
            "Omega",
            "Polo",
            "Reebok",
            "Rolex",
            "Tag"});
            this.cmb_perfume.Location = new System.Drawing.Point(188, 19);
            this.cmb_perfume.Name = "cmb_perfume";
            this.cmb_perfume.Size = new System.Drawing.Size(272, 29);
            this.cmb_perfume.TabIndex = 2;
            this.cmb_perfume.UseSelectable = true;
            // 
            // btn_sort_perfume
            // 
            this.btn_sort_perfume.ActiveControl = null;
            this.btn_sort_perfume.Location = new System.Drawing.Point(487, 13);
            this.btn_sort_perfume.Name = "btn_sort_perfume";
            this.btn_sort_perfume.Size = new System.Drawing.Size(171, 42);
            this.btn_sort_perfume.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sort_perfume.TabIndex = 2;
            this.btn_sort_perfume.Text = "SORT PERFUMES";
            this.btn_sort_perfume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sort_perfume.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sort_perfume.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sort_perfume.UseSelectable = true;
            this.btn_sort_perfume.Click += new System.EventHandler(this.btn_sort_perfume_Click);
            // 
            // panel_werable
            // 
            this.panel_werable.BackColor = System.Drawing.Color.Red;
            this.panel_werable.Controls.Add(this.cmb_wearable_brand);
            this.panel_werable.Controls.Add(this.lbl_wearable);
            this.panel_werable.Controls.Add(this.wearable_datagrid);
            this.panel_werable.Controls.Add(this.btn_sort_werable);
            this.panel_werable.Location = new System.Drawing.Point(235, 72);
            this.panel_werable.Name = "panel_werable";
            this.panel_werable.Size = new System.Drawing.Size(680, 468);
            this.panel_werable.TabIndex = 5;
            // 
            // cmb_wearable_brand
            // 
            this.cmb_wearable_brand.FormattingEnabled = true;
            this.cmb_wearable_brand.ItemHeight = 23;
            this.cmb_wearable_brand.Items.AddRange(new object[] {
            "Addidas",
            "Armani",
            "Calvin Klein",
            "Casio",
            "Chanel",
            "Dior",
            "Hublot",
            "Levis",
            "Mugler",
            "Nike",
            "Omega",
            "Polo",
            "Reebok",
            "Rolex",
            "Tag"});
            this.cmb_wearable_brand.Location = new System.Drawing.Point(188, 19);
            this.cmb_wearable_brand.Name = "cmb_wearable_brand";
            this.cmb_wearable_brand.Size = new System.Drawing.Size(272, 29);
            this.cmb_wearable_brand.TabIndex = 2;
            this.cmb_wearable_brand.UseSelectable = true;
            // 
            // lbl_wearable
            // 
            this.lbl_wearable.AutoSize = true;
            this.lbl_wearable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wearable.Location = new System.Drawing.Point(93, 23);
            this.lbl_wearable.Name = "lbl_wearable";
            this.lbl_wearable.Size = new System.Drawing.Size(74, 25);
            this.lbl_wearable.TabIndex = 1;
            this.lbl_wearable.Text = "Brand";
            // 
            // wearable_datagrid
            // 
            this.wearable_datagrid.AllowUserToAddRows = false;
            this.wearable_datagrid.AllowUserToDeleteRows = false;
            this.wearable_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wearable_datagrid.Location = new System.Drawing.Point(3, 72);
            this.wearable_datagrid.Name = "wearable_datagrid";
            this.wearable_datagrid.ReadOnly = true;
            this.wearable_datagrid.Size = new System.Drawing.Size(673, 393);
            this.wearable_datagrid.TabIndex = 0;
            this.wearable_datagrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.wearable_datagrid_DataError);
            // 
            // btn_sort_werable
            // 
            this.btn_sort_werable.ActiveControl = null;
            this.btn_sort_werable.Location = new System.Drawing.Point(487, 13);
            this.btn_sort_werable.Name = "btn_sort_werable";
            this.btn_sort_werable.Size = new System.Drawing.Size(171, 42);
            this.btn_sort_werable.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sort_werable.TabIndex = 2;
            this.btn_sort_werable.Text = "SORT WEARABLES";
            this.btn_sort_werable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sort_werable.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sort_werable.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sort_werable.UseSelectable = true;
            this.btn_sort_werable.Click += new System.EventHandler(this.btn_sort_werable_Click);
            // 
            // panel_shoes
            // 
            this.panel_shoes.BackColor = System.Drawing.Color.Red;
            this.panel_shoes.Controls.Add(this.cmb_shoes);
            this.panel_shoes.Controls.Add(this.lbl_shoes);
            this.panel_shoes.Controls.Add(this.Shoes_dataGrid);
            this.panel_shoes.Controls.Add(this.btn_sort_shoes);
            this.panel_shoes.Location = new System.Drawing.Point(235, 72);
            this.panel_shoes.Name = "panel_shoes";
            this.panel_shoes.Size = new System.Drawing.Size(680, 468);
            this.panel_shoes.TabIndex = 6;
            // 
            // cmb_shoes
            // 
            this.cmb_shoes.FormattingEnabled = true;
            this.cmb_shoes.ItemHeight = 23;
            this.cmb_shoes.Items.AddRange(new object[] {
            "Addidas",
            "Armani",
            "Calvin Klein",
            "Casio",
            "Chanel",
            "Dior",
            "Hublot",
            "Levis",
            "Mugler",
            "Nike",
            "Omega",
            "Polo",
            "Reebok",
            "Rolex",
            "Tag"});
            this.cmb_shoes.Location = new System.Drawing.Point(188, 19);
            this.cmb_shoes.Name = "cmb_shoes";
            this.cmb_shoes.Size = new System.Drawing.Size(272, 29);
            this.cmb_shoes.TabIndex = 2;
            this.cmb_shoes.UseSelectable = true;
            // 
            // lbl_shoes
            // 
            this.lbl_shoes.AutoSize = true;
            this.lbl_shoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shoes.Location = new System.Drawing.Point(93, 23);
            this.lbl_shoes.Name = "lbl_shoes";
            this.lbl_shoes.Size = new System.Drawing.Size(74, 25);
            this.lbl_shoes.TabIndex = 1;
            this.lbl_shoes.Text = "Brand";
            // 
            // Shoes_dataGrid
            // 
            this.Shoes_dataGrid.AllowUserToAddRows = false;
            this.Shoes_dataGrid.AllowUserToDeleteRows = false;
            this.Shoes_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shoes_dataGrid.Location = new System.Drawing.Point(3, 72);
            this.Shoes_dataGrid.Name = "Shoes_dataGrid";
            this.Shoes_dataGrid.ReadOnly = true;
            this.Shoes_dataGrid.Size = new System.Drawing.Size(673, 393);
            this.Shoes_dataGrid.TabIndex = 0;
            this.Shoes_dataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Shoes_dataGrid_DataError);
            // 
            // btn_sort_shoes
            // 
            this.btn_sort_shoes.ActiveControl = null;
            this.btn_sort_shoes.Location = new System.Drawing.Point(487, 13);
            this.btn_sort_shoes.Name = "btn_sort_shoes";
            this.btn_sort_shoes.Size = new System.Drawing.Size(171, 42);
            this.btn_sort_shoes.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sort_shoes.TabIndex = 2;
            this.btn_sort_shoes.Text = "SORT SHOES";
            this.btn_sort_shoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sort_shoes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sort_shoes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sort_shoes.UseSelectable = true;
            this.btn_sort_shoes.Click += new System.EventHandler(this.btn_sort_shoes_Click);
            // 
            // panel_women
            // 
            this.panel_women.BackColor = System.Drawing.Color.Red;
            this.panel_women.Controls.Add(this.cmb_women);
            this.panel_women.Controls.Add(this.lbl_women);
            this.panel_women.Controls.Add(this.women_datagrid);
            this.panel_women.Controls.Add(this.btn_sort_women);
            this.panel_women.Location = new System.Drawing.Point(235, 72);
            this.panel_women.Name = "panel_women";
            this.panel_women.Size = new System.Drawing.Size(680, 468);
            this.panel_women.TabIndex = 7;
            // 
            // cmb_women
            // 
            this.cmb_women.FormattingEnabled = true;
            this.cmb_women.ItemHeight = 23;
            this.cmb_women.Items.AddRange(new object[] {
            "Addidas",
            "Armani",
            "Calvin Klein",
            "Casio",
            "Chanel",
            "Dior",
            "Hublot",
            "Levis",
            "Mugler",
            "Nike",
            "Omega",
            "Polo",
            "Reebok",
            "Rolex",
            "Tag"});
            this.cmb_women.Location = new System.Drawing.Point(188, 19);
            this.cmb_women.Name = "cmb_women";
            this.cmb_women.Size = new System.Drawing.Size(272, 29);
            this.cmb_women.TabIndex = 2;
            this.cmb_women.UseSelectable = true;
            // 
            // lbl_women
            // 
            this.lbl_women.AutoSize = true;
            this.lbl_women.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_women.Location = new System.Drawing.Point(93, 23);
            this.lbl_women.Name = "lbl_women";
            this.lbl_women.Size = new System.Drawing.Size(74, 25);
            this.lbl_women.TabIndex = 1;
            this.lbl_women.Text = "Brand";
            // 
            // women_datagrid
            // 
            this.women_datagrid.AllowUserToAddRows = false;
            this.women_datagrid.AllowUserToDeleteRows = false;
            this.women_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.women_datagrid.Location = new System.Drawing.Point(3, 72);
            this.women_datagrid.Name = "women_datagrid";
            this.women_datagrid.ReadOnly = true;
            this.women_datagrid.Size = new System.Drawing.Size(673, 393);
            this.women_datagrid.TabIndex = 0;
            // 
            // btn_sort_women
            // 
            this.btn_sort_women.ActiveControl = null;
            this.btn_sort_women.Location = new System.Drawing.Point(487, 13);
            this.btn_sort_women.Name = "btn_sort_women";
            this.btn_sort_women.Size = new System.Drawing.Size(171, 42);
            this.btn_sort_women.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sort_women.TabIndex = 2;
            this.btn_sort_women.Text = "SORT WOMEN";
            this.btn_sort_women.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sort_women.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sort_women.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sort_women.UseSelectable = true;
            this.btn_sort_women.Click += new System.EventHandler(this.btn_sort_women_Click);
            // 
            // panel_men
            // 
            this.panel_men.BackColor = System.Drawing.Color.Red;
            this.panel_men.Controls.Add(this.cmb_men);
            this.panel_men.Controls.Add(this.label_men);
            this.panel_men.Controls.Add(this.men_datagrid);
            this.panel_men.Controls.Add(this.btn_sort_men);
            this.panel_men.Location = new System.Drawing.Point(235, 72);
            this.panel_men.Name = "panel_men";
            this.panel_men.Size = new System.Drawing.Size(680, 468);
            this.panel_men.TabIndex = 8;
            // 
            // cmb_men
            // 
            this.cmb_men.FormattingEnabled = true;
            this.cmb_men.ItemHeight = 23;
            this.cmb_men.Items.AddRange(new object[] {
            "Addidas",
            "Armani",
            "Calvin Klein",
            "Casio",
            "Chanel",
            "Dior",
            "Hublot",
            "Levis",
            "Mugler",
            "Nike",
            "Omega",
            "Polo",
            "Reebok",
            "Rolex",
            "Tag"});
            this.cmb_men.Location = new System.Drawing.Point(188, 19);
            this.cmb_men.Name = "cmb_men";
            this.cmb_men.Size = new System.Drawing.Size(272, 29);
            this.cmb_men.TabIndex = 2;
            this.cmb_men.UseSelectable = true;
            // 
            // label_men
            // 
            this.label_men.AutoSize = true;
            this.label_men.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_men.Location = new System.Drawing.Point(93, 23);
            this.label_men.Name = "label_men";
            this.label_men.Size = new System.Drawing.Size(74, 25);
            this.label_men.TabIndex = 1;
            this.label_men.Text = "Brand";
            // 
            // men_datagrid
            // 
            this.men_datagrid.AllowUserToAddRows = false;
            this.men_datagrid.AllowUserToDeleteRows = false;
            this.men_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.men_datagrid.Location = new System.Drawing.Point(3, 72);
            this.men_datagrid.Name = "men_datagrid";
            this.men_datagrid.ReadOnly = true;
            this.men_datagrid.Size = new System.Drawing.Size(673, 393);
            this.men_datagrid.TabIndex = 0;
            this.men_datagrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.men_datagrid_DataError);
            // 
            // btn_sort_men
            // 
            this.btn_sort_men.ActiveControl = null;
            this.btn_sort_men.Location = new System.Drawing.Point(487, 13);
            this.btn_sort_men.Name = "btn_sort_men";
            this.btn_sort_men.Size = new System.Drawing.Size(171, 42);
            this.btn_sort_men.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_sort_men.TabIndex = 2;
            this.btn_sort_men.Text = "SORT MEN";
            this.btn_sort_men.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sort_men.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_sort_men.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_sort_men.UseSelectable = true;
            this.btn_sort_men.Click += new System.EventHandler(this.btn_sort_men_Click);
            // 
            // viewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.panel_men);
            this.Controls.Add(this.panel_women);
            this.Controls.Add(this.panel_shoes);
            this.Controls.Add(this.panel_werable);
            this.Controls.Add(this.panel_perfumes);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_perfumes);
            this.Controls.Add(this.btn_wearbles);
            this.Controls.Add(this.btn_shoes);
            this.Controls.Add(this.btn_women);
            this.Controls.Add(this.btn_men);
            this.Controls.Add(this.lbl_view);
            this.Controls.Add(this.view_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewItems";
            this.Load += new System.EventHandler(this.viewItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_pb)).EndInit();
            this.panel_perfumes.ResumeLayout(false);
            this.panel_perfumes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfume_datagrid)).EndInit();
            this.panel_werable.ResumeLayout(false);
            this.panel_werable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wearable_datagrid)).EndInit();
            this.panel_shoes.ResumeLayout(false);
            this.panel_shoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shoes_dataGrid)).EndInit();
            this.panel_women.ResumeLayout(false);
            this.panel_women.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.women_datagrid)).EndInit();
            this.panel_men.ResumeLayout(false);
            this.panel_men.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.men_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view_pb;
        private System.Windows.Forms.Label lbl_view;
        private MetroFramework.Controls.MetroTile btn_men;
        private MetroFramework.Controls.MetroTile btn_women;
        private MetroFramework.Controls.MetroTile btn_shoes;
        private MetroFramework.Controls.MetroTile btn_wearbles;
        private MetroFramework.Controls.MetroTile btn_perfumes;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private JDragControl.JDragControl view_control;
        private System.Windows.Forms.Panel panel_perfumes;
        private System.Windows.Forms.DataGridView perfume_datagrid;
        private MetroFramework.Controls.MetroComboBox cmb_perfume;
        private System.Windows.Forms.Label lbl_perfume;
        private MetroFramework.Controls.MetroTile btn_sort_perfume;
        private System.Windows.Forms.Panel panel_werable;
        private MetroFramework.Controls.MetroComboBox cmb_wearable_brand;
        private System.Windows.Forms.Label lbl_wearable;
        private System.Windows.Forms.DataGridView wearable_datagrid;
        private MetroFramework.Controls.MetroTile btn_sort_werable;
        private System.Windows.Forms.Panel panel_shoes;
        private MetroFramework.Controls.MetroComboBox cmb_shoes;
        private System.Windows.Forms.Label lbl_shoes;
        private System.Windows.Forms.DataGridView Shoes_dataGrid;
        private MetroFramework.Controls.MetroTile btn_sort_shoes;
        private System.Windows.Forms.Panel panel_women;
        private MetroFramework.Controls.MetroComboBox cmb_women;
        private System.Windows.Forms.Label lbl_women;
        private System.Windows.Forms.DataGridView women_datagrid;
        private MetroFramework.Controls.MetroTile btn_sort_women;
        private System.Windows.Forms.Panel panel_men;
        private MetroFramework.Controls.MetroComboBox cmb_men;
        private System.Windows.Forms.Label label_men;
        private System.Windows.Forms.DataGridView men_datagrid;
        private MetroFramework.Controls.MetroTile btn_sort_men;
    }
}