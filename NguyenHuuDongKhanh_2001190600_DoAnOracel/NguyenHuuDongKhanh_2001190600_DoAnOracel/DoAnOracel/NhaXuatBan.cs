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
    public partial class NhaXuatBan : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public NhaXuatBan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtma.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtdienthoai.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

        }

        private void NhaXuatBan_Load(object sender, EventArgs e)
        {
            kn.loaddatagridview(dataGridView1, "select * from NHAXUATBAN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtma.Text)) || (string.IsNullOrEmpty(txtten.Text)) || (string.IsNullOrEmpty(txtdiachi.Text)) || (string.IsNullOrEmpty(txtdienthoai.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "err", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else if (!kn.kttrungkhoa(txtma.Text, "select MANXB from NHAXUATBAN"))
            {
                string Inser = string.Format("INSERT INTO NHAXUATBAN(MANXB, TENNXB, DCNXB, DTNXB) VALUES('{0}','{1}','{2}','{3}')", txtma.Text, txtten.Text, txtdiachi.Text, txtdienthoai.Text);
                kn.thucthiketnoi(Inser);
                kn.loaddatagridview(dataGridView1, "select * from NHAXUATBAN");
            }
            else
            {
                MessageBox.Show("Mã nhà xuất bản  này đã tòn tại bạn có thể thử nhà xuất bản  kDTNXBhác", "Trùng nhà xuất bản ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Inser = string.Format("update  NHAXUATBAN set TENNXB='{1}',DCNXB='{2}',DTNXB='{3}' where MANXB='{0}'", txtma.Text, txtten.Text, txtdiachi.Text, txtdienthoai.Text);
                kn.thucthiketnoi(Inser);
                kn.loaddatagridview(dataGridView1, "select * from NHAXUATBAN");
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
                string del = "delete from NHAXUATBAN where MANXB='" + txtma.Text + "'";
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kn.thucthiketnoi(del);
                    kn.loaddatagridview(dataGridView1, "select * from NHAXUATBAN");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNoCancel);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void txtdienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
