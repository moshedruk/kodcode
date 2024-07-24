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
    public partial class Teachers : Form
    {
        public List<string> _arrParameters = new List<string>();
        public Teachers()
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
            Manager.Add_Teacher(_arrParameters);
            MessageBox.Show("Successfully");
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Manager.disply_all_Teachers();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
