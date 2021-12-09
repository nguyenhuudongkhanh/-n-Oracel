using Oracle.ManagedDataAccess.Client;
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
    public partial class ChucNangHeThong : Form
    {
       

    
        KetNoiVoiChucNangHeThong kn= new KetNoiVoiChucNangHeThong();
        public ChucNangHeThong()
        {
            InitializeComponent();
        }

        private void btnSGA_Click(object sender, EventArgs e)
        {

            kn.loaddatagridview(datagrvchucnang, "Select * from v$sga");
           
        }

        private void ChucNangHeThong_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPGA_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "show parameter pga");
        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "Select PID,SOSID,SPID,STID  from v$process");
        }

        private void btninstence_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "select * from v$instance");
        }

        private void btndb_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "select * from v$database");
            
        }

        private void btndatafile_Click(object sender, EventArgs e)
        {
            kn.loaddatagridview(datagrvchucnang, "select * from v$datafile");
        }
    }
}
