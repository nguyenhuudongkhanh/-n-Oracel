﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOracel
{
    class KetNoiOracel
    {
        static string host = "localhost";
        static int port = 1521;
        static string sid = "orcl1";
        static string user = "KhanhNguyen";
        static string password = "123";
      

        private string strconnect = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;

        OracleConnection sqlcon;
        OracleCommand sqlcom;
        OracleDataAdapter sqlda;
        OracleDataReader sqldr;
        DataSet ds = new DataSet();
        void ketnoi()
        {
            sqlcon = new OracleConnection(strconnect);
            sqlcon.Open();
        }

        void ngatketnoi()
        {
            sqlcon.Close();
        }

        public void thucthiketnoi(string strsql)
        {
            ketnoi();
            sqlcom = new OracleCommand(strsql, sqlcon);
            sqlcom.ExecuteNonQuery();
            ngatketnoi();

        }

        public void loaddatagridview(DataGridView dg, string strselect)
        {
            ds.Clear();
            sqlda = new OracleDataAdapter(strselect, strconnect);
            sqlda.Fill(ds, "tenbang");
            dg.DataSource = ds.Tables[0];
        }

        public void loaddatagridview1(DataGridView dg, DataSet ds1, string strselect)
        {
            ds1.Clear();
            sqlda = new OracleDataAdapter(strselect, strconnect);
            sqlda.Fill(ds1, "tenbang");
            dg.DataSource = ds1.Tables[0];
        }

        public void loadcombobox(ComboBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new OracleCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            ngatketnoi();
        }

        public void loadtextbox(TextBox cb, string strselect)
        {
            ketnoi();
            sqlcom = new OracleCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[0].ToString();
            }
            ngatketnoi();
        }

        public void loaddatetime(DateTimePicker cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new OracleCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            ngatketnoi();
        }

        public void loadtextboxchiso(TextBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new OracleCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            ngatketnoi();
        }

        public string getdata(string dauvao, string strsql)
        {
            string strketqua = "";
            ketnoi();
            sqlcom = new OracleCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    strketqua = sqldr[1].ToString();
            }
            ngatketnoi();
            return strketqua;
        }

        public bool kt(string dauvao, string strsql, byte chiso)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new OracleCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[chiso].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            ngatketnoi();
            return ok;
        }

        public string thu(string dauvao, string strsql)
        {
            string strketqua = "";
            ketnoi();
            sqlcom = new OracleCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    strketqua = sqldr[0].ToString();
            }
            ngatketnoi();
            return strketqua;
        }

        public bool kttrungkhoa(string dauvao, string strsql)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new OracleCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            ngatketnoi();
            return ok;
        }

        public void loatextbox(TextBox tb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new OracleCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                tb.Lines[0] = (sqldr[chiso].ToString());
            }
            ngatketnoi();
        }
    }
}
