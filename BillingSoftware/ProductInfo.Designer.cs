namespace BillingSoftware
{
    partial class ProductInfo
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
            this.label6 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.prodname = new System.Windows.Forms.TextBox();
            this.pack = new System.Windows.Forms.TextBox();
            this.expiry = new System.Windows.Forms.TextBox();
            this.mrp = new System.Windows.Forms.TextBox();
            this.disc = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.prodtinfo = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ob = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.curbal = new System.Windows.Forms.TextBox();
            this.PRT = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.trec = new System.Windows.Forms.TextBox();
            this.LIST_BTN = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodtinfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "MRP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount %";
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(61, 78);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(100, 26);
            this.code.TabIndex = 6;
            this.code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_KeyPress);
            // 
            // prodname
            // 
            this.prodname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.Location = new System.Drawing.Point(286, 77);
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(382, 26);
            this.prodname.TabIndex = 7;
            this.prodname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prodname_KeyDown);
            // 
            // pack
            // 
            this.pack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack.Location = new System.Drawing.Point(904, 77);
            this.pack.Name = "pack";
            this.pack.Size = new System.Drawing.Size(112, 26);
            this.pack.TabIndex = 8;
            this.pack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pack_KeyPress);
            // 
            // expiry
            // 
            this.expiry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.Location = new System.Drawing.Point(61, 113);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(100, 26);
            this.expiry.TabIndex = 9;
            // 
            // mrp
            // 
            this.mrp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrp.Location = new System.Drawing.Point(286, 109);
            this.mrp.Name = "mrp";
            this.mrp.Size = new System.Drawing.Size(61, 26);
            this.mrp.TabIndex = 10;
            this.mrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mrp_KeyPress);
            // 
            // disc
            // 
            this.disc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc.Location = new System.Drawing.Point(463, 109);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(60, 26);
            this.disc.TabIndex = 11;
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Cyan;
            this.add.Location = new System.Drawing.Point(124, 622);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(109, 44);
            this.add.TabIndex = 12;
            this.add.Text = "Add/Save";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Cyan;
            this.delete.Location = new System.Drawing.Point(337, 622);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 44);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // prodtinfo
            // 
            this.prodtinfo.AllowUserToOrderColumns = true;
            this.prodtinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodtinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodtinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodtinfo.Location = new System.Drawing.Point(16, 145);
            this.prodtinfo.Name = "prodtinfo";
            this.prodtinfo.Size = new System.Drawing.Size(993, 376);
            this.prodtinfo.TabIndex = 14;
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Cyan;
            this.update.Location = new System.Drawing.Point(16, 621);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(102, 44);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Opening Balance";
            // 
            // ob
            // 
            this.ob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ob.Location = new System.Drawing.Point(674, 109);
            this.ob.Name = "ob";
            this.ob.Size = new System.Drawing.Size(109, 26);
            this.ob.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 66);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(401, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Master";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(796, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Current Balance ";
            // 
            // curbal
            // 
            this.curbal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curbal.Location = new System.Drawing.Point(913, 109);
            this.curbal.Name = "curbal";
            this.curbal.Size = new System.Drawing.Size(103, 26);
            this.curbal.TabIndex = 20;
            // 
            // PRT
            // 
            this.PRT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PRT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRT.ForeColor = System.Drawing.Color.Cyan;
            this.PRT.Location = new System.Drawing.Point(243, 622);
            this.PRT.Name = "PRT";
            this.PRT.Size = new System.Drawing.Size(88, 44);
            this.PRT.TabIndex = 21;
            this.PRT.Text = "Print";
            this.PRT.UseVisualStyleBackColor = false;
            // 
            // ext
            // 
            this.ext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ext.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext.ForeColor = System.Drawing.Color.Cyan;
            this.ext.Location = new System.Drawing.Point(575, 622);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(75, 41);
            this.ext.TabIndex = 23;
            this.ext.Text = "Exit";
            this.ext.UseVisualStyleBackColor = false;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total Record";
            // 
            // trec
            // 
            this.trec.Location = new System.Drawing.Point(850, 631);
            this.trec.Name = "trec";
            this.trec.Size = new System.Drawing.Size(79, 24);
            this.trec.TabIndex = 26;
            // 
            // LIST_BTN
            // 
            this.LIST_BTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LIST_BTN.BackColor = System.Drawing.Color.Red;
            this.LIST_BTN.ForeColor = System.Drawing.Color.White;
            this.LIST_BTN.Location = new System.Drawing.Point(436, 622);
            this.LIST_BTN.Name = "LIST_BTN";
            this.LIST_BTN.Size = new System.Drawing.Size(126, 43);
            this.LIST_BTN.TabIndex = 27;
            this.LIST_BTN.Text = "Product List";
            this.LIST_BTN.UseVisualStyleBackColor = false;
            this.LIST_BTN.Click += new System.EventHandler(this.LIST_BTN_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(674, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Company";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(744, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 24);
            this.textBox1.TabIndex = 29;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 664);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LIST_BTN);
            this.Controls.Add(this.trec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.PRT);
            this.Controls.Add(this.curbal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.update);
            this.Controls.Add(this.prodtinfo);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.mrp);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.pack);
            this.Controls.Add(this.prodname);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductInfo";
            this.Text = "Product Info";
            this.Load += new System.EventHandler(this.ProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodtinfo)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.TextBox pack;
        private System.Windows.Forms.TextBox expiry;
        private System.Windows.Forms.TextBox mrp;
        private System.Windows.Forms.TextBox disc;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView prodtinfo;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox ob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox curbal;
        private System.Windows.Forms.Button PRT;
        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox trec;
        private System.Windows.Forms.Button LIST_BTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
    }
}