
namespace BillingSoftware
{
    partial class Nlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nlogin));
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.greetings = new System.Windows.Forms.Label();
            this.Greet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb = new CircularProgressBar.CircularProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(183, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 78;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(83, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 1);
            this.panel4.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(81, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 1);
            this.panel3.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(83, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 1);
            this.panel2.TabIndex = 69;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Submit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Submit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Submit.Location = new System.Drawing.Point(81, 221);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(95, 43);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Login";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_UserName.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.Cyan;
            this.txt_UserName.Location = new System.Drawing.Point(81, 83);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(210, 24);
            this.txt_UserName.TabIndex = 2;
            this.txt_UserName.Text = "Select Company";
            this.txt_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UserName_KeyPress);
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Password.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Book Antiqua", 15.75F);
            this.txt_Password.ForeColor = System.Drawing.Color.Cyan;
            this.txt_Password.Location = new System.Drawing.Point(81, 123);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.Size = new System.Drawing.Size(210, 27);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Italic);
            this.textBox1.ForeColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(83, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "User Name";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(82, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 36);
            this.label6.TabIndex = 71;
            this.label6.Text = "            Developed  By : \r\nDiya Software Private Limited\r\n";
            // 
            // greetings
            // 
            this.greetings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.greetings.AutoSize = true;
            this.greetings.BackColor = System.Drawing.Color.Transparent;
            this.greetings.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Bold);
            this.greetings.ForeColor = System.Drawing.Color.DarkBlue;
            this.greetings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.greetings.Location = new System.Drawing.Point(156, -62);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(79, 38);
            this.greetings.TabIndex = 70;
            this.greetings.Text = "label6";
            // 
            // Greet
            // 
            this.Greet.AutoSize = true;
            this.Greet.BackColor = System.Drawing.Color.Transparent;
            this.Greet.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greet.ForeColor = System.Drawing.Color.Navy;
            this.Greet.Location = new System.Drawing.Point(100, 49);
            this.Greet.Name = "Greet";
            this.Greet.Size = new System.Drawing.Size(76, 30);
            this.Greet.TabIndex = 81;
            this.Greet.Text = "label1";
            // 
            // pb
            // 
            this.pb.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pb.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pb.AnimationSpeed = 0;
            this.pb.BackColor = System.Drawing.Color.Transparent;
            this.pb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb.ForeColor = System.Drawing.Color.White;
            this.pb.InnerColor = System.Drawing.Color.PaleTurquoise;
            this.pb.InnerMargin = 2;
            this.pb.InnerWidth = 10;
            this.pb.Location = new System.Drawing.Point(160, 347);
            this.pb.MarqueeAnimationSpeed = 2000;
            this.pb.Name = "pb";
            this.pb.OuterColor = System.Drawing.Color.Gold;
            this.pb.OuterMargin = -25;
            this.pb.OuterWidth = 15;
            this.pb.ProgressColor = System.Drawing.Color.Orange;
            this.pb.ProgressWidth = 20;
            this.pb.SecondaryFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb.Size = new System.Drawing.Size(69, 67);
            this.pb.StartAngle = 270;
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pb.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pb.SubscriptText = "";
            this.pb.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pb.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pb.SuperscriptText = "";
            this.pb.TabIndex = 84;
            this.pb.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pb.Value = 68;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(145, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 40);
            this.label4.TabIndex = 88;
            this.label4.Text = "login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(77, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 89;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Submit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Greet);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(16, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 293);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            // 
            // Nlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.greetings);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Nlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nlogin";
            this.Load += new System.EventHandler(this.Nlogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Greet;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar pb;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}