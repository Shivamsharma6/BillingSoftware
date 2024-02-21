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
    public partial class purchase_inv : Form
    {
        public purchase_inv()
        {
            InitializeComponent();
        }

        private void purchase_inv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MyDatabase_mdfDataSet4.purch_entry' table. You can move, or remove it, as needed.
            this.purch_entryTableAdapter.Fill(this._MyDatabase_mdfDataSet4.purch_entry);
            // TODO: This line of code loads data into the '_MyDatabase_mdfDataSet2.purchase' table. You can move, or remove it, as needed.
            //this.purchaseTableAdapter.Fill(this._MyDatabase_mdfDataSet2.purchase);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
