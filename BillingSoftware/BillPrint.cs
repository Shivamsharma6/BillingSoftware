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
    public partial class BillPrint : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

        public BillPrint()
        {
            InitializeComponent();
            subtotal.Text = SALE_BILL.ControlID.subtotal;
            disc.Text = SALE_BILL.ControlID.discount;
            textBox1.Text = SALE_BILL.ControlID.customer;
            textBox13.Text = SALE_BILL.ControlID.billdate;
            textBox2.Text = DateTime.Now.ToString("HH:mm:ss");
            textBox11.Text = SALE_BILL.ControlID.quantity;

        }
       
        private void BillPrint_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from saleinfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            billdata.DataSource = dt;

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            String sqlquery = "SELECT * FROM salebill";
            SqlCommand cmdd = new SqlCommand(sqlquery, conn);
            SqlDataReader dr = cmdd.ExecuteReader();
            if (dr.Read())
            {

                textBox12.Text = (dr["billno"].ToString());                

            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void Print_Click(object sender, EventArgs e)
        {
            /*  Graphics g = this.CreateGraphics();
              bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
              Graphics mg = Graphics.FromImage(bmp);
              mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
              printPreviewDialog1.Show();*/
            new Reports.Form1().Show();        }
    }
}
