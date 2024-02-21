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
    public partial class Nlogin : Form
    {
        public static class ControlID
        {
            public static string prep { get; set; }
            public static string shop { get; set; }
            public static string acy { get; set; }

            public static string add { get; set; }

            public static string ct { get; set; }

            public static string ucode { get; set; }
            public static string TextData { get; internal set; }
            public static string UserData { get; internal set; }
        }

        string cs = @"Data Source=localhost;Initial Catalog=MyDatabase.mdf;Integrated Security=True";
        String user;

        public Nlogin()
        {
            InitializeComponent();
            pb.Value = 0;
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
           
            
            /*SoundPlayer sp = new SoundPlayer(@"C:\Users\hp\Downloads\ss.wav");
           sp.Play();*/

           // customControl11.Visible = true;

            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                ControlID.TextData = txt_UserName.Text;
                ControlID.UserData = textBox1.Text;

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
                if (count > 0)
                {
                    timer2.Start();
                    timer2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please provide valid credentials!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                label1.Text = DateTime.Now.ToString("dd-MM-yyyy   hh:mm:ss  tt");
            }
        }

        private void Nlogin_Load(object sender, EventArgs e)
        {           

            timer1.Start();
            DateTime timeOfDayGreet = DateTime.Now;

            if (timeOfDayGreet.Hour >= 5 && timeOfDayGreet.Hour < 12)
            {
                Greet.Text = "Good Morning !";

            }
            else if (timeOfDayGreet.Hour >= 12 && timeOfDayGreet.Hour < 16)
            {
                Greet.Text = "Good Afternoon !";
            }
            else if (timeOfDayGreet.Hour >= 16 && timeOfDayGreet.Hour < 20)
            {
                Greet.Text = "Good Evening !";
            }
            else
            {
                Greet.Text = "Good Night!";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pb.Value += 5;
            pb.Text = pb.Value.ToString() + "%";
            if (pb.Value == 05)
            {
                frmMain fm = new frmMain();
                fm.Show();
                this.Close();
                timer2.Enabled = false;                
            }
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

        }
    }
 }
    

