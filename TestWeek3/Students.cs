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
    public partial class Students : Form
    {
        public List<string> _arrParameters = new List<string>();
        public Students()
        {
            InitializeComponent();
            SqlDataReader sqlDataReader = Manager.Get_name_student();
            insert_to_comboBox(sqlDataReader, comboBox1);
            SqlDataReader sqlDataReader2 = Manager.Get_name_curses();
            insert_to_comboBox(sqlDataReader2, comboBox2);
        }
        private void insert_to_comboBox(SqlDataReader sqlDataReader, ComboBox box)
        {
            while (sqlDataReader.Read())
            {
                box.Items.Add(sqlDataReader[0]);
            }
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            newStudent newStudent = new newStudent();
            newStudent.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _arrParameters.Add(comboBox1.Text);
            _arrParameters.Add(comboBox2.Text);
            Manager.Add_curses_to_student(_arrParameters);
            MessageBox.Show("Successfully registered");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res = Manager.Get_price(comboBox1.Text);
            MessageBox.Show(res);
        }
    }
}
