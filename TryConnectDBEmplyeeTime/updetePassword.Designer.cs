namespace TryConnectDB
{
    partial class updetePassword
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
            this.button1 = new System.Windows.Forms.Button();
            this.textOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNewPassword = new System.Windows.Forms.TextBox();
            this.PasswordVerification = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "הכנס תעודת זהות";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textOldPassword
            // 
            this.textOldPassword.Location = new System.Drawing.Point(345, 144);
            this.textOldPassword.Name = "textOldPassword";
            this.textOldPassword.Size = new System.Drawing.Size(163, 20);
            this.textOldPassword.TabIndex = 2;
            this.textOldPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "סיסמא ישנה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "סיסמה חדשה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "אימות סיסמא חדשה";
            // 
            // textNewPassword
            // 
            this.textNewPassword.Location = new System.Drawing.Point(350, 215);
            this.textNewPassword.Name = "textNewPassword";
            this.textNewPassword.Size = new System.Drawing.Size(158, 20);
            this.textNewPassword.TabIndex = 6;
            // 
            // PasswordVerification
            // 
            this.PasswordVerification.Location = new System.Drawing.Point(345, 287);
            this.PasswordVerification.Name = "PasswordVerification";
            this.PasswordVerification.Size = new System.Drawing.Size(163, 20);
            this.PasswordVerification.TabIndex = 7;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(345, 85);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(163, 20);
            this.textID.TabIndex = 8;
            // 
            // updetePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.PasswordVerification);
            this.Controls.Add(this.textNewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOldPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "updetePassword";
            this.Text = "updetePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNewPassword;
        private System.Windows.Forms.TextBox PasswordVerification;
        private System.Windows.Forms.TextBox textID;
    }
}