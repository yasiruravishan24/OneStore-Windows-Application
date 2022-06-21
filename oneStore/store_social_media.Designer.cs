
namespace oneStore
{
    partial class store_social_media
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
            this.btn_instagram = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.lbl_Store = new System.Windows.Forms.Label();
            this.btn_facebook = new MetroFramework.Controls.MetroTile();
            this.StoreBrowser = new System.Windows.Forms.WebBrowser();
            this.store_social_control = new JDragControl.JDragControl(this.components);
            this.store_social_pb = new System.Windows.Forms.PictureBox();
            this.btn_web_reload = new MetroFramework.Controls.MetroTile();
            this.btn_web_forward = new MetroFramework.Controls.MetroTile();
            this.btn_web_back = new MetroFramework.Controls.MetroTile();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_google = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.store_social_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_instagram
            // 
            this.btn_instagram.ActiveControl = null;
            this.btn_instagram.Location = new System.Drawing.Point(12, 128);
            this.btn_instagram.Name = "btn_instagram";
            this.btn_instagram.Size = new System.Drawing.Size(203, 50);
            this.btn_instagram.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_instagram.TabIndex = 1;
            this.btn_instagram.Text = "Instagram";
            this.btn_instagram.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_instagram.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_instagram.UseSelectable = true;
            this.btn_instagram.Click += new System.EventHandler(this.btn_instagram_Click);
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
            // lbl_Store
            // 
            this.lbl_Store.AutoSize = true;
            this.lbl_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Store.Location = new System.Drawing.Point(271, 14);
            this.lbl_Store.Name = "lbl_Store";
            this.lbl_Store.Size = new System.Drawing.Size(302, 37);
            this.lbl_Store.TabIndex = 2;
            this.lbl_Store.Text = "Store Social Media";
            // 
            // btn_facebook
            // 
            this.btn_facebook.ActiveControl = null;
            this.btn_facebook.Location = new System.Drawing.Point(12, 72);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.Size = new System.Drawing.Size(203, 50);
            this.btn_facebook.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_facebook.TabIndex = 1;
            this.btn_facebook.Text = "Facebook";
            this.btn_facebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_facebook.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_facebook.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_facebook.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_facebook.UseSelectable = true;
            this.btn_facebook.UseTileImage = true;
            this.btn_facebook.Click += new System.EventHandler(this.btn_facebook_Click);
            // 
            // StoreBrowser
            // 
            this.StoreBrowser.Location = new System.Drawing.Point(272, 60);
            this.StoreBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.StoreBrowser.Name = "StoreBrowser";
            this.StoreBrowser.ScriptErrorsSuppressed = true;
            this.StoreBrowser.Size = new System.Drawing.Size(794, 465);
            this.StoreBrowser.TabIndex = 0;
            // 
            // store_social_control
            // 
            this.store_social_control.GetForm = this;
            this.store_social_control.TargetControl = this.store_social_pb;
            // 
            // store_social_pb
            // 
            this.store_social_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.store_social_pb.Image = global::oneStore.Properties.Resources.sellitems;
            this.store_social_pb.Location = new System.Drawing.Point(0, 0);
            this.store_social_pb.Name = "store_social_pb";
            this.store_social_pb.Size = new System.Drawing.Size(1078, 590);
            this.store_social_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.store_social_pb.TabIndex = 0;
            this.store_social_pb.TabStop = false;
            // 
            // btn_web_reload
            // 
            this.btn_web_reload.ActiveControl = null;
            this.btn_web_reload.Location = new System.Drawing.Point(722, 531);
            this.btn_web_reload.Name = "btn_web_reload";
            this.btn_web_reload.Size = new System.Drawing.Size(124, 53);
            this.btn_web_reload.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_web_reload.TabIndex = 6;
            this.btn_web_reload.TileImage = global::oneStore.Properties.Resources.reload_button;
            this.btn_web_reload.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_web_reload.UseSelectable = true;
            this.btn_web_reload.UseTileImage = true;
            this.btn_web_reload.Click += new System.EventHandler(this.btn_web_reload_Click);
            // 
            // btn_web_forward
            // 
            this.btn_web_forward.ActiveControl = null;
            this.btn_web_forward.Location = new System.Drawing.Point(592, 531);
            this.btn_web_forward.Name = "btn_web_forward";
            this.btn_web_forward.Size = new System.Drawing.Size(124, 53);
            this.btn_web_forward.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_web_forward.TabIndex = 6;
            this.btn_web_forward.TileImage = global::oneStore.Properties.Resources.forward_button;
            this.btn_web_forward.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_web_forward.UseSelectable = true;
            this.btn_web_forward.UseTileImage = true;
            this.btn_web_forward.Click += new System.EventHandler(this.btn_web_forward_Click);
            // 
            // btn_web_back
            // 
            this.btn_web_back.ActiveControl = null;
            this.btn_web_back.Location = new System.Drawing.Point(462, 531);
            this.btn_web_back.Name = "btn_web_back";
            this.btn_web_back.Size = new System.Drawing.Size(124, 53);
            this.btn_web_back.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_web_back.TabIndex = 6;
            this.btn_web_back.TileImage = global::oneStore.Properties.Resources.back_button;
            this.btn_web_back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_web_back.UseSelectable = true;
            this.btn_web_back.UseTileImage = true;
            this.btn_web_back.Click += new System.EventHandler(this.btn_web_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::oneStore.Properties.Resources.exit;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(1037, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(32, 32);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackgroundImage = global::oneStore.Properties.Resources.minimize;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(1001, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // btn_google
            // 
            this.btn_google.ActiveControl = null;
            this.btn_google.Location = new System.Drawing.Point(12, 184);
            this.btn_google.Name = "btn_google";
            this.btn_google.Size = new System.Drawing.Size(203, 50);
            this.btn_google.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_google.TabIndex = 1;
            this.btn_google.Text = "Google";
            this.btn_google.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_google.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btn_google.UseSelectable = true;
            this.btn_google.Click += new System.EventHandler(this.btn_google_Click);
            // 
            // store_social_media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 590);
            this.Controls.Add(this.btn_web_reload);
            this.Controls.Add(this.btn_web_forward);
            this.Controls.Add(this.btn_web_back);
            this.Controls.Add(this.StoreBrowser);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.lbl_Store);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_google);
            this.Controls.Add(this.btn_instagram);
            this.Controls.Add(this.btn_facebook);
            this.Controls.Add(this.store_social_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "store_social_media";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "store_social_media";
            this.Load += new System.EventHandler(this.store_social_media_Load);
            ((System.ComponentModel.ISupportInitialize)(this.store_social_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox store_social_pb;
        private MetroFramework.Controls.MetroTile btn_facebook;
        private MetroFramework.Controls.MetroTile btn_instagram;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Label lbl_Store;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.WebBrowser StoreBrowser;
        private JDragControl.JDragControl store_social_control;
        private MetroFramework.Controls.MetroTile btn_web_reload;
        private MetroFramework.Controls.MetroTile btn_web_forward;
        private MetroFramework.Controls.MetroTile btn_web_back;
        private MetroFramework.Controls.MetroTile btn_google;
    }
}