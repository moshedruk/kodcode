using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryConnectDB
{
    public partial class updetePassword : Form
    {
        public updetePassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string res = maneger.ChangePassword(textID.Text, textOldPassword.Text, textNewPassword.Text, PasswordVerification.Text);
            MessageBox.Show(res);

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
