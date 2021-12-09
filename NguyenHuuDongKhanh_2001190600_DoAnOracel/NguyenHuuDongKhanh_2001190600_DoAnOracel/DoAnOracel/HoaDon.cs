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
    public partial class HoaDon : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dateTime.CustomFormat = " MM / dd / yyyy ";
            kn.loaddatagridview(datagrvHoaDon, "select * from HOADON");
        }

        private void datagrvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtmahd.Text = datagrvHoaDon.Rows[i].Cells[0].Value.ToString();
            dateTime.Text = datagrvHoaDon.Rows[i].Cells[1].Value.ToString();
            txtmanv.Text = datagrvHoaDon.Rows[i].Cells[2].Value.ToString();
            txttongtien.Text = datagrvHoaDon.Rows[i].Cells[3].Value.ToString();
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtmahd.Text)) || (string.IsNullOrEmpty(dateTime.Text)) || (string.IsNullOrEmpty(txtmanv.Text)) || (string.IsNullOrEmpty(txttongtien.Text)))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else if (!kn.kttrungkhoa(txtmahd.Text, "select MAHD from HOADON"))
                {
                    string Inser = string.Format("INSERT INTO HOADON(MAHD, NGAYLAP, MANV, TONGTIEN) VALUES('{0}','{1}','{2}','{3}')", txtmahd.Text, dateTime.Text, txtmanv.Text, txttongtien.Text);
                    kn.thucthiketnoi(Inser);
                    kn.loaddatagridview(datagrvHoaDon, "select * from HOADON");
                    MessageBox.Show("Thêm thành công  !!!");
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn này đã tòn tại bạn có thể thử mã khác ", "Trùng mã ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Them Thât bại !!!");
            }
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "delete from HOADON where MAHD='" + txtmahd.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kn.thucthiketnoi(del);
                    kn.loaddatagridview(datagrvHoaDon, "select * from HOADON");
                    MessageBox.Show("Xóa thành công ");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string Inser = string.Format("update HOADON set NGAYLAP='{1}',MANV='{2}',TONGTIEN='{3}' where MAHD ='{0}'", txtmahd.Text, dateTime.Text, txtmanv.Text, txttongtien.Text);
                kn.thucthiketnoi(Inser);
                kn.loaddatagridview(datagrvHoaDon, "select * from HOADON");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNoCancel);
            if (h == DialogResult.Yes)
                Application.Exit();
        }
    }
}
