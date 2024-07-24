namespace GuestsLshbat
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
            this.btnaddCatgory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDisply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "מארח - הכנס קטגוריה";
            // 
            // btnaddCatgory
            // 
            this.btnaddCatgory.Location = new System.Drawing.Point(383, 160);
            this.btnaddCatgory.Name = "btnaddCatgory";
            this.btnaddCatgory.Size = new System.Drawing.Size(100, 48);
            this.btnaddCatgory.TabIndex = 1;
            this.btnaddCatgory.Text = "הכנס";
            this.btnaddCatgory.UseVisualStyleBackColor = true;
            this.btnaddCatgory.Click += new System.EventHandler(this.btnaddCatgory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(376, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnDisply
            // 
            this.btnDisply.Location = new System.Drawing.Point(84, 311);
            this.btnDisply.Name = "btnDisply";
            this.btnDisply.Size = new System.Drawing.Size(100, 48);
            this.btnDisply.TabIndex = 4;
            this.btnDisply.Text = "הצג טבלה";
            this.btnDisply.UseVisualStyleBackColor = true;
            this.btnDisply.Click += new System.EventHandler(this.btnDisply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisply);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnaddCatgory);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddCatgory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDisply;
    }
}

