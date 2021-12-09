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
    public partial class Session : Form
    {
        KetNoiVoiChucNangHeThong kn = new KetNoiVoiChucNangHeThong();
        public Session()
        {
            InitializeComponent();
        }

        private void btncounss_Click(object sender, EventArgs e)
        {
            kn.loadtextbox(txtss, "Select count(*) from v$session");
        }

        private void btnxemthongtin_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "Select sid,serial#,username, program from v$session where type!='BACKGROUND'");
        }

        private void btnxemcacprocessungvoisession_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "select s.sid,p.spid, s.serial#,s.username, s.program from v$session s, v$process p where p.addr=s.paddr and s.type!='BACKGROUND'");
        }

        private void btnXemtấtcảusercủadb_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "select username from dba_users");
        }

        private void btntentablespace_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "select * from dba_tablespaces");
        }

        private void btntaotablespace_Click(object sender, EventArgs e)
        {
            try
            {
                string create = "create tablespace DongKhanh datafile'E:/khanh01.bdf' size 10m ";
                kn.loadtextbox(txtss, create);
                MessageBox.Show("Tao Thanh cong!!");
            }
            catch {
                MessageBox.Show("Ten table da ton tai");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string create = "alter tablespace DongKhanh add datafile'E:/khanh02.bdf' size 100m ";
                kn.loadtextbox(txtss, create);
                MessageBox.Show("Them Thanh cong!!");
            }
            catch
            {
                MessageBox.Show("That Bai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "select file_name,file_id,tablespace_name from dba_data_files where tablespace_name='DONGKHANH' ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "Select * from dba_audit_policies");
        } 
    }
}
