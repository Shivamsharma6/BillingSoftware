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
    public partial class DailyReport : Form
    {
        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";

        public DailyReport()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select billno,billdate,c_name,subtot,grandtot,preparedby from salebill where billdate between '" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dailyrepo.DataSource = dt;
                con.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
