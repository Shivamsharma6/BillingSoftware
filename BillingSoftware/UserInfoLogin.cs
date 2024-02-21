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
    public partial class UserInfoLogin : Form
    {
        public UserInfoLogin()
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

                //cmd.CommandText = "Insert into tbl_Login values('" + uid.Text + "','" + pwd.Text + "','" + acyr.Text + "','" + name.Text + "','" + addr.Text + "','" + city.Text + "','" + mob.Text + "','" + cstn.Text + "','" + licn.Text + "')";

                //cmd.CommandText = "Insert into tbl_Login values('" + uid.Text + "','" + pwd.Text + "','" + name.Text + "','" + add.Text + "','" + city.Text + "','" + mob.Text + "','" + shopnm.Text + "','" + shopad.Text + "','" + shopad1.Text + "','" + cstn.Text + "','" + licn.Text + "')";


                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");       
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

            search.AutoCompleteMode = AutoCompleteMode.Suggest;
            search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            search.AutoCompleteCustomSource = DataCollection;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}




