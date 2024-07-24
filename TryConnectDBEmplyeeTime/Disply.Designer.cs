namespace TryConnectDB
{
    partial class Disply
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDisply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDisply
            // 
            this.btnDisply.Location = new System.Drawing.Point(131, 220);
            this.btnDisply.Name = "btnDisply";
            this.btnDisply.Size = new System.Drawing.Size(75, 23);
            this.btnDisply.TabIndex = 1;
            this.btnDisply.Text = "הצג";
            this.btnDisply.UseVisualStyleBackColor = true;
            this.btnDisply.Click += new System.EventHandler(this.btnDisply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "הכנס קוד מזהה";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(88, 138);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(166, 20);
            this.textCode.TabIndex = 3;
            // 
            // Disply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisply);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Disply";
            this.Text = "Disply";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDisply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCode;
    }
}