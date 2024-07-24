using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWeek3
{
    public partial class FormCurses : Form
    {
        public List<string> _arrParameters = new List<string>();
        public FormCurses()
        {
            InitializeComponent();
            SqlDataReader sqlDataReader =  Manager.Get_name_Teachers();
            insert_to_comboBox(sqlDataReader, comboBox2);
            SqlDataReader sqlDataReader2 = Manager.Get_name_Title();
            insert_to_comboBox(sqlDataReader2, comboBox1);
        }
        private void insert_to_comboBox(SqlDataReader sqlDataReader, ComboBox box) 
        {
            while (sqlDataReader.Read())
            {
                box.Items.Add(sqlDataReader[0]);
            }
        }
        private void Add_new_curses()
        {
            Manager.Add_curses(_arrParameters);
            MessageBox.Show("Successfully");
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
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(ComboBox))
                {
                    _arrParameters.Add(control.Text);
                }
            }
            Manager.Add_curses(_arrParameters);
            MessageBox.Show("Successfully");   
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
