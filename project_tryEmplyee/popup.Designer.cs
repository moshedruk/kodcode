namespace project_try
{
    partial class popup
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(113, 105);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Search";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(57, 79);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(198, 20);
            this.input.TabIndex = 1;
            // 
            // name_input
            // 
            this.name_input.AutoSize = true;
            this.name_input.Location = new System.Drawing.Point(134, 46);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(40, 13);
            this.name_input.TabIndex = 2;
            this.name_input.Text = "Ener id";
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 144);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.input);
            this.Controls.Add(this.btn_ok);
            this.Name = "popup";
            this.Text = "popup";
            this.Load += new System.EventHandler(this.popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label name_input;
    }
}