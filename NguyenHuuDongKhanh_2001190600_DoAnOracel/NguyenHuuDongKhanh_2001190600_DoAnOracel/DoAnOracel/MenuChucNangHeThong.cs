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
    public partial class MenuChucNangHeThong : Form
    {
        public MenuChucNangHeThong()
        {
            InitializeComponent();
        }

        private void chucNangHeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucNangHeThong fdm = new ChucNangHeThong();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNoCancel);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session fdm = new Session();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }
    }
}
