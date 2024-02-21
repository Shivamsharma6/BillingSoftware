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
    public partial class Reset_PWD : Form
    {
        public Reset_PWD()
        {
            InitializeComponent();
        }

        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();            
          //  cmd = new SqlCommand("Update tbl_Login SET Password='" + textpass.Text + "',name='" + textuname.Text + "' where UserID=" + uid.Text + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully!");
            this.Hide();
        }

    
    }
}

