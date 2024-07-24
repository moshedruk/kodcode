namespace Drenk
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
            this.btb_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxmilk = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textdrink = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxcofee = new System.Windows.Forms.ComboBox();
            this.comboBoxsugger = new System.Windows.Forms.ComboBox();
            this.comboBoxcacou = new System.Windows.Forms.ComboBox();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnUpdete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btb_delete
            // 
            this.btb_delete.Location = new System.Drawing.Point(34, 124);
            this.btb_delete.Name = "btb_delete";
            this.btb_delete.Size = new System.Drawing.Size(75, 23);
            this.btb_delete.TabIndex = 0;
            this.btb_delete.Text = "מחיקה";
            this.btb_delete.UseVisualStyleBackColor = true;
            this.btb_delete.Click += new System.EventHandler(this.btb_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "שם השתיה";
            // 
            // comboBoxmilk
            // 
            this.comboBoxmilk.FormattingEnabled = true;
            this.comboBoxmilk.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.comboBoxmilk.Location = new System.Drawing.Point(619, 123);
            this.comboBoxmilk.Name = "comboBoxmilk";
            this.comboBoxmilk.Size = new System.Drawing.Size(70, 21);
            this.comboBoxmilk.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(139, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "שם";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "קקאו";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "סוכר";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "קפה";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "חלב";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "מחיר";
            this.Column6.Name = "Column6";
            // 
            // textdrink
            // 
            this.textdrink.Location = new System.Drawing.Point(347, 32);
            this.textdrink.Name = "textdrink";
            this.textdrink.Size = new System.Drawing.Size(100, 20);
            this.textdrink.TabIndex = 4;
            this.textdrink.TextChanged += new System.EventHandler(this.textdrink_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "קקאו";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "סוכר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "קפה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "חלב";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "מחיר";
            // 
            // comboBoxcofee
            // 
            this.comboBoxcofee.FormattingEnabled = true;
            this.comboBoxcofee.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.comboBoxcofee.Location = new System.Drawing.Point(505, 123);
            this.comboBoxcofee.Name = "comboBoxcofee";
            this.comboBoxcofee.Size = new System.Drawing.Size(70, 21);
            this.comboBoxcofee.TabIndex = 12;
            // 
            // comboBoxsugger
            // 
            this.comboBoxsugger.FormattingEnabled = true;
            this.comboBoxsugger.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.comboBoxsugger.Location = new System.Drawing.Point(401, 123);
            this.comboBoxsugger.Name = "comboBoxsugger";
            this.comboBoxsugger.Size = new System.Drawing.Size(70, 21);
            this.comboBoxsugger.TabIndex = 13;
            // 
            // comboBoxcacou
            // 
            this.comboBoxcacou.FormattingEnabled = true;
            this.comboBoxcacou.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.comboBoxcacou.Location = new System.Drawing.Point(310, 123);
            this.comboBoxcacou.Name = "comboBoxcacou";
            this.comboBoxcacou.Size = new System.Drawing.Size(70, 21);
            this.comboBoxcacou.TabIndex = 14;
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(218, 124);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(37, 20);
            this.textBoxprice.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(187, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(187, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdete
            // 
            this.btnUpdete.Location = new System.Drawing.Point(34, 62);
            this.btnUpdete.Name = "btnUpdete";
            this.btnUpdete.Size = new System.Drawing.Size(75, 23);
            this.btnUpdete.TabIndex = 18;
            this.btnUpdete.Text = "עדכון";
            this.btnUpdete.UseVisualStyleBackColor = true;
            this.btnUpdete.Click += new System.EventHandler(this.btnUpdete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdete);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.comboBoxcacou);
            this.Controls.Add(this.comboBoxsugger);
            this.Controls.Add(this.comboBoxcofee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textdrink);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxmilk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btb_delete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btb_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxmilk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textdrink;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxcofee;
        private System.Windows.Forms.ComboBox comboBoxsugger;
        private System.Windows.Forms.ComboBox comboBoxcacou;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnUpdete;
    }
}

