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
	public partial class STOCK : Form
	{
		public STOCK()
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
                cmd.CommandText = "select * from stock where pcode ='" + Int64.Parse(pcode.Text) + "' AND  billdate between '" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "'";
                
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void STOCK_Load(object sender, EventArgs e)
        {

        }
    }
}
