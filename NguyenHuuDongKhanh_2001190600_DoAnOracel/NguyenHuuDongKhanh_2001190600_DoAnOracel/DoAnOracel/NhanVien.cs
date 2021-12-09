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
using System.Configuration;
using System.Collections.Specialized;
using System.Web;


namespace DoAnOracel
{
    public partial class NhanVien : Form
    {
        string TenDangNhap = "", MatKhau = "", Quyen = "";
        KetNoiOracel kn = new KetNoiOracel();
        public NhanVien()
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }

        private void datagrvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtmanv.Text = datagrvNhanVien.Rows[i].Cells[0].Value.ToString();
            txttennv.Text = datagrvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtdiachi.Text = datagrvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtdienthoai.Text = datagrvNhanVien.Rows[i].Cells[3].Value.ToString();
            cmbgioitinh.Text = datagrvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtmacv.Text = datagrvNhanVien.Rows[i].Cells[5].Value.ToString();
            txthsl.Text = datagrvNhanVien.Rows[i].Cells[6].Value.ToString();
            txtluongcoban.Text = datagrvNhanVien.Rows[i].Cells[7].Value.ToString();
            txtluongthang.Text = datagrvNhanVien.Rows[i].Cells[8].Value.ToString();
            txthoahong.Text = datagrvNhanVien.Rows[i].Cells[9].Value.ToString();
            txtuse.Text = datagrvNhanVien.Rows[i].Cells[10].Value.ToString();
            txtmatkhau.Text = datagrvNhanVien.Rows[i].Cells[11].Value.ToString();
            txtquyen.Text = datagrvNhanVien.Rows[i].Cells[12].Value.ToString();
           
        }

        private void NhanVien1_Load(object sender, EventArgs e)
        {

            kn.loaddatagridview(datagrvNhanVien, "select * from NHANVIEN");

            
        }

        private void btnmoi_Click(object sender, EventArgs e)
        { 
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //if (Quyen == "Admin")
            //{
                try
                {
                    if ((string.IsNullOrEmpty(txtmanv.Text)) || (string.IsNullOrEmpty(txttennv.Text)) || (string.IsNullOrEmpty(txtdiachi.Text))
                   || (string.IsNullOrEmpty(txtdienthoai.Text)) || (string.IsNullOrEmpty(cmbgioitinh.Text)) || (string.IsNullOrEmpty(txtmacv.Text)))
                    {
                        MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }

                    else if (!System.Text.RegularExpressions.Regex.IsMatch(txttennv.Text, "^[a-zA-Z ]"))
                    {
                        MessageBox.Show("ten khong duoc la so", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (!kn.kttrungkhoa(txtmanv.Text, "select MANV from NHANVIEN"))
                    {
                        string manv = txtmanv.Text;
                        string fullname = txttennv.Text;
                        string address = txtdiachi.Text;
                        string dienthoai = txtdienthoai.Text;
                        string gioitinh = cmbgioitinh.Text;
                        string macv = txtmacv.Text;
                        string user = txtuse.Text;
                        string pass = txtmatkhau.Text;
                        string quyen = txtquyen.Text;
                        string Inser = string.Format("INSERT INTO NHANVIEN(MANV, TENNV, DIACHI, DT,GIOITINH,MACV,HESOLUONG,LUONGCOBAN,LUONGTHANG,HOAHONG,TenDangNhap,MatKhau,Quyen) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", manv, fullname, address, dienthoai, gioitinh, macv,txthsl.Text,txtluongcoban.Text,txtluongthang.Text,txthoahong.Text, user, pass, quyen);
                        kn.thucthiketnoi(Inser);
                        kn.loaddatagridview(datagrvNhanVien, "select * from NHANVIEN");
                    }
                    else
                    {
                        MessageBox.Show("Mã nv   này đã tòn tại bạn có thể thử mã nv  khác ", "Trùng nv ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Them That bai!!!");
                }
            //}
            //else
            //{

            //    MessageBox.Show("ban khong co quyen tao moi");
            //}
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string manv = txtmanv.Text;
                    string fullname = txttennv.Text;
                    string address = txtdiachi.Text;
                    string dienthoai = txtdienthoai.Text;
                    string gioitinh = cmbgioitinh.Text;
                    string macv = txtmacv.Text;
                    string user = txtuse.Text;
                    string pass = txtmatkhau.Text;
                    string quyen = txtquyen.Text;
                    string Inser = string.Format("update  NHANVIEN set TENNV='{1}',DIACHI='{2}',DT='{3}',GIOITINH='{4}',MACV='{5}',HESOLUONG='{6}',LUONGCOBAN='{7}',LUONGTHANG='{8}',HOAHONG='{9}',TenDangNhap='{10}',MatKhau='{11}',Quyen='{12}' where MANV ='{0}'", manv, fullname, address, dienthoai, gioitinh, macv, txthsl.Text, txtluongcoban.Text, txtluongthang.Text, txthoahong.Text, user, pass, quyen);
                    kn.thucthiketnoi(Inser);
                    kn.loaddatagridview(datagrvNhanVien, "select * from NHANVIEN");
                    MessageBox.Show("Sửa thành công");
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không đúng");
                }
            
          
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string del = "delete from NHANVIEN where MANV='" + txtmanv.Text + "'";
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        kn.thucthiketnoi(del);
                        kn.loaddatagridview(datagrvNhanVien, "select * from NHANVIEN");
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không đúng");
                }
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNoCancel);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btntong_Click(object sender, EventArgs e)
        {
            //string host = "localhost";
        // int port = 1521;
        // string sid = "orcl1";
        // string user = "KhanhNguyen";
        //string password = "123";
         
        //string strconnect = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
        //         + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
        //         + sid + ")));Password=" + password + ";User ID=" + user;
        //      OracleConnection conn = new OracleConnection(strconnect);
        //    OracleCommand cmd = new OracleCommand("SELECT * FROM func_tongnv(@tongnv)",conn );
        //    // cmd.CommandType=CommandType.StoredProcedure;  
        //    cmd.Parameters.Add("@tongnv", "tongnv");
        //    OracleDataAdapter da = new   OracleDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    string str = dt.Rows[0][0].ToString();
           //HttpContext.Current.Response.Write(str.ToString()); 
            string khanh = "select count(*) from NHANVIEN" + "'group by MANV";
            txttongnhanvien.Text = (datagrvNhanVien.Rows.Count).ToString();
        }
       

        private void btntongtiennam_Click(object sender, EventArgs e)
        {
            float LUONGTHANG = float.Parse(txtluongthang.Text);

            float HOAHONG = float.Parse(txthoahong.Text);

            if (LUONGTHANG > 0 && HOAHONG > 0)
            {
                float luongthang = LUONGTHANG*12;
                float hoahongvaluongthang = HOAHONG*12*LUONGTHANG;
                float kq = luongthang + hoahongvaluongthang;
                txtkhungtongtien.Text = Convert.ToString(kq);

            }
            else
            {

                MessageBox.Show("Loi du lieu");
            }
        }
    }
}
