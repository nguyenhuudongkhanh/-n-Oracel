using Oracle.ManagedDataAccess.Client;
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
    public partial class DangNhap : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        private OracleConnection Con = null;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string host = "localhost";
            int port = 1521;
            string sid = "orcl1";
            string user = "KhanhNguyen";
            string password = "123";
            Con = new OracleConnection();
            Con.ConnectionString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                  + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                  + sid + ")));Password=" + password + ";User ID=" + user;

            Con.Open();
            string select = "Select * From NHANVIEN where TENNV='" + txttennhanvien.Text + "' and TenDangNhap='" + txtus.Text + "' and MatKhau='" + txtmk.Text + "'  and Quyen='Admin'";
            OracleCommand cmd = new OracleCommand(select, Con);
            OracleDataReader reader = cmd.ExecuteReader();

            //if ((string.IsNullOrEmpty(txttennhanvien.Text)) || (string.IsNullOrEmpty(txtus.Text)) || (string.IsNullOrEmpty(txtmk.Text)))
            //{
            //    MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            //}
            if (reader.Read())
            {
                //reader.Read();
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !", "Thông báo !");
                DanhMuc.quyen = "Admin";
                this.Hide();
                this.Close();
            }
            else if (reader.Read())
            {
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền user) !", "Thông báo !");
                DanhMuc.quyen = "User";
                this.Hide();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền user1) !", "Thông báo !");
                DanhMuc.quyen = "User1";
                this.Hide();
                this.Close();
            }
            DanhMuc frm = new DanhMuc();
            //frm.Show();
            frm.ShowDialog();
            cmd.Dispose();
            reader.Close();
            reader.Dispose();


        }
    }
}

