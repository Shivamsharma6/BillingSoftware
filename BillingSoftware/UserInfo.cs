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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addsv_Click(object sender, EventArgs e)
        {
            try
            {
                //Create sql connection add
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Insert into tbl_Login values('" +  uid.Text + "','" + pwd.Text + "','" + acyr.Text + "','" + name.Text + "','" + addr.Text + "','" + city.Text + "','"+  mob.Text +"','"+  cstn.Text + "','"+ licn.Text + "')";
                            
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");

                //to show data in datagridview
                cmd.CommandText = "select * from tbl_Login";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                userinfo.DataSource = dt;// only this line will change before .
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r1 = new Random();
            int number = r1.Next(1000, 100000);
            uid.Text = number.ToString();

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_Login";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            userinfo.DataSource = dt;// only this line will change before .
            con.Close();

           // search.AutoCompleteMode = AutoCompleteMode.Suggest;
            //search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            //search.AutoCompleteCustomSource = DataCollection;

            //compnm.Text = frmLogin.ControlID.TextData;

            label10.Text = frmMain.ControlID.shop; // SHOW IN MAIN FORM
            label7.Text = frmMain.ControlID.acy;
            label8.Text = frmMain.ControlID.add;
            label13.Text = frmMain.ControlID.ct;
            label14.Text = frmMain.ControlID.ucode;

        }

        private void getData(AutoCompleteStringCollection dataCollection)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT [UserID] FROM [tbl_login]";
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

        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                String del = userinfo.CurrentRow.Cells[0].Value.ToString();
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd = new SqlCommand("DELETE FROM tbl_Login WHERE UserID = '" + del + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");

                cmd.CommandText = "select * from tbl_Login";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);            
                userinfo.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                String upd = userinfo.CurrentRow.Cells[0].Value.ToString();
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd = new SqlCommand("Update tbl_Login SET Password='"+ pwd.Text + "', ac_yr='" + acyr.Text + "',comp_name='" + name.Text + "', [add]='" + addr.Text +"', city='" + city.Text + "', mobile='" + mob.Text + "', cstno= '" + cstn.Text + "', licno='" +licn.Text +  "' where UserID=" + uid.Text + "", con);

               


                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

                cmd.CommandText = "select * from tbl_login";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                userinfo.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                 SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "SELECT * FROM tbl_Login WHERE UserID =" + Int64.Parse(uid.Text);
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                { 
                  //name.Text = (dr["name"].ToString());
                    pwd.Text = (dr["password"].ToString());
                    acyr.Text = (dr["ac_yr"].ToString());
                    name.Text = (dr["comp_name"].ToString());
                    addr.Text = (dr["add"].ToString());
                    city.Text = (dr["city"].ToString());
                    mob.Text = (dr["mobile"].ToString());
                    cstn.Text = (dr["cstno"].ToString());
                    licn.Text = (dr["licno"].ToString());

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}




