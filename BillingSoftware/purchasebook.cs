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
    public partial class PurchaseBook : Form
    {
        readonly string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
        public PurchaseBook()
        {
            InitializeComponent();
        }
        private void PurchaseBook_Load(object sender, EventArgs e)
        {
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            textBox1.AutoCompleteCustomSource = DataCollection;

            purchase_datagrid.Hide();
            textBox1.Text = "";
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
                MessageBox.Show("Can not connect to database!");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DateTime from = from_date.Value;
            DateTime to = to_date.Value;
            string cust_name = textBox1.Text;
            SqlConnection con = new SqlConnection(cs);
            DataTable data = new DataTable();
            string query = "SELECT * FROM [salebill] WHERE CONVERT(datetime, billdate, 103) BETWEEN @startDate-1 AND @endDate";
            string query2 = "SELECT * FROM [salebill] WHERE c_name = @customerName AND CONVERT(datetime, billdate, 103) BETWEEN @startDate-1 AND @endDate";
            if (textBox1.Text == "")
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                    adapt.SelectCommand.Parameters.AddWithValue("@startDate", from);
                    adapt.SelectCommand.Parameters.AddWithValue("@endDate", to);
                    adapt.Fill(data);
                    purchase_datagrid.DataSource = data;
                    con.Close();
                    if(purchase_datagrid.RowCount > 0)
                    {
                        purchase_datagrid.Show();
                        purchase_datagrid.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"No Record exists between '{from}' and '{to}'");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(query2, con);
                    adapt.SelectCommand.Parameters.AddWithValue("@startDate", from);
                    adapt.SelectCommand.Parameters.AddWithValue("@endDate", to);
                    adapt.SelectCommand.Parameters.AddWithValue("@customerName", cust_name);
                    adapt.Fill(data);
                    purchase_datagrid.DataSource = data;
                    con.Close();
                    if (purchase_datagrid.RowCount > 0)
                    {
                        purchase_datagrid.Show();
                        purchase_datagrid.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"No Record exists for '{cust_name}' between '{from}' and '{to}'");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
