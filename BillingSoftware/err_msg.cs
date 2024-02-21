using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class err_msg : Form
    {
        public err_msg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin Flog = new frmLogin ();
            Flog.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
