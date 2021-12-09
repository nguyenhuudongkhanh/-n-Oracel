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
    public partial class ChiTietHoaDon : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvCTHoaDon, "select * from CTHD");
        }

        private void datagrvCTHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrvCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtmahd.Text = datagrvCTHoaDon.Rows[i].Cells[0].Value.ToString();
            txtmash.Text = datagrvCTHoaDon.Rows[i].Cells[1].Value.ToString();
            txtsoluong.Text = datagrvCTHoaDon.Rows[i].Cells[2].Value.ToString();
            txtgia.Text = datagrvCTHoaDon.Rows[i].Cells[3].Value.ToString();

            txtthanhtien.Text = datagrvCTHoaDon.Rows[i].Cells[4].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtmahd.Text)) || (string.IsNullOrEmpty(txtmash.Text)) || (string.IsNullOrEmpty(txtsoluong.Text)) )
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else 
                {
                    string Inser = string.Format("INSERT INTO CTHD(MAHD, MASH, SL,GIA, THANHTIEN) VALUES('{0}','{1}','{2}','{3}','{4}')", txtmahd.Text, txtmash.Text, txtsoluong.Text, txtgia.Text,txtthanhtien.Text);
                    kn.thucthiketnoi(Inser);
                    kn.loaddatagridview(datagrvCTHoaDon, "select * from CTHD");
                }
               
            }
            catch
            {
                MessageBox.Show("Them That Bai!!!");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string Inser = string.Format("update  CTHD set MASH='{1}',SL='{2}',THANHTIEN='{3}' where MAHD ='{0}'", txtmahd.Text, txtmash.Text, txtsoluong.Text, txtthanhtien.Text);
                kn.thucthiketnoi(Inser);
                kn.loaddatagridview(datagrvCTHoaDon, "select * from CTHD");
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
                string del = "delete from CTHD where MAHD='" + txtmahd.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kn.thucthiketnoi(del);
                    kn.loaddatagridview(datagrvCTHoaDon, "select * from CTHD");
                }
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
