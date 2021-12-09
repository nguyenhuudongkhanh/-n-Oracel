namespace DoAnOracel
{
    partial class TiemKiemSach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.radiogia = new System.Windows.Forms.RadioButton();
            this.radiotensach = new System.Windows.Forms.RadioButton();
            this.radiomasach = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(222, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 177);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btntim);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.radiogia);
            this.groupBox1.Controls.Add(this.radiotensach);
            this.groupBox1.Controls.Add(this.radiomasach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(222, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm ";
            // 
            // btntim
            // 
            this.btntim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntim.FlatAppearance.BorderSize = 0;
            this.btntim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btntim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btntim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntim.Location = new System.Drawing.Point(297, 111);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(102, 44);
            this.btntim.TabIndex = 5;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnOracel.Properties.Resources.timkiem;
            this.pictureBox1.Location = new System.Drawing.Point(35, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 141);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(444, 111);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(101, 44);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát    ";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(297, 31);
            this.txttimkiem.MaximumSize = new System.Drawing.Size(277, 20);
            this.txttimkiem.MinimumSize = new System.Drawing.Size(277, 20);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(277, 20);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.Text = "Nhập vào từ khóa tìm kiếm";
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // radiogia
            // 
            this.radiogia.AutoSize = true;
            this.radiogia.Location = new System.Drawing.Point(466, 64);
            this.radiogia.Name = "radiogia";
            this.radiogia.Size = new System.Drawing.Size(67, 19);
            this.radiogia.TabIndex = 0;
            this.radiogia.TabStop = true;
            this.radiogia.Text = "Giá Sách";
            this.radiogia.UseVisualStyleBackColor = true;
            this.radiogia.CheckedChanged += new System.EventHandler(this.radiogia_CheckedChanged);
            // 
            // radiotensach
            // 
            this.radiotensach.AutoSize = true;
            this.radiotensach.Location = new System.Drawing.Point(333, 64);
            this.radiotensach.Name = "radiotensach";
            this.radiotensach.Size = new System.Drawing.Size(69, 19);
            this.radiotensach.TabIndex = 0;
            this.radiotensach.TabStop = true;
            this.radiotensach.Text = "Tên Sách";
            this.radiotensach.UseVisualStyleBackColor = true;
            this.radiotensach.CheckedChanged += new System.EventHandler(this.radiotensach_CheckedChanged);
            // 
            // radiomasach
            // 
            this.radiomasach.AutoSize = true;
            this.radiomasach.Location = new System.Drawing.Point(203, 64);
            this.radiomasach.Name = "radiomasach";
            this.radiomasach.Size = new System.Drawing.Size(66, 19);
            this.radiomasach.TabIndex = 0;
            this.radiomasach.TabStop = true;
            this.radiomasach.Text = "Mã sách";
            this.radiomasach.UseVisualStyleBackColor = true;
            this.radiomasach.CheckedChanged += new System.EventHandler(this.radiomasach_CheckedChanged);
            // 
            // TiemKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1146, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TiemKiemSach";
            this.Text = "TiemKiemSach";
            this.Load += new System.EventHandler(this.TiemKiemSach_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton radiogia;
        private System.Windows.Forms.RadioButton radiotensach;
        private System.Windows.Forms.RadioButton radiomasach;
    }
}