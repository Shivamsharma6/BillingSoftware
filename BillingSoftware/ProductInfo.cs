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
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {              
                //Create sql connection add
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Insert into prodinfo values('" + code.Text + "','" + prodname.Text + "','" + pack.Text + "','" + expiry.Text + "','" + mrp.Text + "','" + disc.Text + "','" + ob.Text + "','" + curbal.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");

                //****************************************to show data in datagridview
                cmd.CommandText = "select * from prodinfo";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                prodtinfo.DataSource = dt;// only this line will change before .
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";


        private void ProductInfo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from prodinfo order by name";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            prodtinfo.DataSource = dt;
            con.Close();

            /*SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand com = new SqlCommand("select count(code) from prodinfo", conn);
            object count = com.ExecuteScalar();
            if (count != null) trec.Text = count.ToString();
*/
            prodname.AutoCompleteMode = AutoCompleteMode.Suggest;
            prodname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            prodname.AutoCompleteCustomSource = DataCollection;
/*
            productname.AutoCompleteMode = AutoCompleteMode.Suggest;
            productname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollectionn = new AutoCompleteStringCollection();
            getDataa(DataCollectionn);
            productname.AutoCompleteCustomSource = DataCollectionn;*/
        }

        private void getData(AutoCompleteStringCollection dataCollection)
        {            
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();            
            string sql = "SELECT DISTINCT [name] FROM [prodinfo]";
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
/*
        private void getDataa(AutoCompleteStringCollection dataCollection)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "SELECT DISTINCT [name] FROM [prodinfo]";
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
        }*/

        private void update_Click(object sender, EventArgs e)
        {
            try
            {              
                String upd = prodtinfo.CurrentRow.Cells[0].Value.ToString();
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd = new SqlCommand("Update prodinfo SET name='" + prodname.Text + "',pack='" + pack.Text + "' ,expiry='" + expiry.Text + "',mrp='" + mrp.Text + "', discount='" + disc.Text + "',ob ='" + curbal.Text + "', currbal='" +ob.Text+"' where code=" + code.Text + "", con);                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

                cmd.CommandText = "select * from prodinfo";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                prodtinfo.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            String del = prodtinfo.CurrentRow.Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd = new SqlCommand("DELETE FROM prodinfo WHERE code = '" + del + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted");

            cmd.CommandText = "select * from prodinfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            prodtinfo.DataSource = dt;
            con.Close();
        }

        private void code_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyChar == 13)
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "SELECT * FROM prodinfo WHERE code =" + Int64.Parse(code.Text);
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    prodname.Text = (dr["name"].ToString());
                    pack.Text = (dr["pack"].ToString());
                    expiry.Text = (dr["expiry"].ToString());
                    mrp.Text = (dr["mrp"].ToString());
                    disc.Text = (dr["discount"].ToString());
                    ob.Text = (dr["ob"].ToString());
                    curbal.Text = (dr["currbal"].ToString());
                }
            }
        }

        // PRODUCT HELP
        private void prodname_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Return)
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "SELECT * FROM prodinfo WHERE name =@prodname";
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                cmd.Parameters.AddWithValue("@prodname", prodname.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code.Text = (dr["code"].ToString());
                    pack.Text = (dr["pack"].ToString());
                    expiry.Text = (dr["expiry"].ToString());
                    mrp.Text = (dr["mrp"].ToString());
                    disc.Text = (dr["discount"].ToString());
                    ob.Text = (dr["ob"].ToString());
                    curbal.Text = (dr["currbal"].ToString());
                    
                }
            }
        }

        private void productname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "SELECT * FROM prodinfo WHERE name =@productname";
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                //cmd.Parameters.AddWithValue("@productname", productname.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code.Text = (dr["code"].ToString());
                    prodname.Text = (dr["pname"].ToString());
                    pack.Text = (dr["pack"].ToString());
                    expiry.Text = (dr["expiry"].ToString());
                    mrp.Text = (dr["mrp"].ToString());
                    disc.Text = (dr["discount"].ToString());
                    ob.Text = (dr["ob"].ToString());
                    curbal.Text = (dr["currbal"].ToString());
                }
            }
        }

        private void ext_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LIST_BTN_Click(object sender, EventArgs e)
        {
           prodlist prodview = new prodlist ();
           prodview.Show();
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pack_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void mrp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
    }

