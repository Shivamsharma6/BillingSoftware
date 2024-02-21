namespace BillingSoftware
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.mob = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addsv = new System.Windows.Forms.Button();
            this.userinfo = new System.Windows.Forms.DataGridView();
            this.submit = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cstn = new System.Windows.Forms.TextBox();
            this.licn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.acyr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userinfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Company Code -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Company/Shop  Name -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Address -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "City -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone No -";
            // 
            // uid
            // 
            this.uid.Location = new System.Drawing.Point(231, 128);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(139, 24);
            this.uid.TabIndex = 31;
            this.uid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uid_KeyPress);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(229, 218);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(351, 24);
            this.name.TabIndex = 32;
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(228, 248);
            this.addr.Multiline = true;
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(351, 28);
            this.addr.TabIndex = 33;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(228, 282);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(351, 24);
            this.city.TabIndex = 34;
            // 
            // mob
            // 
            this.mob.Location = new System.Drawing.Point(228, 312);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(351, 24);
            this.mob.TabIndex = 35;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(231, 158);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(139, 24);
            this.pwd.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Password -";
            // 
            // addsv
            // 
            this.addsv.BackColor = System.Drawing.Color.Purple;
            this.addsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsv.ForeColor = System.Drawing.Color.Cyan;
            this.addsv.Location = new System.Drawing.Point(129, 639);
            this.addsv.Name = "addsv";
            this.addsv.Size = new System.Drawing.Size(117, 53);
            this.addsv.TabIndex = 38;
            this.addsv.Text = "Add/Save";
            this.addsv.UseVisualStyleBackColor = false;
            this.addsv.Click += new System.EventHandler(this.Addsv_Click);
            // 
            // userinfo
            // 
            this.userinfo.AllowUserToOrderColumns = true;
            this.userinfo.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.userinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userinfo.Location = new System.Drawing.Point(8, 402);
            this.userinfo.Name = "userinfo";
            this.userinfo.Size = new System.Drawing.Size(869, 231);
            this.userinfo.TabIndex = 39;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Purple;
            this.submit.ForeColor = System.Drawing.Color.Cyan;
            this.submit.Location = new System.Drawing.Point(-5, 639);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(126, 53);
            this.submit.TabIndex = 40;
            this.submit.Text = "Update";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Purple;
            this.del.ForeColor = System.Drawing.Color.Cyan;
            this.del.Location = new System.Drawing.Point(378, 638);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(108, 53);
            this.del.TabIndex = 41;
            this.del.Text = "Detele";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.Del_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(492, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 53);
            this.button1.TabIndex = 44;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Wheat;
            this.groupBox1.Location = new System.Drawing.Point(2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 98);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(660, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 21);
            this.label14.TabIndex = 49;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(466, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 48;
            this.label13.Text = "label13";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(285, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(378, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "label7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(378, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 26);
            this.label10.TabIndex = 45;
            this.label10.Text = "label10";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.ForeColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(250, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 51);
            this.button2.TabIndex = 46;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 52;
            this.label11.Text = "CST No -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 18);
            this.label12.TabIndex = 53;
            this.label12.Text = "Licence No -";
            // 
            // cstn
            // 
            this.cstn.Location = new System.Drawing.Point(226, 342);
            this.cstn.Name = "cstn";
            this.cstn.Size = new System.Drawing.Size(349, 24);
            this.cstn.TabIndex = 55;
            // 
            // licn
            // 
            this.licn.Location = new System.Drawing.Point(226, 372);
            this.licn.Name = "licn";
            this.licn.Size = new System.Drawing.Size(350, 24);
            this.licn.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "Accounting Year -";
            // 
            // acyr
            // 
            this.acyr.Location = new System.Drawing.Point(230, 188);
            this.acyr.Name = "acyr";
            this.acyr.Size = new System.Drawing.Size(140, 24);
            this.acyr.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(6, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 28);
            this.label15.TabIndex = 50;
            this.label15.Text = "Company Setup";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(886, 709);
            this.Controls.Add(this.acyr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.licn);
            this.Controls.Add(this.cstn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.userinfo);
            this.Controls.Add(this.addsv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.city);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.name);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userinfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox mob;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addsv;
        private System.Windows.Forms.DataGridView userinfo;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cstn;
        private System.Windows.Forms.TextBox licn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox acyr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
    }
}