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
    public partial class prodlist : Form
    {
        public static prodlist instance;
        public static string code = "";
        public static string name = "";
        public static string pack = "";
        public static string expiry = "";
        public static string mrp = "";
        public static string discount = "";
        public static string ob = "";
        public static string curbal = "";


        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public prodlist()
        {
            InitializeComponent();
            instance = this;
        }

        private void prodlist_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from prodinfo", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            // TODO: This line of code loads data into the '_MyDatabase_mdfDataSet1.prodinfo' table. You can move, or remove it, as needed.
            //this.prodinfoTableAdapter.Fill(this._MyDatabase_mdfDataSet1.prodinfo);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from prodinfo where name like '" + txtSearch.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                textBox1.Text = selectedRow.Cells[0].Value.ToString();
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
                textBox3.Text = selectedRow.Cells[2].Value.ToString();
                textBox4.Text = selectedRow.Cells[3].Value.ToString();
                textBox5.Text = selectedRow.Cells[4].Value.ToString();
                textBox6.Text = selectedRow.Cells[5].Value.ToString();
                textBox7.Text = selectedRow.Cells[6].Value.ToString();
                textBox8.Text = selectedRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            code = textBox1.Text;
            name = textBox2.Text;
            pack = textBox3.Text;
            expiry = textBox4.Text;
            mrp = textBox5.Text;
            discount = textBox6.Text;
            ob = textBox7.Text;
            curbal = textBox8.Text;

            SALE_BILL.instance.tb1.Text = name;
            SALE_BILL.instance.tb2.Text = code;
            SALE_BILL.instance.tb3.Text = pack;
            SALE_BILL.instance.tb4.Text = mrp;
            SALE_BILL.instance.tb6.Text = expiry;
            SALE_BILL.instance.tb7.Text = discount;
            SALE_BILL.instance.tb8.Text = curbal;
        }
    }
}
