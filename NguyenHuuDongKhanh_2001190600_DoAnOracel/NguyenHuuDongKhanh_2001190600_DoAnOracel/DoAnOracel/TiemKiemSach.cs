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
    public partial class TiemKiemSach : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public TiemKiemSach()
        {
            InitializeComponent();
        }

        private void TiemKiemSach_Load(object sender, EventArgs e)
        {
            radiomasach.Checked = true;
            kn.loaddatagridview(dataGridView1, "select * from SACH");
        }
        int i = 0;
        private void radiomasach_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void radiotensach_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radiogia_CheckedChanged(object sender, EventArgs e)
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
                        kn.loaddatagridview(dataGridView1, "select * from SACH where MASH=N'" + txttimkiem.Text + "'");
                    }
                    if (i == 2)
                    {
                        kn.loaddatagridview(dataGridView1, "select * from SACH where TENSH=N'" + txttimkiem.Text + "'");
                    }
                    if (i == 3)
                    {
                        kn.loaddatagridview(dataGridView1, "select * from SACH where GIA=N'" + txttimkiem.Text + "'");
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
                    kn.loaddatagridview(dataGridView1, "select * from SACH");
                }
                else
                {

                    if (i == 1)
                    {
                        kn.loatextbox(txttimkiem, "select * from SACH where MASH like N'" + txttimkiem.Text + "%'", 2);
                        kn.loaddatagridview(dataGridView1, "select * from SACH where MASH like N'" + txttimkiem.Text + "%'");
                    }
                    if (i == 2)
                    {
                        kn.loatextbox(txttimkiem, "select * from SACH where MASH like N'" + txttimkiem.Text + "%'", 3);
                        kn.loaddatagridview(dataGridView1, "select * from SACH where TENSH like N'" + txttimkiem.Text + "%'");
                    }
                    if (i == 3)
                    {
                        kn.loatextbox(txttimkiem, "select * from SACH where MASH like N'" + txttimkiem.Text + "%'", 8);
                        kn.loaddatagridview(dataGridView1, "select * from SACH where GIA like N'" + txttimkiem.Text + "%'");
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
    }
}
