using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TryConnectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;            
            string res = maneger.Login(textFoolName.Text, text_id.Text, textpassword.Text);
            MessageBox.Show(res);
        }
        private void updetePassword_Click(object sender, EventArgs e)
        {
            updetePassword updetePassword = new updetePassword();
            updetePassword.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Disply disply = new Disply();
            disply.ShowDialog();
        }
    }
}
