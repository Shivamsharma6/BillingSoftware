using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Media;

namespace BillingSoftware
{
    public partial class frmLogin : Form
    {
        public static class ControlID
        {
            public static string TextData { get; set; }
            public static string UserData { get; set; }

            public static string PassData { get; set; }
        }

        public frmLogin()
        {
            InitializeComponent();

        }

        //Connection String
        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";


        //btn_Submit Click event
        int wrongcount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            /*SoundPlayer sp = new SoundPlayer(@"C:\Users\hp\Downloads\ss.wav");
            sp.Play();*/

            customControl11.Visible = true;

            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
               // ControlID.PassData = textBox2.Text;

                ControlID.TextData = txt_UserName.Text;
                ControlID.UserData = textBox1.Text;
                // ControlID.PassData = textBox2.Text;


                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserID=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (wrongcount == 2)
                {
                    Application.Exit();
                }

                if (count == 1)
                {
                    timer4.Start();
                    customControl11.Show();

                }
                else
                { 
                    wrongcount++;
                    err_msg em = new err_msg ();
                    em.Show();
                    //MessageBox.Show("Login Failed !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset_PWD pd = new Reset_PWD();
            pd.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Application.Exit();
            Thanks bye = new Thanks();
            bye.Show();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            customControl11.Visible = false;

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

            timer3.Start();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
         }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm:ss");
            TM.Text = DateTime.Now.ToString("dd MMM yyyy");
            DTDY.Text = DateTime.Now.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            customControl11.Minimum = 0;
            customControl11.Maximum = 100;
            customControl11.Value += 10;
            if (customControl11.Value >= 100)
            {
                timer4.Stop();
                frmMain a = new frmMain();
                this.Hide();
                a.Show();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form1 asdf = new Form1();
            asdf.Show();
        }

        private void txt_UserName_Click(object sender, EventArgs e)
        {
           txt_UserName.Text = String.Empty;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "";
        }

        
    }
}
   


