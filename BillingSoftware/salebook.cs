using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class salebook : Form
    {
        public salebook()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * from salebill where billno ='" + Int64.Parse(pcode.Text) + "' AND  billdate between '" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "'";
                //cmd.CommandText = "select * from saleinfo where billno = " + Int64.Parse(pcode.Text);
                cmd.CommandText = "select billno,billdate,c_name,subtot,grandtot FROM salebill" +
                    " FULL OUTER JOIN saleinfo " +
                   "ON salebill.billno = saleinfo.billno where billno = " + Int64.Parse(pcode.Text); //;
                
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}


