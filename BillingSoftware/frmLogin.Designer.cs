namespace BillingSoftware
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.greetings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.TM = new System.Windows.Forms.Label();
            this.DTDY = new System.Windows.Forms.Label();
            this.vvcvcvc = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customControl11 = new BillingSoftware.CustomControl1();
            this.vvcvcvc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Name = "label3";
            this.helpProvider1.SetShowHelp(this.label3, ((bool)(resources.GetObject("label3.ShowHelp"))));
            // 
            // lbltime
            // 
            resources.ApplyResources(this.lbltime, "lbltime");
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbltime.Name = "lbltime";
            this.helpProvider1.SetShowHelp(this.lbltime, ((bool)(resources.GetObject("lbltime.ShowHelp"))));
            // 
            // greetings
            // 
            resources.ApplyResources(this.greetings, "greetings");
            this.greetings.BackColor = System.Drawing.Color.Transparent;
            this.greetings.ForeColor = System.Drawing.Color.DarkBlue;
            this.greetings.Name = "greetings";
            this.helpProvider1.SetShowHelp(this.greetings, ((bool)(resources.GetObject("greetings.ShowHelp"))));
//            this.greetings.Click += new System.EventHandler(this.greetings_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Name = "label6";
            this.helpProvider1.SetShowHelp(this.label6, ((bool)(resources.GetObject("label6.ShowHelp"))));
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Name = "label9";
            this.helpProvider1.SetShowHelp(this.label9, ((bool)(resources.GetObject("label9.ShowHelp"))));
            // 
            // txt_Password
            // 
            resources.ApplyResources(this.txt_Password, "txt_Password");
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Name = "txt_Password";
            this.helpProvider1.SetShowHelp(this.txt_Password, ((bool)(resources.GetObject("txt_Password.ShowHelp"))));
            // 
            // btn_Submit
            // 
            resources.ApplyResources(this.btn_Submit, "btn_Submit");
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Name = "btn_Submit";
            this.helpProvider1.SetShowHelp(this.btn_Submit, ((bool)(resources.GetObject("btn_Submit.ShowHelp"))));
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            resources.ApplyResources(this.cancel, "cancel");
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Name = "cancel";
            this.helpProvider1.SetShowHelp(this.cancel, ((bool)(resources.GetObject("cancel.ShowHelp"))));
            this.cancel.UseMnemonic = false;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_UserName
            // 
            resources.ApplyResources(this.txt_UserName, "txt_UserName");
            this.txt_UserName.BackColor = System.Drawing.Color.MintCream;
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_UserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_UserName.Name = "txt_UserName";
            this.helpProvider1.SetShowHelp(this.txt_UserName, ((bool)(resources.GetObject("txt_UserName.ShowHelp"))));
            this.txt_UserName.Click += new System.EventHandler(this.txt_UserName_Click);
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.checkBox2.Name = "checkBox2";
            this.helpProvider1.SetShowHelp(this.checkBox2, ((bool)(resources.GetObject("checkBox2.ShowHelp"))));
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Name = "checkBox1";
            this.helpProvider1.SetShowHelp(this.checkBox1, ((bool)(resources.GetObject("checkBox1.ShowHelp"))));
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Name = "textBox1";
            this.helpProvider1.SetShowHelp(this.textBox1, ((bool)(resources.GetObject("textBox1.ShowHelp"))));
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            this.helpProvider1.SetShowHelp(this.label5, ((bool)(resources.GetObject("label5.ShowHelp"))));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Name = "label7";
            this.helpProvider1.SetShowHelp(this.label7, ((bool)(resources.GetObject("label7.ShowHelp"))));
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // TM
            // 
            resources.ApplyResources(this.TM, "TM");
            this.TM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TM.Name = "TM";
            this.helpProvider1.SetShowHelp(this.TM, ((bool)(resources.GetObject("TM.ShowHelp"))));
           // this.TM.Click += new System.EventHandler(this.TM_Click);
            // 
            // DTDY
            // 
            resources.ApplyResources(this.DTDY, "DTDY");
            this.DTDY.ForeColor = System.Drawing.Color.Black;
            this.DTDY.Name = "DTDY";
            this.helpProvider1.SetShowHelp(this.DTDY, ((bool)(resources.GetObject("DTDY.ShowHelp"))));
            // 
            // vvcvcvc
            // 
            resources.ApplyResources(this.vvcvcvc, "vvcvcvc");
            this.vvcvcvc.BackColor = System.Drawing.Color.Gold;
            this.vvcvcvc.Controls.Add(this.label4);
            this.vvcvcvc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vvcvcvc.Name = "vvcvcvc";
            this.helpProvider1.SetShowHelp(this.vvcvcvc, ((bool)(resources.GetObject("vvcvcvc.ShowHelp"))));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Name = "label4";
            this.helpProvider1.SetShowHelp(this.label4, ((bool)(resources.GetObject("label4.ShowHelp"))));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.customControl11);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.vvcvcvc);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btn_Submit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Name = "panel1";
            this.helpProvider1.SetShowHelp(this.panel1, ((bool)(resources.GetObject("panel1.ShowHelp"))));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            this.helpProvider1.SetShowHelp(this.panel4, ((bool)(resources.GetObject("panel4.ShowHelp"))));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.helpProvider1.SetShowHelp(this.panel3, ((bool)(resources.GetObject("panel3.ShowHelp"))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.helpProvider1.SetShowHelp(this.panel2, ((bool)(resources.GetObject("panel2.ShowHelp"))));
            // 
            // customControl11
            // 
            resources.ApplyResources(this.customControl11, "customControl11");
            this.customControl11.BackColor = System.Drawing.Color.Cyan;
            this.customControl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customControl11.Name = "customControl11";
            this.helpProvider1.SetShowHelp(this.customControl11, ((bool)(resources.GetObject("customControl11.ShowHelp"))));
            this.customControl11.Step = 5;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.greetings);
            this.Controls.Add(this.TM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DTDY);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLogin";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.vvcvcvc.ResumeLayout(false);
            this.vvcvcvc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label7;
        private CustomControl1 customControl11;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label TM;
        private System.Windows.Forms.Label DTDY;
        private System.Windows.Forms.Panel vvcvcvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

