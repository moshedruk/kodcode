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
    public partial class Title : Form
    {
        public Title(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
