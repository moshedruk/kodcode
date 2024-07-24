using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWeek3
{
    public partial class TableCurses : Form
    {
        public TableCurses()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string[] strings = { (textBox1.Text) };
            dt = Manager.disply_all_curses_byTeache(strings);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string[] strings = { (textBox2.Text) };
            dt = Manager.disply_all_curses_byT_title(strings);
            dataGridView1.DataSource = dt;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
