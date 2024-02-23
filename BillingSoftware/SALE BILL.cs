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
    public partial class SALE_BILL : Form
    {
        public static SALE_BILL instance;
        public TextBox tb1;
        public TextBox tb2;
        public TextBox tb3;
        public TextBox tb4;
        public TextBox tb5;
        public TextBox tb6;
        public TextBox tb7;
        public TextBox tb8;



        public static class ControlID
        {
            public static string subtotal { get; set; }
            public static string discount { get; set; }
            public static string customer { get; set; }
            public static string billdate { get; set; }
            public static string quantity { get; set; }

            public static prodlist instance;
            public static string code = "";
            public static string name = "";
            public static string pack = "";
            public static string expiry = "";
            public static string mrp = "";
            public static string dis = "";
            public static string ob = "";
            public static string curbal = "";
        }

        public SALE_BILL()
        {
            InitializeComponent();
            instance = this;
            tb1 = pname;
            tb2 = pcode;
            tb3 = pk;
            tb4 = mrp;
            tb5 = qty;
            tb6 = exp;
            tb7 = disc;
            tb8 = bal;

            uid.Text = frmLogin.ControlID.TextData;
            pby.Text = frmMain.ControlID.prep;
        }

        int billtotal;
        int grandtotal;
        readonly string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
       
        private void SALE_BILL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MyDatabase_mdfDataSet1.prodinfo' table. You can move, or remove it, as needed.
            this.prodinfoTableAdapter1.Fill(this._MyDatabase_mdfDataSet1.prodinfo);
            // TODO: This line of code loads data into the '_MyDatabase_mdfDataSet.prodinfo' table. You can move, or remove it, as needed.
            this.prodinfoTableAdapter.Fill(this._MyDatabase_mdfDataSet.prodinfo);
            pname.Text = prodlist.name;
            pcode.Text = prodlist.code;
            pk.Text = prodlist.pack;
            exp.Text = prodlist.expiry;
            disc.Text = prodlist.discount;
            bal.Text = prodlist.curbal;


            bildate.Text = DateTime.Now.ToShortTimeString();
            ccode.Text = "";

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            String sqlquery = "SELECT TOP 1 * FROM saleinfo ORDER BY billno DESC";
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string bn = (dr["billno"].ToString());
                int bni = Int32.Parse(bn);
                billno.Text = (bni + 1).ToString();
            }

            dis.Text = "0";
            vat.Text = "0";
            gttl.Text = "0";
            pamnt.Text = "0";
            ramnt.Text = "0";
            subttl.Text = "0";

            cust_name.AutoCompleteMode = AutoCompleteMode.Suggest;
            cust_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getDataa(DataCollection);
            cust_name.AutoCompleteCustomSource = DataCollection;

            pname.AutoCompleteMode = AutoCompleteMode.Suggest;
            pname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollectionn = new AutoCompleteStringCollection();
            getData(DataCollectionn);
            pname.AutoCompleteCustomSource = DataCollectionn;

            this.ActiveControl = cust_name;
            dataGridView1.Hide();
            dataGridView2.Hide();

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

        private void getDataa(AutoCompleteStringCollection dataCollection)
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
            SalesSave();
        }

        public void SalesSave()
        {
            try
            {
                string custcode = ccode.Text;
                string cemail = email.Text;
                string cadd = add.Text;
                string cname = cust_name.Text;
                string cmob = mob.Text;
                string subtotal = subttl.Text;
                string discount = dis.Text;
                string vatp = vat.Text;
                string grandtotal = gttl.Text;
                string preparedby = pby.Text;
                string billdate = bildate.Text;

                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "INSERT into salebill(c_code,c_email,c_add,c_name,c_mob,subtot,discp,vatp,grandtot,preparedby,billdate)values(@ccode,@cemail,@cadd,@cname,@cmob,@subtotal,@discount,@vatp,@grandtotal,@preparedby,@billdate) select @@identity;";
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                cmd.Parameters.AddWithValue("@ccode", custcode);
                cmd.Parameters.AddWithValue("@cemail", cemail);
                cmd.Parameters.AddWithValue("@cadd", cadd);
                cmd.Parameters.AddWithValue("@cname", cname);
                cmd.Parameters.AddWithValue("@cmob", cmob);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.Parameters.AddWithValue("@vatp", vatp);
                cmd.Parameters.AddWithValue("@grandtotal", grandtotal);
                cmd.Parameters.AddWithValue("@preparedby", preparedby);
                cmd.Parameters.AddWithValue("@billdate", billdate);
                int lastid = int.Parse(cmd.ExecuteScalar().ToString());

                string productcode;
                string name;
                string pack;
                string expiry;
                string price;
                string quantity;
                string total;

                for (int row = 0; row < GP1.Rows.Count; row++)
                {
                    productcode = GP1.Rows[row].Cells[1].Value.ToString();
                    name = GP1.Rows[row].Cells[0].Value.ToString();
                    pack = GP1.Rows[row].Cells[1].Value.ToString();
                    expiry = GP1.Rows[row].Cells[1].Value.ToString();
                    price = GP1.Rows[row].Cells[2].Value.ToString();
                    quantity = GP1.Rows[row].Cells[3].Value.ToString();
                    total = GP1.Rows[row].Cells[4].Value.ToString();

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    String sqlqueryy = "INSERT into saleinfo(billno,pcode,pname,pack,expiry,price,quant,tot)values(@billno,@pcode,@pname,@ppack,@ppexpiry,@pprice,@qty,@tot);";
                    SqlCommand cmdd = new SqlCommand(sqlqueryy, con);
                    cmdd.Parameters.AddWithValue("@billno", lastid);
                    cmdd.Parameters.AddWithValue("@pcode", productcode);
                    cmdd.Parameters.AddWithValue("@pname", name);
                    cmdd.Parameters.AddWithValue("@ppack", pack);
                    cmdd.Parameters.AddWithValue("@ppexpiry", expiry);
                    cmdd.Parameters.AddWithValue("@pprice", price);
                    cmdd.Parameters.AddWithValue("@qty", quantity);
                    cmdd.Parameters.AddWithValue("@tot", total);
                    cmdd.ExecuteNonQuery();
                }

                MessageBox.Show("Saved");
                this.Hide();
                Print p = new Print();
                p.Salesid = lastid;
                p.Show();
                SALE_BILL sb = new SALE_BILL();
                sb.Show();
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
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "SELECT * FROM prodinfo WHERE code =" + Int64.Parse(pcode.Text);
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    pname.Text = (dr["name"].ToString());
                    mrp.Text = (dr["mrp"].ToString());
                    bal.Text = (dr["currbal"].ToString());
                    pk.Text = (dr["pack"].ToString());
                    exp.Text = (dr["expiry"].ToString());
                    disc.Text = (dr["discount"].ToString());
                }
            }
        }

        private void GP1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == GP1.Columns["delete"].Index && e.RowIndex >= 0)
                {
                    GP1.Rows.Remove(GP1.Rows[e.RowIndex]);
                    int sum = 0;
                    for (int row = 0; row < GP1.Rows.Count; row++)
                    {
                        sum = sum + Convert.ToInt32(GP1.Rows[row].Cells[4].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "SELECT * FROM prodinfo WHERE name =@prodname";
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                cmd.Parameters.AddWithValue("@prodname", pname.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pcode.Text = (dr["code"].ToString());
                    mrp.Text = (dr["mrp"].ToString());
                    bal.Text = (dr["currbal"].ToString());
                    disc.Text = (dr["discount"].ToString());
                    pk.Text = (dr["pack"].ToString());
                    exp.Text = (dr["expiry"].ToString());
                }
            }
        }

        private void ccode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(cs);
                    conn.Open();
                    String sqlquery = "SELECT * FROM custinfo WHERE code =" + Int64.Parse(ccode.Text);
                    SqlCommand cmd = new SqlCommand(sqlquery, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        email.Text = (dr["email"].ToString());
                        add.Text = (dr["address"].ToString());
                        cust_name.Text = (dr["name"].ToString());
                        mob.Text = (dr["mobile"].ToString());
                        ControlID.customer = cust_name.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                bildate.Focus();
                e.Handled = true;
            }
        }

        private void dis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int disc = Convert.ToInt32(dis.Text);
                billtotal = Convert.ToInt32(subttl.Text);
                billtotal = billtotal - (billtotal * disc / 100);
                subttl.Text = billtotal.ToString();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void vat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int disc = Convert.ToInt32(vat.Text);
                billtotal = Convert.ToInt32(subttl.Text);
                billtotal = billtotal - (billtotal * disc / 100);
                subttl.Text = billtotal.ToString();
                gttl.Text = billtotal.ToString();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pamnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int paid = Convert.ToInt32(pamnt.Text);
                grandtotal = Convert.ToInt32(gttl.Text);
                paid = paid - grandtotal;
                ramnt.Text = paid.ToString();
                billttl.Text = grandtotal.ToString();
            }
        }

        private void subttl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string custcode = ccode.Text;
                string cemail = email.Text;
                string cadd = add.Text;
                string cname = cust_name.Text;
                string cmob = mob.Text;
                string subtotal = subttl.Text;
                string discount = dis.Text;
                string vatp = vat.Text;
                string grandtotal = gttl.Text;
                string preparedby = pby.Text;
                string billdate = bildate.Text;

                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                String sqlquery = "INSERT into salebill(c_code,c_email,c_add,c_name,c_mob,subtot,discp,vatp,grandtot,preparedby,billdate)values(@ccode,@cemail,@cadd,@cname,@cmob,@subtotal,@discount,@vatp,@grandtotal,@preparedby,@billdate) select @@identity;";
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                cmd.Parameters.AddWithValue("@ccode", custcode);
                cmd.Parameters.AddWithValue("@cemail", cemail);
                cmd.Parameters.AddWithValue("@cadd", cadd);
                cmd.Parameters.AddWithValue("@cname", cname);
                cmd.Parameters.AddWithValue("@cmob", cmob);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.Parameters.AddWithValue("@vatp", vatp);
                cmd.Parameters.AddWithValue("@grandtotal", grandtotal);
                cmd.Parameters.AddWithValue("@preparedby", preparedby);
                cmd.Parameters.AddWithValue("@billdate", billdate);
                int lastid = int.Parse(cmd.ExecuteScalar().ToString());

                string productcode;
                string name;
                string pack;
                string expiry;
                string price;
                string quantity;
                string total;

                for (int row = 0; row < GP1.Rows.Count; row++)
                {
                    productcode = GP1.Rows[row].Cells[1].Value.ToString();
                    name = GP1.Rows[row].Cells[0].Value.ToString();
                    pack = GP1.Rows[row].Cells[3].Value.ToString();
                    expiry = GP1.Rows[row].Cells[2].Value.ToString();
                    price = GP1.Rows[row].Cells[4].Value.ToString();
                    quantity = GP1.Rows[row].Cells[5].Value.ToString();
                    total = GP1.Rows[row].Cells[8].Value.ToString();

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    String sqlqueryy = "INSERT into saleinfo(billno,pcode,pname,pack,expiry,price,quant,tot)values(@billno,@pcode,@pname,@ppack,@ppexpiry,@pprice,@qty,@tot);";
                    SqlCommand cmdd = new SqlCommand(sqlqueryy, con);
                    cmdd.Parameters.AddWithValue("@billno", lastid);
                    cmdd.Parameters.AddWithValue("@pcode", productcode);
                    cmdd.Parameters.AddWithValue("@pname", name);
                    cmdd.Parameters.AddWithValue("@ppack", pack);
                    cmdd.Parameters.AddWithValue("@ppexpiry", expiry);
                    cmdd.Parameters.AddWithValue("@pprice", price);
                    cmdd.Parameters.AddWithValue("@qty", quantity);
                    cmdd.Parameters.AddWithValue("@tot", total);
                    cmdd.ExecuteNonQuery();
                }
                MessageBox.Show("Saved");
                this.Hide();
                this.Controls.Clear();
                this.InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GP1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GP1.Columns[0].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void uid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pby_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void gttl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ramnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void bildate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pname.Focus();
                e.Handled = true;
            }
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (qty.Text == "")
                {
                    MessageBox.Show("Please Input Quantity");
                }
                try
                {
                    // data base = text box name
                    string prodcode = pcode.Text;
                    string prodname = pname.Text;
                    string pack = pk.Text;
                    string expiry = exp.Text;
                    string dis = disc.Text;

                    int price = int.Parse(mrp.Text);
                    int quantity = int.Parse(qty.Text);
                    int diss = int.Parse(disc.Text);

                    int amt = price * quantity;
                    int tot = amt - (amt * diss / 100);
                    this.GP1.Rows.Add(prodname, prodcode, expiry, pack, price, quantity, amt, dis, tot);  // show in data grid view

                    int sum = 0;
                    for (int row = 0; row < GP1.Rows.Count; row++)
                    {
                        sum = sum + Convert.ToInt32(GP1.Rows[row].Cells[8].Value);
                    }
                    subttl.Text = sum.ToString();
                    clear_form();
                    qty.Clear();
                    this.ActiveControl = pname;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void pname_Click(object sender, EventArgs e)
        {
            prodlist prodview = new prodlist();
            prodview.Show();

        }

        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        int _selectedRowIndexCust = -1;
        private void cust_name_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Perform the same actions as in the TextChanged event handler
                    try
                    {
                        con = new SqlConnection(cs);
                        con.Open();
                        adapt = new SqlDataAdapter("select * from custinfo where name like '" + cust_name.Text + "%'", con);
                        dt = new DataTable();
                        adapt.Fill(dt);
                        dataGridView2.DataSource = dt;
                        con.Close();
                        dataGridView2.Show();

                        _selectedRowIndexCust = 0; // Set initial selected row to the first row
                        dataGridView2.Focus();
                        dataGridView2.CurrentCell = dataGridView1.Rows[_selectedRowIndexCust].Cells[0]; // Focus on the first cell
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Prevent default navigation

                int newRowIndex = _selectedRowIndexCust;
                if (e.KeyCode == Keys.Up)
                {
                    newRowIndex--;
                    if (newRowIndex < 0) newRowIndex = 0;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    newRowIndex++;
                    if (newRowIndex >= dataGridView2.Rows.Count) newRowIndex = dataGridView2.Rows.Count - 1;
                }

                _selectedRowIndexCust = newRowIndex;
                dataGridView2.CurrentCell = dataGridView2.Rows[_selectedRowIndexCust].Cells[0];
            }
            else if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[_selectedRowIndexCust];
                ccode.Text = selectedRow.Cells[0].Value.ToString();
                cust_name.Text = selectedRow.Cells[1].Value.ToString();
                add.Text = selectedRow.Cells[2].Value.ToString();
                mob.Text = selectedRow.Cells[4].Value.ToString();
                email.Text = selectedRow.Cells[5].Value.ToString();

                dataGridView2.Hide();
                this.ActiveControl = pname;
            }
        }

        int _selectedRowIndex = -1;
        private void pname_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Perform the same actions as in the TextChanged event handler
                try
                {
                    con = new SqlConnection(cs);
                    con.Open();
                    adapt = new SqlDataAdapter("select * from prodinfo where name like '" + pname.Text + "%'", con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    dataGridView1.Show();

                    _selectedRowIndex = 0; // Set initial selected row to the first row
                    dataGridView1.Focus();
                    dataGridView1.CurrentCell = dataGridView1.Rows[_selectedRowIndex].Cells[0]; // Focus on the first cell
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (GP1.Rows.Count > 0)
                {
                    ActiveControl = subttl;
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Prevent default navigation

                int newRowIndex = _selectedRowIndex;
                if (e.KeyCode == Keys.Up)
                {
                    newRowIndex--;
                    if (newRowIndex < 0) newRowIndex = 0;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    newRowIndex++;
                    if (newRowIndex >= dataGridView1.Rows.Count) newRowIndex = dataGridView1.Rows.Count - 1;
                }

                _selectedRowIndex = newRowIndex;
                dataGridView1.CurrentCell = dataGridView1.Rows[_selectedRowIndex].Cells[0];
            }
            else if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[_selectedRowIndex];
                pcode.Text = selectedRow.Cells[0].Value.ToString();
                pname.Text = selectedRow.Cells[1].Value.ToString();
                pk.Text = selectedRow.Cells[2].Value.ToString();
                exp.Text = selectedRow.Cells[3].Value.ToString();
                mrp.Text = selectedRow.Cells[4].Value.ToString();
                disc.Text = selectedRow.Cells[5].Value.ToString();
                bal.Text = selectedRow.Cells[6].Value.ToString();
                dataGridView1.Hide();
                this.ActiveControl = qty;
            }
        }

        public void clear_form()
        {
            pname.Clear();
            pcode.Clear();
            pk.Clear();
            exp.Clear();
            mrp.Clear();
            disc.Clear();
            bal.Clear();
        }
    }
}
    

   