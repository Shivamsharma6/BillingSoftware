using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace BillingSoftware
{
    public partial class frmMain : Form
    {

        public static class ControlID
        {
            public static string prep { get; set; }
            public static string shop { get; set; }
            public static string acy { get; set; }

            public static string add { get; set; }

            public static string ct { get; set; }

            public static string ucode { get; set; }


        }

        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
        String ck = "dmsc";

        public frmMain()
        {
            InitializeComponent();
            // pbr.Value = 0;

            //user = Nlogin.ControlID.TextData; // delete
            //acyr = frmLogin.ControlID.TextData;
        }

        

        //btn_LogOut Click Event
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            // frmLogin fl = new frmLogin();
            //fl.Show();

            Nlogin n1 = new Nlogin();
            n1.Show();


        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            timer3.Start();           
            timer1.Start();
            timer4.Start();
            // timer5.Start();
            ei.Text = Nlogin.ControlID.TextData;
            label3.Text = Nlogin.ControlID.UserData; // SHOW IN MAIN FORM
                                                     // us.Text = Nlogin.ControlID.UserData;

            //shopnm.Text = frmLogin.ControlID.TextData;
            //shopadd.Text = frmLogin.ControlID.TextData;


            DateTime timeOfDayGreeting = DateTime.Now;

            if (timeOfDayGreeting.Hour >= 5 && timeOfDayGreeting.Hour < 12)
            {
                greetings.Text = "Good Morning !";

            }
            else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 16)
            {
                greetings.Text = "Good Afternoon !";
            }
            else if (timeOfDayGreeting.Hour >= 16 && timeOfDayGreeting.Hour < 20)
            {
                greetings.Text = "Good Evening !";
            }
            else
            {
                greetings.Text = "Good Night!";
            }

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                String sqlquery = "SELECT * FROM tbl_Login WHERE UserID = " + Int64.Parse(ei.Text);
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        // us.Text = (dr["name"].ToString());
                        // shopnm.Text = (dr["comp_name"].ToString());
                        acyr.Text = (dr["ac_yr"].ToString());
                        shopadd.Text = (dr["add"].ToString());
                        city.Text = (dr["city"].ToString());
                        mob.Text = (dr["mobile"].ToString());
                        cst.Text = (dr["cstno"].ToString());
                        lice.Text = (dr["licno"].ToString());
                        spnmb.Text = (dr["comp_name"].ToString());

                        // ControlID.prep = us.Text;
                       // ControlID.shop = shopnm.Text;
                        ControlID.acy = acyr.Text;
                        ControlID.add = shopadd.Text;
                        ControlID.ct = city.Text;

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (System.FormatException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (spnmb.Text != "label9")
            {
                label10.Hide();
            }
        }

        private void EmployeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*EmpInfo ei = new EmpInfo();
            ei.Show();*/
        }

        private void PaySlipCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {
                Message cd = new Message();
                cd.Show();
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Calculator calc = new Calculator();
             calc.Show();*/
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {       
                SALE_BILL sb = new SALE_BILL();
                sb.Show();
            }
        }

        private void paySlipPrintingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /* PSDisplay pSDisplay = new PSDisplay();
             pSDisplay.Show();*/
        }

        private void editPaySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* DialogInput dialogInput = new DialogInput();
             dialogInput.Show(); */
        }

        private void Biodata_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {
                ProductInfo pd = new ProductInfo();
                pd.Show();
            }
        }

        private void lastPaySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*lastPaySlip lastPaySlip = new lastPaySlip();
            lastPaySlip.Show();*/
        }

        private void Centry_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {
                CustomerInfo ci = new CustomerInfo();
                ci.Show();
            }
        }

        int imgcounter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            new_label.ForeColor = Color.FromArgb(A, R, G, B);
            label15.ForeColor = Color.FromArgb(A, R, G, B);
            label10.ForeColor = Color.FromArgb(A, R, G, B);  //BLINKING

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {
                DailyReport dr = new DailyReport();
                dr.Show();
            }
        }

        private void CustomerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {
                CustomerInfo ci = new CustomerInfo();
                ci.Show();
            }
        }

        private void ShopcompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)

            {
                Message ms = new Message();
                ms.Show();
            }
        }

        private void ProductMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {
                ProductInfo pi = new ProductInfo();
                pi.Show();
            }
        }

        private void StockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {
                SALE_BILL sb = new SALE_BILL();
                sb.Show();
            }
        }

        private void EntryMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginCheck() == 1)
            {
                Form1 ms = new Form1();
                ms.Show();
            }
        }

        private void Userinfo_Click(object sender, EventArgs e)
        {
            PasswordProtection pw = new PasswordProtection();
            pw.Show();
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            STOCK uii = new STOCK();
            uii.Show();
        }

        private void stockreport_Click(object sender, EventArgs e)
        {
            STOCK uii = new STOCK();
            uii.Show();
        }


        private void purc_Click(object sender, EventArgs e)
        {
            Purchase ms = new Purchase();
            ms.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase ms = new Purchase();
            ms.Show();
        }

        private void purchaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Purchase ms = new Purchase();
            ms.Show();

        }

        private void salebook_Click(object sender, EventArgs e)
        {
            salebook ms = new salebook();
            ms.Show();
        }

        private void purcbook_Click(object sender, EventArgs e)
        {
            PurchaseBook ms = new PurchaseBook();
            ms.Show();
        }

        private void DeleteFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_database dd = new Delete_database();
            dd.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Thanks");
            Thanks ts = new Thanks();
            ts.Show();

            //Application.Exit();           //exit
            //frmLogin u = new frmLogin();
            this.Hide(); //clear screen
            //u.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Fm = new Form2();
            Fm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Nlogin sf = new Nlogin();
            sf.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nlogin NK = new Nlogin();
            NK.Show();
        }

        public int LoginCheck()
        {
            if (spnmb.Text == "label9")
            {
                this.Hide(); /*LOGIN OPEN ON MAIN PROGRAMM*/
                Nlogin nlogin = new Nlogin();
                nlogin.Show();
                return 0;
            }
            else
            {
                return 1;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Image = imageList1.Images[imgcounter];
            if (imgcounter == imageList1.Images.Count - 1)
            {
                imgcounter = 0;
            }
            else
            {
                imgcounter++;
            }




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void greetings_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            // lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // lblDay.Text = DateTime.Now.ToString("dddd");
            dname.Text = DateTime.Now.ToString("dddd");

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //  pbr.Value += 1;
            // pbr.Text = pbr.Value.ToString() + "%";
            //  if (pbr.Value == 100)
            {
                //    timer5.Enabled = false;
            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            //running message 

            String fl = label16.Text.Substring(0, 1);
            String st = label16.Text.Substring(1, label16.Text.Length - 1);
            string fs = st + fl;
            label16.Text = fs;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            calculator cal = new calculator();
            cal.Show();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
            }
            else
            {
                pictureBox3.Visible = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            New_sale New_sale = new New_sale();
            New_sale.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string f = "E:\\video1.mp4";
            //axWindowsMediaPlayer1.URL = f;
        }
        // private void button5_Click(object sender, EventArgs e)
        //{
        //
        //}
    }
}
