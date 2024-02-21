namespace BillingSoftware
{
    partial class Reset_PWD
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
            this.Update = new System.Windows.Forms.Button();
            this.textuname = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textpass = new System.Windows.Forms.TextBox();
            this.uid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // Update
            // 
           // this.Update.Location = new System.Drawing.Point(269, 212);
            //this.Update.Margin = new System.Windows.Forms.Padding(2);
            //this.Update.Name = "Update";
            //this.Update.Size = new System.Drawing.Size(56, 19);
            //this.Update.TabIndex = 4;
            //This.Update.Text = "Update";
            //this.Update.UseVisualStyleBackColor = true;
            //this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // textuname
            // 
            this.textuname.Location = new System.Drawing.Point(293, 110);
            this.textuname.Margin = new System.Windows.Forms.Padding(2);
            this.textuname.Name = "textuname";
            this.textuname.Size = new System.Drawing.Size(92, 20);
            this.textuname.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(600, 2);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(293, 140);
            this.textpass.Margin = new System.Windows.Forms.Padding(2);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(92, 20);
            this.textpass.TabIndex = 7;
            // 
            // uid
            // 
            this.uid.Location = new System.Drawing.Point(293, 76);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(100, 20);
            this.uid.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "User ID";
            // 
            // Reset_PWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textuname);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reset_PWD";
            this.Text = "Reset_PWD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textuname;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Label label3;
    }
}

