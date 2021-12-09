namespace DoAnOracel
{
    partial class ChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucVu));
            this.label5 = new System.Windows.Forms.Label();
            this.datagrvChucVU = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttenchucvu = new System.Windows.Forms.TextBox();
            this.txtmachucvu = new System.Windows.Forms.TextBox();
            this.lbltensv = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrvChucVU)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(191, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 61);
            this.label5.TabIndex = 45;
            this.label5.Text = "QUẢN LÝ NHÀ SÁCH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagrvChucVU
            // 
            this.datagrvChucVU.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrvChucVU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrvChucVU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrvChucVU.Location = new System.Drawing.Point(155, 311);
            this.datagrvChucVU.Name = "datagrvChucVU";
            this.datagrvChucVU.Size = new System.Drawing.Size(746, 188);
            this.datagrvChucVU.TabIndex = 42;
            this.datagrvChucVU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrvChucVU_CellClick);
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
            this.groupBox2.Location = new System.Drawing.Point(93, 255);
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
            this.groupBox1.Controls.Add(this.txtluong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttenchucvu);
            this.groupBox1.Controls.Add(this.txtmachucvu);
            this.groupBox1.Controls.Add(this.lbltensv);
            this.groupBox1.Controls.Add(this.lblma);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(28, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 131);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các thông tin về chức vụ";
            // 
            // txttenchucvu
            // 
            this.txttenchucvu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttenchucvu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenchucvu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttenchucvu.Location = new System.Drawing.Point(281, 86);
            this.txttenchucvu.Name = "txttenchucvu";
            this.txttenchucvu.Size = new System.Drawing.Size(185, 22);
            this.txttenchucvu.TabIndex = 26;
            // 
            // txtmachucvu
            // 
            this.txtmachucvu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmachucvu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmachucvu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtmachucvu.Location = new System.Drawing.Point(281, 28);
            this.txtmachucvu.Name = "txtmachucvu";
            this.txtmachucvu.Size = new System.Drawing.Size(185, 25);
            this.txtmachucvu.TabIndex = 25;
            // 
            // lbltensv
            // 
            this.lbltensv.BackColor = System.Drawing.Color.Aqua;
            this.lbltensv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltensv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltensv.ForeColor = System.Drawing.Color.Red;
            this.lbltensv.Location = new System.Drawing.Point(142, 78);
            this.lbltensv.Name = "lbltensv";
            this.lbltensv.Size = new System.Drawing.Size(100, 30);
            this.lbltensv.TabIndex = 24;
            this.lbltensv.Text = "TENCHUCVU";
            this.lbltensv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblma
            // 
            this.lblma.BackColor = System.Drawing.Color.Aqua;
            this.lblma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblma.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblma.ForeColor = System.Drawing.Color.Red;
            this.lblma.Location = new System.Drawing.Point(142, 24);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(100, 29);
            this.lblma.TabIndex = 23;
            this.lblma.Text = "MACHUCVU";
            this.lblma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtluong
            // 
            this.txtluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtluong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtluong.Location = new System.Drawing.Point(622, 29);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(185, 25);
            this.txtluong.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(483, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "LUONGCHUCVU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnOracel.Properties.Resources._133;
            this.ClientSize = new System.Drawing.Size(959, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagrvChucVU);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChucVu";
            this.Text = "ChucVu1";
            this.Load += new System.EventHandler(this.ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrvChucVU)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView datagrvChucVU;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttenchucvu;
        private System.Windows.Forms.TextBox txtmachucvu;
        private System.Windows.Forms.Label lbltensv;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.Label label1;
    }
}