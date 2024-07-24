namespace TryConnectDB
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
            this.textpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.textFoolName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updetePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(307, 249);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(150, 20);
            this.textpassword.TabIndex = 0;
            //this.textpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "מידע";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "הכנס ססימא";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "הכנס מספר זהות";
           // this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(307, 88);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(150, 20);
            this.text_id.TabIndex = 4;
           // this.text_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textFoolName
            // 
            this.textFoolName.Location = new System.Drawing.Point(307, 154);
            this.textFoolName.Name = "textFoolName";
            this.textFoolName.Size = new System.Drawing.Size(150, 20);
            this.textFoolName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "הכנס שם מלא";
            // 
            // updetePassword
            // 
            this.updetePassword.Location = new System.Drawing.Point(560, 321);
            this.updetePassword.Name = "updetePassword";
            this.updetePassword.Size = new System.Drawing.Size(159, 23);
            this.updetePassword.TabIndex = 7;
            this.updetePassword.Text = "החלף סיסמא";
            this.updetePassword.UseVisualStyleBackColor = true;
            this.updetePassword.Click += new System.EventHandler(this.updetePassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updetePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFoolName);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textpassword);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox textFoolName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updetePassword;
    }
}

