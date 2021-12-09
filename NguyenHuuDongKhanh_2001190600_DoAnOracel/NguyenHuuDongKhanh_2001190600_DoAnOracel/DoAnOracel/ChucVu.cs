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
    public partial class ChucVu : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public ChucVu()
        {
            InitializeComponent();
        }

        private void datagrvChucVU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtmachucvu.Text = datagrvChucVU.Rows[i].Cells[0].Value.ToString();
            txttenchucvu.Text = datagrvChucVU.Rows[i].Cells[1].Value.ToString();
            txtluong.Text = datagrvChucVU.Rows[i].Cells[2].Value.ToString();
           
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvChucVU, "select * from CHUCVU");
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
                if ((string.IsNullOrEmpty(txtmachucvu.Text)) || (string.IsNullOrEmpty(txttenchucvu.Text)) || (string.IsNullOrEmpty(txtluong.Text)))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txttenchucvu.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("ten khong duoc la so", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (!kn.kttrungkhoa(txtmachucvu.Text, "select MACV from CHUCVU"))
                {
                    string Inser = string.Format("INSERT INTO CHUCVU(MACV, TENCHUCVU,LUONGCHUCVU) VALUES('{0}','{1}','{2}')", txtmachucvu.Text, txttenchucvu.Text,txtluong.Text);
                    kn.thucthiketnoi(Inser);
                    kn.loaddatagridview(datagrvChucVU, "select * from CHUCVU");
                }
                else
                {
                    MessageBox.Show("Mã chuc vu   này đã tòn tại bạn có thể thử chuc vu khác ", "Trùng chuc vu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Them thanh cong!!!!!");

            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string Inser = string.Format("update  CHUCVU set TENCHUCVU='{1}',LUONGCHUCVU='{2}' where MACV='{0}'", txtmachucvu.Text, txttenchucvu.Text,txtluong.Text);
                kn.thucthiketnoi(Inser);
                kn.loaddatagridview(datagrvChucVU, "select * from CHUCVU");
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
                string del = "delete from CHUCVU where MACV='" + txtmachucvu.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kn.thucthiketnoi(del);
                    kn.loaddatagridview(datagrvChucVU, "select * from CHUCVU");
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
