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
    public partial class PasswordProtection : Form
    {
        public PasswordProtection()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(pass.Text == "go")
            {
                Form1 ui = new Form1();
                ui.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
