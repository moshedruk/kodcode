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
    public partial class Disply : Form
    {
        public Disply()
        {
            InitializeComponent();
        }

        private void btnDisply_Click(object sender, EventArgs e)
        {
            DataTable dt = maneger.Disply(int.Parse(textCode.Text));
            dataGridView1.DataSource = dt;
        }
    }
}
