using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOracel
{
    public partial class TimKiemThongTinNhanVien : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public TimKiemThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void TimKiemThongTinNhanVien_Load(object sender, EventArgs e)
        {
            radiomanv.Checked = true;
            kn.loaddatagridview(dataGridView1, "select * from NHANVIEN");
        }
        int i = 0;
        private void radiomanv_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void radioten_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radiochucvu_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txttimkiem.Text == "") || (txttimkiem.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        kn.loaddatagridview(dataGridView1, "select * from NHANVIEN where MANV=N'" + txttimkiem.Text + "'");
                    }
                    if (i == 2)
                    {
                        kn.loaddatagridview(dataGridView1, "select * from NHANVIEN where TENNV=N'" + txttimkiem.Text + "'");
                    }
                    if (i == 3)
                    {
                        kn.loaddatagridview(dataGridView1, "select * from NHANVIEN where MACV=N'" + txttimkiem.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if ((txttimkiem.Text == "") || (txttimkiem.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    kn.loaddatagridview(dataGridView1, "select * from NHANVIEN");
                }
                else
                {

                    if (i == 1)
                    {
                        kn.loatextbox(txttimkiem, "select * from NHANVIEN where MANV like N'" + txttimkiem.Text + "%'", 2);
                        kn.loaddatagridview(dataGridView1, "select * from NHANVIEN where MANV like N'" + txttimkiem.Text + "%'");
                    }
                    if (i == 2)
                    {
                        kn.loatextbox(txttimkiem, "select * from NHANVIEN where MaNV like N'" + txttimkiem.Text + "%'", 3);
                        kn.loaddatagridview(dataGridView1, "select * from NHANVIEN where TENNV like N'" + txttimkiem.Text + "%'");
                    }
                    if (i == 3)
                    {
                        kn.loatextbox(txttimkiem, "select * from NHANVIEN where MaNV like N'" + txttimkiem.Text + "%'", 8);
                        kn.loaddatagridview(dataGridView1, "select * from NHANVIEN where MACV like N'" + txttimkiem.Text + "%'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập vào từ khóa tìm kiếm")
            {
                txttimkiem.Text = "";
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNoCancel);
            if (h == DialogResult.Yes)
                Application.Exit();
        }
    }
}
