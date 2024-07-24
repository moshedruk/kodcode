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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace GuestsLshbat
{
    public partial class Form1 : Form
    {
        public List<string> arrOfCategory = new List<string>();
        public Form1()
        {
            InitializeComponent();
            DisplyCatgory_Click();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnaddCatgory_Click(object sender, EventArgs e)
        {
          string res = Maneger.AddCatgort(textBox1.Text);
           MessageBox.Show(res);
            textBox1.Text = "";

           DisplyCatgory_Click();
        }
        private void DisplyCatgory_Click()
        {
            SqlDataReader rdr;

            if (textBox1.Text.Length > 0)
            {
                rdr = Maneger.Disply_add_Catgory_by_Part(textBox1.Text);
            }
            else
            {
                rdr = Maneger.Disply_add_Catgory();
            }
            listBox1.Items.Clear();
            while (rdr.Read())
            {
                string category = rdr.GetString(0);
                //Console.WriteLine(category);
                arrOfCategory.Add(category);
                listBox1.Items.Add(category);
            }               

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text =  listBox1.SelectedItem.ToString();
        }

        private void btnDisply_Click(object sender, EventArgs e)
        {
            DisplyTableHost displyTableHost = new DisplyTableHost(arrOfCategory);
            displyTableHost.ShowDialog(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DisplyCatgory_Click();            
        }
    }
}
