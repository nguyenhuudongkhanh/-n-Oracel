namespace DoAnOracel
{
    partial class Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach));
            this.label5 = new System.Windows.Forms.Label();
            this.datagrvTacGia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmash = new System.Windows.Forms.TextBox();
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.txttensh = new System.Windows.Forms.TextBox();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrvTacGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font(".Vn3DH", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(171, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 61);
            this.label5.TabIndex = 45;
            this.label5.Text = "QUẢN LÝ NHÀ SÁCH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagrvTacGia
            // 
            this.datagrvTacGia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrvTacGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrvTacGia.Location = new System.Drawing.Point(135, 309);
            this.datagrvTacGia.Name = "datagrvTacGia";
            this.datagrvTacGia.Size = new System.Drawing.Size(746, 188);
            this.datagrvTacGia.TabIndex = 42;
            this.datagrvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrvTacGia_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnmoi);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(73, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 50);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btnmoi
            // 
            this.btnmoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmoi.BackgroundImage")));
            this.btnmoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmoi.FlatAppearance.BorderSize = 0;
            this.btnmoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmoi.Image = global::DoAnOracel.Properties.Resources.upload;
            this.btnmoi.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnmoi.Location = new System.Drawing.Point(98, 19);
            this.btnmoi.Name = "btnmoi";
            this.btnmoi.Size = new System.Drawing.Size(79, 26);
            this.btnmoi.TabIndex = 0;
            this.btnmoi.Text = "Mới   ";
            this.btnmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmoi.UseVisualStyleBackColor = true;
            this.btnmoi.Click += new System.EventHandler(this.btnmoi_Click);
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
            this.btnthoat.Location = new System.Drawing.Point(519, 19);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(79, 26);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát ";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.BackgroundImage")));
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Image = global::DoAnOracel.Properties.Resources.remove_user;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnxoa.Location = new System.Drawing.Point(418, 19);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(79, 26);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa   ";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthem.BackgroundImage")));
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Image = global::DoAnOracel.Properties.Resources.add_user;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(200, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(79, 26);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm ";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsua.BackgroundImage")));
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Image = global::DoAnOracel.Properties.Resources.edit_user;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(309, 19);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(79, 26);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa   ";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmaloai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmash);
            this.groupBox1.Controls.Add(this.txtmanxb);
            this.groupBox1.Controls.Add(this.txttensh);
            this.groupBox1.Controls.Add(this.txtnamxb);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(8, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 131);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các thông tin về sách";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(485, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 63;
            this.label3.Text = "MÃ NĂM XUẤT BẢN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(334, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 62;
            this.label2.Text = "NẴM XUẤT BẢN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(163, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 61;
            this.label1.Text = "TÊN SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 60;
            this.label4.Text = "MÃ SÁCH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmash
            // 
            this.txtmash.Location = new System.Drawing.Point(20, 57);
            this.txtmash.Name = "txtmash";
            this.txtmash.Size = new System.Drawing.Size(128, 21);
            this.txtmash.TabIndex = 9;
            // 
            // txtmanxb
            // 
            this.txtmanxb.Location = new System.Drawing.Point(485, 57);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(178, 21);
            this.txtmanxb.TabIndex = 6;
            // 
            // txttensh
            // 
            this.txttensh.Location = new System.Drawing.Point(163, 57);
            this.txttensh.Name = "txttensh";
            this.txttensh.Size = new System.Drawing.Size(151, 21);
            this.txttensh.TabIndex = 2;
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(334, 57);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(138, 21);
            this.txtnamxb.TabIndex = 8;
            this.txtnamxb.TextChanged += new System.EventHandler(this.txtbutdanh_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(669, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 26);
            this.label6.TabIndex = 65;
            this.label6.Text = "MÃ LOẠI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(669, 58);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(109, 21);
            this.txtmaloai.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(792, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 26);
            this.label7.TabIndex = 67;
            this.label7.Text = "GIÁ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(792, 174);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(113, 20);
            this.txtgia.TabIndex = 66;
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnOracel.Properties.Resources.hinh_nen_win_8_full_hd_dep_2;
            this.ClientSize = new System.Drawing.Size(1001, 527);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagrvTacGia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrvTacGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView datagrvTacGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmash;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.TextBox txttensh;
        private System.Windows.Forms.TextBox txtnamxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgia;
    }
}