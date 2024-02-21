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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit() ;
            frmMain fm = new frmMain();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SALE_BILL SB = new SALE_BILL();
            SB.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
