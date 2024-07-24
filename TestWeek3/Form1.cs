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
    public partial class Form1 : Form
    {
        public List <string> _arrParameters = new List <string> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    _arrParameters.Add(control.Text);  
                }
            }
            Manager.Add_Title(_arrParameters);
            MessageBox.Show("Successfully registered");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            dt = Manager.disply_all_title();
            Title title = new Title (dt);
            title.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCurses formCurses = new FormCurses ();
            formCurses.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers ();
            teachers.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableCurses tableCurses = new TableCurses ();
            tableCurses.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Students students = new Students ();
            students.ShowDialog();
        }
    }
}
