namespace DoAnOracel
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.label5 = new System.Windows.Forms.Label();
            this.datagrvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkhungtongtien = new System.Windows.Forms.TextBox();
            this.btntongtiennam = new System.Windows.Forms.Button();
            this.btntong = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txttongnhanvien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtluongthang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txthoahong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txthsl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtquyen = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtuse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbgioitinh = new System.Windows.Forms.ComboBox();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrvNhanVien)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(208, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 61);
            this.label5.TabIndex = 71;
            this.label5.Text = "QUẢN LÝ NHÀ SÁCH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagrvNhanVien
            // 
            this.datagrvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrvNhanVien.Location = new System.Drawing.Point(159, 343);
            this.datagrvNhanVien.Name = "datagrvNhanVien";
            this.datagrvNhanVien.Size = new System.Drawing.Size(746, 188);
            this.datagrvNhanVien.TabIndex = 68;
            this.datagrvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrvNhanVien_CellClick);
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
            this.groupBox2.Location = new System.Drawing.Point(44, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 50);
            this.groupBox2.TabIndex = 70;
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
            this.groupBox1.Controls.Add(this.txtkhungtongtien);
            this.groupBox1.Controls.Add(this.btntongtiennam);
            this.groupBox1.Controls.Add(this.btntong);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txttongnhanvien);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtluongthang);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtluongcoban);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txthoahong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txthsl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtquyen);
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.txtuse);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbgioitinh);
            this.groupBox1.Controls.Add(this.txtmacv);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(45, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 273);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các thông tin về nhân viên ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtkhungtongtien
            // 
            this.txtkhungtongtien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkhungtongtien.Location = new System.Drawing.Point(722, 241);
            this.txtkhungtongtien.Name = "txtkhungtongtien";
            this.txtkhungtongtien.Size = new System.Drawing.Size(282, 26);
            this.txtkhungtongtien.TabIndex = 98;
            // 
            // btntongtiennam
            // 
            this.btntongtiennam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntongtiennam.BackgroundImage")));
            this.btntongtiennam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntongtiennam.FlatAppearance.BorderSize = 0;
            this.btntongtiennam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btntongtiennam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btntongtiennam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntongtiennam.Image = global::DoAnOracel.Properties.Resources.upload;
            this.btntongtiennam.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btntongtiennam.Location = new System.Drawing.Point(729, 181);
            this.btntongtiennam.Name = "btntongtiennam";
            this.btntongtiennam.Size = new System.Drawing.Size(228, 45);
            this.btntongtiennam.TabIndex = 97;
            this.btntongtiennam.Text = "TONG TIEN MA NHAN VIEN LAM TRONG NAM ";
            this.btntongtiennam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntongtiennam.UseVisualStyleBackColor = true;
            this.btntongtiennam.Click += new System.EventHandler(this.btntongtiennam_Click);
            // 
            // btntong
            // 
            this.btntong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntong.BackgroundImage")));
            this.btntong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntong.FlatAppearance.BorderSize = 0;
            this.btntong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btntong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btntong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntong.Image = global::DoAnOracel.Properties.Resources.upload;
            this.btntong.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btntong.Location = new System.Drawing.Point(588, 181);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(145, 26);
            this.btntong.TabIndex = 6;
            this.btntong.Text = "TONG NHAN VIEN  ";
            this.btntong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(300, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 26);
            this.label15.TabIndex = 96;
            this.label15.Text = "TONGSONHANVIEN";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttongnhanvien
            // 
            this.txttongnhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongnhanvien.Location = new System.Drawing.Point(451, 181);
            this.txttongnhanvien.Name = "txttongnhanvien";
            this.txttongnhanvien.Size = new System.Drawing.Size(131, 26);
            this.txttongnhanvien.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(12, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 26);
            this.label14.TabIndex = 94;
            this.label14.Text = "LUONGTHANG";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtluongthang
            // 
            this.txtluongthang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtluongthang.Location = new System.Drawing.Point(163, 185);
            this.txtluongthang.Name = "txtluongthang";
            this.txtluongthang.Size = new System.Drawing.Size(131, 26);
            this.txtluongthang.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(588, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 26);
            this.label13.TabIndex = 92;
            this.label13.Text = "LUONGCOBAN";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtluongcoban.Location = new System.Drawing.Point(739, 144);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(131, 26);
            this.txtluongcoban.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(300, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 26);
            this.label12.TabIndex = 90;
            this.label12.Text = "HOAHONG";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthoahong
            // 
            this.txthoahong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoahong.Location = new System.Drawing.Point(451, 144);
            this.txthoahong.Name = "txthoahong";
            this.txthoahong.Size = new System.Drawing.Size(131, 26);
            this.txthoahong.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(12, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 26);
            this.label11.TabIndex = 88;
            this.label11.Text = "HESOLUONG";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthsl
            // 
            this.txthsl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthsl.Location = new System.Drawing.Point(163, 144);
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(131, 26);
            this.txthsl.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(588, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 86;
            this.label2.Text = "QUYEN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(588, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 26);
            this.label9.TabIndex = 85;
            this.label9.Text = "MATKHAU";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(588, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 26);
            this.label10.TabIndex = 84;
            this.label10.Text = "TENDANGNHAP";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtquyen
            // 
            this.txtquyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquyen.Location = new System.Drawing.Point(739, 100);
            this.txtquyen.Name = "txtquyen";
            this.txtquyen.Size = new System.Drawing.Size(131, 26);
            this.txtquyen.TabIndex = 83;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(739, 59);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(131, 26);
            this.txtmatkhau.TabIndex = 82;
            // 
            // txtuse
            // 
            this.txtuse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuse.Location = new System.Drawing.Point(739, 17);
            this.txtuse.Name = "txtuse";
            this.txtuse.Size = new System.Drawing.Size(131, 26);
            this.txtuse.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(300, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 80;
            this.label8.Text = "MACV";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 26);
            this.label7.TabIndex = 79;
            this.label7.Text = "GIOITINH";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(300, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 26);
            this.label6.TabIndex = 78;
            this.label6.Text = "DIENTHOAI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(300, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "DIACHI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 76;
            this.label3.Text = "TENNV";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbgioitinh
            // 
            this.cmbgioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgioitinh.FormattingEnabled = true;
            this.cmbgioitinh.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbgioitinh.Location = new System.Drawing.Point(163, 97);
            this.cmbgioitinh.Name = "cmbgioitinh";
            this.cmbgioitinh.Size = new System.Drawing.Size(131, 27);
            this.cmbgioitinh.TabIndex = 75;
            // 
            // txtmacv
            // 
            this.txtmacv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacv.Location = new System.Drawing.Point(451, 99);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(131, 26);
            this.txtmacv.TabIndex = 74;
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(163, 17);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(131, 26);
            this.txtmanv.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 72;
            this.label4.Text = "MANV";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(163, 58);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(131, 26);
            this.txttennv.TabIndex = 69;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Location = new System.Drawing.Point(451, 58);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(131, 26);
            this.txtdienthoai.TabIndex = 71;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(451, 16);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(131, 26);
            this.txtdiachi.TabIndex = 70;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnOracel.Properties.Resources.hinh_nen_win_8_full_hd_dep_2;
            this.ClientSize = new System.Drawing.Size(1086, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagrvNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrvNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView datagrvNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbgioitinh;
        private System.Windows.Forms.TextBox txtmacv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtquyen;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtuse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtluongthang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txthoahong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txthsl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttongnhanvien;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.TextBox txtkhungtongtien;
        private System.Windows.Forms.Button btntongtiennam;
    }
}