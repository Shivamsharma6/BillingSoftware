
namespace BillingSoftware
{
    partial class prodlist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._MyDatabase_mdfDataSet1 = new BillingSoftware._MyDatabase_mdfDataSet1();
            this.myDatabasemdfDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._MyDatabase_mdfDataSet = new BillingSoftware._MyDatabase_mdfDataSet();
            this.prodinfoTableAdapter = new BillingSoftware._MyDatabase_mdfDataSet1TableAdapters.prodinfoTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currbalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_mdfDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabasemdfDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_mdfDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.packDataGridViewTextBoxColumn,
            this.expiryDataGridViewTextBoxColumn,
            this.mrpDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.obDataGridViewTextBoxColumn,
            this.currbalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodinfoBindingSource
            // 
            this.prodinfoBindingSource.DataMember = "prodinfo";
            this.prodinfoBindingSource.DataSource = this._MyDatabase_mdfDataSet1;
            // 
            // _MyDatabase_mdfDataSet1
            // 
            this._MyDatabase_mdfDataSet1.DataSetName = "_MyDatabase_mdfDataSet1";
            this._MyDatabase_mdfDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDatabasemdfDataSetBindingSource
            // 
            this.myDatabasemdfDataSetBindingSource.DataSource = this._MyDatabase_mdfDataSet;
            this.myDatabasemdfDataSetBindingSource.Position = 0;
            // 
            // _MyDatabase_mdfDataSet
            // 
            this._MyDatabase_mdfDataSet.DataSetName = "_MyDatabase_mdfDataSet";
            this._MyDatabase_mdfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodinfoTableAdapter
            // 
            this.prodinfoTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(56, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(374, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(480, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(586, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(692, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(798, 82);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 10;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // packDataGridViewTextBoxColumn
            // 
            this.packDataGridViewTextBoxColumn.DataPropertyName = "pack";
            this.packDataGridViewTextBoxColumn.HeaderText = "pack";
            this.packDataGridViewTextBoxColumn.Name = "packDataGridViewTextBoxColumn";
            // 
            // expiryDataGridViewTextBoxColumn
            // 
            this.expiryDataGridViewTextBoxColumn.DataPropertyName = "expiry";
            this.expiryDataGridViewTextBoxColumn.HeaderText = "expiry";
            this.expiryDataGridViewTextBoxColumn.Name = "expiryDataGridViewTextBoxColumn";
            // 
            // mrpDataGridViewTextBoxColumn
            // 
            this.mrpDataGridViewTextBoxColumn.DataPropertyName = "mrp";
            this.mrpDataGridViewTextBoxColumn.HeaderText = "mrp";
            this.mrpDataGridViewTextBoxColumn.Name = "mrpDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // obDataGridViewTextBoxColumn
            // 
            this.obDataGridViewTextBoxColumn.DataPropertyName = "ob";
            this.obDataGridViewTextBoxColumn.HeaderText = "ob";
            this.obDataGridViewTextBoxColumn.Name = "obDataGridViewTextBoxColumn";
            // 
            // currbalDataGridViewTextBoxColumn
            // 
            this.currbalDataGridViewTextBoxColumn.DataPropertyName = "currbal";
            this.currbalDataGridViewTextBoxColumn.HeaderText = "currbal";
            this.currbalDataGridViewTextBoxColumn.Name = "currbalDataGridViewTextBoxColumn";
            // 
            // prodlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 638);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "prodlist";
            this.Text = "prodlist";
            this.Load += new System.EventHandler(this.prodlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_mdfDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabasemdfDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_mdfDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource myDatabasemdfDataSetBindingSource;
        private _MyDatabase_mdfDataSet _MyDatabase_mdfDataSet;
        private _MyDatabase_mdfDataSet1 _MyDatabase_mdfDataSet1;
        private System.Windows.Forms.BindingSource prodinfoBindingSource;
        private _MyDatabase_mdfDataSet1TableAdapters.prodinfoTableAdapter prodinfoTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currbalDataGridViewTextBoxColumn;
    }
}