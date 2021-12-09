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
    public partial class Sach : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public Sach()
        {
            InitializeComponent();
        }

        private void txtbutdanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string del = "delete from SACH where MASH='" + txtmash.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kn.thucthiketnoi(del);
                    kn.loaddatagridview(datagrvTacGia, "select * from SACH");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtmash.Text)) || (string.IsNullOrEmpty(txttensh.Text)) || (string.IsNullOrEmpty(txtnamxb.Text)) || (string.IsNullOrEmpty(txtmanxb.Text)) || (string.IsNullOrEmpty(txtmaloai.Text)) || (string.IsNullOrEmpty(txtgia.Text)))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else if (!kn.kttrungkhoa(txtmash.Text, "select MASH from SACH"))
                {
                    string Inser = string.Format("INSERT INTO SACH(MASH, TENSH, NAMXB, MANXB,MALOAI,GIA) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", txtmash.Text, txttensh.Text, txtnamxb.Text, txtmanxb.Text, txtmaloai.Text, txtgia.Text);
                    kn.thucthiketnoi(Inser);
                    kn.loaddatagridview(datagrvTacGia, "select * from SACH");
                }
                else
                {
                    MessageBox.Show("Mã sách   này đã tòn tại bạn có thể thử mã sách  khác ", "Trùng sách ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Them Thanh Cong!!!");
            }
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string Inser = string.Format("update  SACH set TENSH='{1}',NAMXB='{2}',MANXB='{3}',MALOAI='{4}' where MASH ='{0}'", txtmash.Text, txttensh.Text, txtnamxb.Text, txtmanxb.Text, txtmaloai.Text, txtgia.Text);
                kn.thucthiketnoi(Inser);
                kn.loaddatagridview(datagrvTacGia, "select * from SACH");
                MessageBox.Show("Sửa thành công");
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

        private void datagrvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtmash.Text = datagrvTacGia.Rows[i].Cells[0].Value.ToString();
            txttensh.Text = datagrvTacGia.Rows[i].Cells[1].Value.ToString();
            txtnamxb.Text = datagrvTacGia.Rows[i].Cells[2].Value.ToString();
            txtmanxb.Text = datagrvTacGia.Rows[i].Cells[3].Value.ToString();
            txtmaloai.Text = datagrvTacGia.Rows[i].Cells[4].Value.ToString();
            txtgia.Text = datagrvTacGia.Rows[i].Cells[5].Value.ToString();

        }

        private void Sach_Load(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvTacGia, "select * from SACH");
        }
    }
}
