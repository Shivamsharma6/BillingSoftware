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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        string saleinfoquant;

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
                //Create sql connection add
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into purchase values('" + code.Text + "','" + email.Text + "','" + add.Text + "','" + name.Text + "','" + mob.Text + "','" + billdate.Text + "','" + pcode.Text + "','" + pname.Text + "','" + rate.Text + "','" + qty.Text + "','" + subttl.Text + "','" + dis.Text + "','" + vat.Text + "','" + gttl.Text + "')";
                cmd.ExecuteNonQuery();

                String sqlquery = "SELECT * FROM saleinfo WHERE pcode =" + Int64.Parse(pcode.Text);
                SqlCommand cmdddd = new SqlCommand(sqlquery, con);
                SqlDataReader dr = cmdddd.ExecuteReader();
                if (dr.Read())
                {
                    saleinfoquant = (dr["quant"].ToString());
                }

                int quant = int.Parse(qty.Text);
                int obb = int.Parse(ob.Text);
                int sale = obb - Convert.ToInt32(saleinfoquant);
                int purchase = obb + quant;
                int bal = obb+ purchase - sale;

                SqlCommand cmdd = con.CreateCommand();
                cmdd.CommandType = CommandType.Text;
                cmdd.CommandText = "Insert into stock values('" + pcode.Text + "','" + pname.Text + "','" + ob.Text + "','" + sale + "','" + purchase + "','" + bal + "','" + billdate.Text + "')";
                cmdd.ExecuteNonQuery();

                SqlCommand cmddd = con.CreateCommand();
                cmddd = new SqlCommand("Update prodinfo SET currbal = currbal+'" + quant + "' where code=" + pcode.Text + "", con);
                cmddd.ExecuteNonQuery();


                MessageBox.Show("Submitted Successfully!");

                //to show data in datagridview
                cmd.CommandText = "select * from purchase";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;// only this line will change before .
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "SELECT * FROM prodinfo WHERE code =" + Int64.Parse(pcode.Text);
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    pname.Text = (dr["name"].ToString());
                    rate.Text = (dr["mrp"].ToString());   
                    ob.Text = (dr["ob"].ToString());
                    currbal.Text = (dr["currbal"].ToString());
                }
            }
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
            //Create sql connection add
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from purchase";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;// only this line will change before .
            con.Close();
        }
    }
}
