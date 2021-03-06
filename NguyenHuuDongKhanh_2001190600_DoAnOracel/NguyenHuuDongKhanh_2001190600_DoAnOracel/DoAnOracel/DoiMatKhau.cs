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
    public partial class DoiMatKhau : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnhoantat_Click(object sender, EventArgs e)
        {
            string update = "update NHANVIEN set MatKhau='" + txtmkmoi.Text + "' where(TenDangNhap=N'" + txttentruycap.Text + "' and MatKhau='" + txtmkcu.Text + "')";
            string ten = txttentruycap.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtmkcu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtmkmoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtgolaimk.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (txtmkmoi.Text == txtgolaimk.Text)
                            {
                                kn.thucthiketnoi(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }

        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
