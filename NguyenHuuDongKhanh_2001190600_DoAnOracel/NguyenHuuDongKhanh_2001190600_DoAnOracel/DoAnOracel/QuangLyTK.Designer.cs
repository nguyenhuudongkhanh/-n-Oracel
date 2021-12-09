namespace DoAnOracel
{
    partial class QuangLyTK
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
            this.datagrvNhanVien = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrvNhanVien
            // 
            this.datagrvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrvNhanVien.Location = new System.Drawing.Point(152, 127);
            this.datagrvNhanVien.Name = "datagrvNhanVien";
            this.datagrvNhanVien.Size = new System.Drawing.Size(746, 188);
            this.datagrvNhanVien.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font(".Vn3DH", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(198, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 118);
            this.label5.TabIndex = 70;
            this.label5.Text = "QUẢN LÝ TÀI KHOẢNG ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // QuangLyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnOracel.Properties.Resources._133;
            this.ClientSize = new System.Drawing.Size(1050, 442);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagrvNhanVien);
            this.Name = "QuangLyTK";
            this.Text = "QuangLyTK";
            this.Load += new System.EventHandler(this.QuangLyTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrvNhanVien;
        private System.Windows.Forms.Label label5;
    }
}