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
    public partial class TacGia_Sach : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public TacGia_Sach()
        {
            InitializeComponent();
        }

        private void datagrvTacGia_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtmatg.Text = datagrvTacGia_sach.Rows[i].Cells[0].Value.ToString();
            txtmash.Text = datagrvTacGia_sach.Rows[i].Cells[1].Value.ToString();
            cmbtgchinh.Text = datagrvTacGia_sach.Rows[i].Cells[2].Value.ToString();
          
        }

        private void TacGia_Sach_Load(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvTacGia_sach, "select * from TACGIA_SACH");
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
            try
            {
                if ((string.IsNullOrEmpty(txtmatg.Text)) || (string.IsNullOrEmpty(txtmash.Text)) || (string.IsNullOrEmpty(cmbtgchinh.Text)) )
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else if (!kn.kttrungkhoa(txtmash.Text, "select MASH from TACGIA_SACH"))
                {
                    string Inser = string.Format("INSERT INTO TACGIA_SACH(MATG, MASH, TACGIACHINH) VALUES('{0}','{1}','{2}')", txtmatg.Text,txtmash.Text,cmbtgchinh.Text);
                    kn.thucthiketnoi(Inser);
                    kn.loaddatagridview(datagrvTacGia_sach, "select * from TACGIA_SACH");
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
                string Inser = string.Format("update  TACGIA_SACH set MASH='{1}',TACGIACHINH='{2}' where MATG ='{0}'", txtmatg.Text,txtmash.Text,cmbtgchinh.Text);
                kn.thucthiketnoi(Inser);
                kn.loaddatagridview(datagrvTacGia_sach, "select * from TACGIA_SACH");
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
                string del = "delete from TACGIA_SACH where MATG='" + txtmatg.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kn.thucthiketnoi(del);
                    kn.loaddatagridview(datagrvTacGia_sach, "select * from TACGIA_SACH");
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
    }
}
