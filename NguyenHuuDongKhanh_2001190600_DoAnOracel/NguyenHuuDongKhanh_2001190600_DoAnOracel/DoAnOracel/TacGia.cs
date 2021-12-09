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
    public partial class TacGia : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public TacGia()
        {
            InitializeComponent();
        }

        private void datagrvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtmatg.Text = datagrvTacGia.Rows[i].Cells[0].Value.ToString();
            txttentg.Text = datagrvTacGia.Rows[i].Cells[1].Value.ToString();
            txtbutdanh.Text = datagrvTacGia.Rows[i].Cells[2].Value.ToString();
            txtdiachi.Text = datagrvTacGia.Rows[i].Cells[3].Value.ToString();
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvTacGia, "select * from TACGIA");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtmatg.Text)) || (string.IsNullOrEmpty(txttentg.Text)) || (string.IsNullOrEmpty(txtbutdanh.Text)) || (string.IsNullOrEmpty(txtdiachi.Text)))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else if (!kn.kttrungkhoa(txtmatg.Text, "select MATG from TACGIA"))
                {
                    string Inser = string.Format("INSERT INTO TACGIA(MATG, TENTG, BUTDANH, DIACHI) VALUES('{0}','{1}','{2}','{3}')", txtmatg.Text, txttentg.Text, txtbutdanh.Text, txtdiachi.Text);
                    kn.thucthiketnoi(Inser);
                    kn.loaddatagridview(datagrvTacGia, "select * from TACGIA");
                }
                else
                {
                    MessageBox.Show("Mã tác giả   này đã tòn tại bạn có thể thử tác giả khác ", "Trùngtác giả ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string Inser = string.Format("update  TACGIA set TENTG='{1}',BUTDANH='{2}',DIACHI='{3}' where MATG='{0}'", txtmatg.Text, txttentg.Text, txtbutdanh.Text, txtdiachi.Text);
                kn.thucthiketnoi(Inser);
                kn.loaddatagridview(datagrvTacGia, "select * from TACGIA");
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
                string del = "delete from TACGIA where MATG='" + txtmatg.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kn.thucthiketnoi(del);
                    kn.loaddatagridview(datagrvTacGia, "select * from TACGIA");
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
    }
}
