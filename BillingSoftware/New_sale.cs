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
    public partial class New_sale : Form
    {
        public New_sale()
        {
            InitializeComponent();

        }

        string connectionstring = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    
            if(dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult result = MessageBox.Show("Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(row);
                }
            }
        }      




        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int pcode = Convert.ToInt32(dataGridView1.CurrentRow.Cells["name"].Value); //Code
                SqlConnection conn = new SqlConnection(connectionstring); 
                conn.Open();
                string sql = "SELECT * FROM prodinfo WHERE pn=@name"; // code-@pcode
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", pcode);  //@pcode
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //dataGridView1.CurrentRow.Cells["Code"].Value = dt.Rows[0]["Code"];
                    dataGridView1.CurrentRow.Cells["pn"].Value = dt.Rows[0]["name"];                    
                    dataGridView1.CurrentRow.Cells["pk"].Value = dt.Rows[0]["pack"];                    
                    dataGridView1.CurrentRow.Cells["exp"].Value = dt.Rows[0]["expiry"];
                    dataGridView1.CurrentRow.Cells["mrp"].Value = dt.Rows[0]["mrp"];
                    int price = Convert.ToInt32(dataGridView1.CurrentRow.Cells["mrp"].Value);
                    int quant = Convert.ToInt32(dataGridView1.CurrentRow.Cells["qty"].Value);
                    dataGridView1.CurrentRow.Cells["amt"].Value = price * quant;
                    dataGridView1.Columns["amt"].DefaultCellStyle.BackColor = Color.PaleGreen;


                }
                else
                {
                    MessageBox.Show("Product Not Found", "Message");
                    dataGridView1.CurrentRow.Cells["Pn"].Value = string.Empty;
                    dataGridView1.CurrentRow.Cells["Pk"].Value = string.Empty;
                    dataGridView1.CurrentRow.Cells["exp"].Value = string.Empty;
                    dataGridView1.CurrentRow.Cells["mrp"].Value = string.Empty;
                    dataGridView1.CurrentRow.Cells["qty"].Value = string.Empty;
                    dataGridView1.CurrentRow.Cells["amt"].Value = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        
        }
    }
}


