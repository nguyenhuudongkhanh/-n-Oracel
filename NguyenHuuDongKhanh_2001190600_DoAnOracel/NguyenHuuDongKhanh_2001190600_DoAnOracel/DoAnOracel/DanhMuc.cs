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
    public partial class DanhMuc : Form
    {
        public DanhMuc()
        {
            InitializeComponent();
        }
        public static string quyen;
        private void menuitnxb_Click(object sender, EventArgs e)
        {
            NhaXuatBan fc = new NhaXuatBan();
            panel_show.Show();
            panel_show.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fc);
            fc.Show();
        }

        private void menudangnhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
           
            dn.Show();
       
        }

        private void DanhMuc_Load(object sender, EventArgs e)
        {

            if (quyen == "Admin")
            {
                menuItem2.Enabled = true;
                menuItemchucnang.Enabled = true;
                menuitemnv.Enabled = true;
                menuItemquanly.Enabled = true;
                menuqltkhoang.Enabled = true;
                menuittracuu.Enabled = true;
              
            }
            else if (quyen == "User")
            {
                menuItem2.Enabled = true;
                menuItemchucnang.Enabled = true;
                
            }
            else if (quyen == "User1")
            {
                menuItem2.Enabled = true;
                menuItemchucnang.Enabled = true;
                menuItemquanly.Enabled = true;

            }
           

        }

        private void menuitchuvu_Click(object sender, EventArgs e)
        {
            

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuitnhanvien_Click(object sender, EventArgs e)
        {
           
        }

        private void menuitemtg_Click(object sender, EventArgs e)
        {
            TacGia fdm = new TacGia();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuitsach_Click(object sender, EventArgs e)
        {
            Sach fdm = new Sach();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuittracuu_Click(object sender, EventArgs e)
        {
            TimKiemThongTinNhanVien ftk = new TimKiemThongTinNhanVien();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void traCứuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiemKiemSach ftk = new TiemKiemSach();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void tácGiảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGia_Sach ftk = new TacGia_Sach();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien fdm = new NhanVien();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void MenuItemchucvu_Click(object sender, EventArgs e)
        {
            ChucVu fdm = new ChucVu();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNoCancel);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void menuhoadon_Click(object sender, EventArgs e)
        {
            HoaDon fdm = new HoaDon();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuchitiethoadon_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon fdm = new ChiTietHoaDon();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuItemdmk_Click(object sender, EventArgs e)
        {
            DoiMatKhau fdm = new DoiMatKhau();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuqltkhoang_Click(object sender, EventArgs e)
        {
            QuangLyTK fdm = new QuangLyTK();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }
    }
}
