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
    public partial class QuangLyTK : Form
    {
        KetNoiOracel kn = new KetNoiOracel();
        public QuangLyTK()
        {
            InitializeComponent();
        }

        private void QuangLyTK_Load(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvNhanVien, "select TENNV,TenDangNhap,MatKhau,Quyen from NHANVIEN");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
