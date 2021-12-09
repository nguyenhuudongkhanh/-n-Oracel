namespace DoAnOracel
{
    partial class Session
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Session));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncounss = new System.Windows.Forms.Button();
            this.txtss = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btntaotablespace = new System.Windows.Forms.Button();
            this.btntentablespace = new System.Windows.Forms.Button();
            this.btnXemtấtcảusercủadb = new System.Windows.Forms.Button();
            this.btnxemthongtin = new System.Windows.Forms.Button();
            this.btnxemcacprocessungvoisession = new System.Windows.Forms.Button();
            this.datagrvchucnang = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrvchucnang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btncounss);
            this.groupBox2.Controls.Add(this.txtss);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btntaotablespace);
            this.groupBox2.Controls.Add(this.btntentablespace);
            this.groupBox2.Controls.Add(this.btnXemtấtcảusercủadb);
            this.groupBox2.Controls.Add(this.btnxemthongtin);
            this.groupBox2.Controls.Add(this.btnxemcacprocessungvoisession);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1149, 92);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btncounss
            // 
            this.btncounss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncounss.BackgroundImage")));
            this.btncounss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncounss.FlatAppearance.BorderSize = 0;
            this.btncounss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncounss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncounss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncounss.Image = global::DoAnOracel.Properties.Resources.upload;
            this.btncounss.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btncounss.Location = new System.Drawing.Point(24, 60);
            this.btncounss.Name = "btncounss";
            this.btncounss.Size = new System.Drawing.Size(160, 26);
            this.btncounss.TabIndex = 0;
            this.btncounss.Text = "SO LUONG SESS";
            this.btncounss.UseVisualStyleBackColor = true;
            this.btncounss.Click += new System.EventHandler(this.btncounss_Click);
            // 
            // txtss
            // 
            this.txtss.Location = new System.Drawing.Point(202, 65);
            this.txtss.Name = "txtss";
            this.txtss.Size = new System.Drawing.Size(154, 21);
            this.txtss.TabIndex = 46;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DoAnOracel.Properties.Resources._1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(970, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kiem tra datafile";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DoAnOracel.Properties.Resources._1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(898, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm một datafile vào tablespace";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntaotablespace
            // 
            this.btntaotablespace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntaotablespace.BackgroundImage")));
            this.btntaotablespace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntaotablespace.FlatAppearance.BorderSize = 0;
            this.btntaotablespace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btntaotablespace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btntaotablespace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntaotablespace.Image = global::DoAnOracel.Properties.Resources._1;
            this.btntaotablespace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaotablespace.Location = new System.Drawing.Point(738, 19);
            this.btntaotablespace.Name = "btntaotablespace";
            this.btntaotablespace.Size = new System.Drawing.Size(154, 26);
            this.btntaotablespace.TabIndex = 6;
            this.btntaotablespace.Text = "Tạo mới một tablespace";
            this.btntaotablespace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntaotablespace.UseVisualStyleBackColor = true;
            this.btntaotablespace.Click += new System.EventHandler(this.btntaotablespace_Click);
            // 
            // btntentablespace
            // 
            this.btntentablespace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntentablespace.BackgroundImage")));
            this.btntentablespace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntentablespace.FlatAppearance.BorderSize = 0;
            this.btntentablespace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btntentablespace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btntentablespace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntentablespace.Image = global::DoAnOracel.Properties.Resources._1;
            this.btntentablespace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntentablespace.Location = new System.Drawing.Point(614, 18);
            this.btntentablespace.Name = "btntentablespace";
            this.btntentablespace.Size = new System.Drawing.Size(118, 26);
            this.btntentablespace.TabIndex = 5;
            this.btntentablespace.Text = "tên tablespace";
            this.btntentablespace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntentablespace.UseVisualStyleBackColor = true;
            this.btntentablespace.Click += new System.EventHandler(this.btntentablespace_Click);
            // 
            // btnXemtấtcảusercủadb
            // 
            this.btnXemtấtcảusercủadb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemtấtcảusercủadb.BackgroundImage")));
            this.btnXemtấtcảusercủadb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemtấtcảusercủadb.FlatAppearance.BorderSize = 0;
            this.btnXemtấtcảusercủadb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXemtấtcảusercủadb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnXemtấtcảusercủadb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemtấtcảusercủadb.Image = global::DoAnOracel.Properties.Resources.remove_user;
            this.btnXemtấtcảusercủadb.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXemtấtcảusercủadb.Location = new System.Drawing.Point(418, 19);
            this.btnXemtấtcảusercủadb.Name = "btnXemtấtcảusercủadb";
            this.btnXemtấtcảusercủadb.Size = new System.Drawing.Size(165, 26);
            this.btnXemtấtcảusercủadb.TabIndex = 3;
            this.btnXemtấtcảusercủadb.Text = "Xem tất cả user của db";
            this.btnXemtấtcảusercủadb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemtấtcảusercủadb.UseVisualStyleBackColor = true;
            this.btnXemtấtcảusercủadb.Click += new System.EventHandler(this.btnXemtấtcảusercủadb_Click);
            // 
            // btnxemthongtin
            // 
            this.btnxemthongtin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxemthongtin.BackgroundImage")));
            this.btnxemthongtin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxemthongtin.FlatAppearance.BorderSize = 0;
            this.btnxemthongtin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnxemthongtin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnxemthongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemthongtin.Image = global::DoAnOracel.Properties.Resources.add_user;
            this.btnxemthongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxemthongtin.Location = new System.Drawing.Point(24, 18);
            this.btnxemthongtin.Name = "btnxemthongtin";
            this.btnxemthongtin.Size = new System.Drawing.Size(158, 26);
            this.btnxemthongtin.TabIndex = 1;
            this.btnxemthongtin.Text = "Xem Thông Tin Sesstion";
            this.btnxemthongtin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxemthongtin.UseVisualStyleBackColor = true;
            this.btnxemthongtin.Click += new System.EventHandler(this.btnxemthongtin_Click);
            // 
            // btnxemcacprocessungvoisession
            // 
            this.btnxemcacprocessungvoisession.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxemcacprocessungvoisession.BackgroundImage")));
            this.btnxemcacprocessungvoisession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxemcacprocessungvoisession.FlatAppearance.BorderSize = 0;
            this.btnxemcacprocessungvoisession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnxemcacprocessungvoisession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnxemcacprocessungvoisession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemcacprocessungvoisession.Image = global::DoAnOracel.Properties.Resources.edit_user;
            this.btnxemcacprocessungvoisession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxemcacprocessungvoisession.Location = new System.Drawing.Point(202, 19);
            this.btnxemcacprocessungvoisession.Name = "btnxemcacprocessungvoisession";
            this.btnxemcacprocessungvoisession.Size = new System.Drawing.Size(186, 26);
            this.btnxemcacprocessungvoisession.TabIndex = 2;
            this.btnxemcacprocessungvoisession.Text = "xem cac process ung voi session";
            this.btnxemcacprocessungvoisession.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxemcacprocessungvoisession.UseVisualStyleBackColor = true;
            this.btnxemcacprocessungvoisession.Click += new System.EventHandler(this.btnxemcacprocessungvoisession_Click);
            // 
            // datagrvchucnang
            // 
            this.datagrvchucnang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrvchucnang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrvchucnang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrvchucnang.Location = new System.Drawing.Point(209, 164);
            this.datagrvchucnang.Name = "datagrvchucnang";
            this.datagrvchucnang.Size = new System.Drawing.Size(742, 243);
            this.datagrvchucnang.TabIndex = 47;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::DoAnOracel.Properties.Resources._1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(418, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 26);
            this.button3.TabIndex = 47;
            this.button3.Text = "Kiểm tra policy";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnOracel.Properties.Resources.afsadfdafdfaf;
            this.ClientSize = new System.Drawing.Size(1173, 431);
            this.Controls.Add(this.datagrvchucnang);
            this.Controls.Add(this.groupBox2);
            this.Name = "Session";
            this.Text = "Session";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrvchucnang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncounss;
        private System.Windows.Forms.Button btntentablespace;
        private System.Windows.Forms.Button btnXemtấtcảusercủadb;
        private System.Windows.Forms.Button btnxemthongtin;
        private System.Windows.Forms.Button btnxemcacprocessungvoisession;
        private System.Windows.Forms.TextBox txtss;
        private System.Windows.Forms.DataGridView datagrvchucnang;
        private System.Windows.Forms.Button btntaotablespace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}