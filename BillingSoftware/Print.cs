using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private int salesid;

        public int Salesid
        {
            get { return salesid; }
            set { salesid = value; }
        }

        private void Print_Load(object sender, EventArgs e)
        {
            try 
            {
                SqlConnection con = new SqlConnection (@"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True");
                SqlCommand cmd;
                SqlCommand cmd1;
                SqlDataAdapter dr;                
                con.Open();

                DataTable dt = new DataTable();
                cmd = new SqlCommand("select * from salebill where billno = '" + Salesid + "'", con);
                dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);

                DataTable dt1 = new DataTable();
                cmd1 = new SqlCommand("select * from saleinfo where billno = '" + Salesid + "'", con);
                dr = new SqlDataAdapter(cmd1);
                dr.Fill(dt1);
                con.Close();

                CrystalReport1 cr = new CrystalReport1();
                cr.Database.Tables["salebill"].SetDataSource(dt);
                cr.Database.Tables["saleinfo"].SetDataSource(dt1);
                this.crystalReportViewer1.ReportSource = cr;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            /*cr.PrintToPrinter(1, false, 0, 0);*/
            this.reportViewer1.RefreshReport();
        }
    }

}
