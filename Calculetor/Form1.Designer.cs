namespace Calculetor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn3 = new System.Windows.Forms.Button();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_dvy = new System.Windows.Forms.Button();
            this.btn_multy = new System.Windows.Forms.Button();
            this.btn_Point = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtnumber1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtnumber2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblResult, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_add, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_dvy, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_multy, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Point, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_minus, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(203, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(147, 70);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 23);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(3, 3);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(48, 20);
            this.txtnumber1.TabIndex = 0;
            this.txtnumber1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtnumber1.Enter += new System.EventHandler(this.txtnumber1_Enter);
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(147, 3);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(66, 20);
            this.txtnumber2.TabIndex = 3;
            this.txtnumber2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtnumber2.Enter += new System.EventHandler(this.txtnumber1_Enter);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(219, 3);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(66, 23);
            this.btnEquals.TabIndex = 5;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click_1);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 70);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 23);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(147, 114);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 23);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(75, 114);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(41, 23);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 114);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 23);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(147, 156);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 23);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(75, 156);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(41, 23);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 156);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 23);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(75, 198);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(41, 23);
            this.btn_0.TabIndex = 16;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Click);
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmb.Location = new System.Drawing.Point(75, 3);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(49, 21);
            this.cmb.TabIndex = 17;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(75, 70);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(41, 23);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(291, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "0";
            this.lblResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(219, 70);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(66, 23);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_dvy
            // 
            this.btn_dvy.Location = new System.Drawing.Point(219, 114);
            this.btn_dvy.Name = "btn_dvy";
            this.btn_dvy.Size = new System.Drawing.Size(66, 23);
            this.btn_dvy.TabIndex = 20;
            this.btn_dvy.Text = "/";
            this.btn_dvy.UseVisualStyleBackColor = true;
            this.btn_dvy.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_multy
            // 
            this.btn_multy.Location = new System.Drawing.Point(219, 156);
            this.btn_multy.Name = "btn_multy";
            this.btn_multy.Size = new System.Drawing.Size(66, 23);
            this.btn_multy.TabIndex = 21;
            this.btn_multy.Text = "*";
            this.btn_multy.UseVisualStyleBackColor = true;
            this.btn_multy.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_Point
            // 
            this.btn_Point.Location = new System.Drawing.Point(147, 198);
            this.btn_Point.Name = "btn_Point";
            this.btn_Point.Size = new System.Drawing.Size(66, 23);
            this.btn_Point.TabIndex = 22;
            this.btn_Point.Text = ".";
            this.btn_Point.UseVisualStyleBackColor = true;
            this.btn_Point.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(219, 198);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(66, 23);
            this.btn_minus.TabIndex = 23;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_dvy;
        private System.Windows.Forms.Button btn_multy;
        private System.Windows.Forms.Button btn_Point;
        private System.Windows.Forms.Button btn_minus;
    }
}

