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
    public partial class Delete_database : Form
    {
        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
        public Delete_database()
        {
            InitializeComponent();
        }

        private void Delete_database_Load(object sender, EventArgs e)
        {

        }

        private void Dels_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd = new SqlCommand("DELETE FROM salebill");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted");
        }
    }
}
