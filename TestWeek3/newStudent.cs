using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWeek3
{
    public partial class newStudent : Form
    {
        public newStudent()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Manager.Add_student(textBox1.Text);
            MessageBox.Show("Successfully registered");            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
