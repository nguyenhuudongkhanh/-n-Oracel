namespace DoAnOracel
{
    partial class MenuChucNangHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuChucNangHeThong));
            this.panel_show = new System.Windows.Forms.Panel();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucNangHeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_show
            // 
            this.panel_show.BackgroundImage = global::DoAnOracel.Properties.Resources.afsadfdafdfaf;
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show.Location = new System.Drawing.Point(12, 80);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1016, 443);
            this.panel_show.TabIndex = 22;
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangHeThongToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.danhMucToolStripMenuItem.Font = new System.Drawing.Font(".Vn3DH", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(157, 42);
            this.danhMucToolStripMenuItem.Text = "DanhMuc";
            // 
            // chucNangHeThongToolStripMenuItem
            // 
            this.chucNangHeThongToolStripMenuItem.Name = "chucNangHeThongToolStripMenuItem";
            this.chucNangHeThongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chucNangHeThongToolStripMenuItem.Text = "ChucNangHeThong";
            this.chucNangHeThongToolStripMenuItem.Click += new System.EventHandler(this.chucNangHeThongToolStripMenuItem_Click);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(358, 42);
            this.sessionToolStripMenuItem.Text = "Session";
            this.sessionToolStripMenuItem.Click += new System.EventHandler(this.sessionToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 46);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Image = global::DoAnOracel.Properties.Resources._1;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(949, 27);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(79, 26);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát ";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font(".Vn3DH", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(170, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(665, 53);
            this.label5.TabIndex = 46;
            this.label5.Text = "DANH MỤC CÁC CHỨC NĂNG CỦA ORACEL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuChucNangHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 524);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuChucNangHeThong";
            this.Text = "MenuChucNangHeThong";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucNangHeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label5;


    }
}