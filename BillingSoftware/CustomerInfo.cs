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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                String upd = custinfo.CurrentRow.Cells[0].Value.ToString();
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd = new SqlCommand("Update custinfo SET code='" + code.Text + "',name='" + custname.Text + "' ,address='" + add.Text + "',city='" + city.Text + "', mobile='" + mob.Text + "',email='" + email.Text + "' where code=" + code.Text + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

                cmd.CommandText = "select * fromcustinfo";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                custinfo.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";



        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Create sql connection add
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Insert into custinfo values('" + code.Text + "','" + custname.Text + "','" + add.Text + "','" + city.Text + "','" + mob.Text + "','" + email.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");

                //to show data in datagridview
                cmd.CommandText = "select * from custinfo";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                custinfo.DataSource = dt;// only this line will change before .
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            String del = custinfo.CurrentRow.Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd = new SqlCommand("DELETE FROM custinfo WHERE code = '" + del + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted");

            cmd.CommandText = "select * from custinfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            custinfo.DataSource = dt;
            con.Close();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from custinfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            custinfo.DataSource = dt;
            con.Close();

            custname.AutoCompleteMode = AutoCompleteMode.Suggest;
            custname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            custname.AutoCompleteCustomSource = DataCollection;
        }

        private void getData(AutoCompleteStringCollection dataCollection)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT [name] FROM [custinfo]";
            connection = new SqlConnection(cs);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not connect to database! ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "SELECT * FROM custinfo WHERE code =" + Int64.Parse(code.Text);
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    code.Text = (dr["code"].ToString());
                    custname.Text = (dr["name"].ToString());
                    add.Text = (dr["address"].ToString());
                    city.Text = (dr["city"].ToString());
                    mob.Text = (dr["mobile"].ToString());
                    email.Text = (dr["email"].ToString());
                   
                }
            }
        }
    }
}


