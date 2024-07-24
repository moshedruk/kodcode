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

namespace Gest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Disply_by_name();


        }
        private void Disply_by_name() 
        {
            SqlDataReader rdr;

            if (textName.Text.Length > 0)
            {
                rdr = Meneger.Disply_add_Catgory_by_Part(textName.Text);
            }
            else
            {
                rdr = Meneger.Disply_add_Gests();
            }
            listGests.Items.Clear();
            while (rdr.Read())
            {
                string category = rdr.GetString(0);
                //Console.WriteLine(category);
               
                listGests.Items.Add(category);
            }
        }









































































































        private void listGests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGests.SelectedItems != null) 
            {
            string select  = listGests.SelectedItem.ToString();            
            textName.Text = select;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
           Meneger.Add_Name_To_ListName(textName.Text);
            textName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<frmCatgory> forms =  new List<frmCatgory>();
            SqlDataReader sqlDataReader = Meneger.Disply_add_Catgory();
            List<string> names = new List<string>();
            int index = 0;
            while (sqlDataReader.Read())
            {
                string category = sqlDataReader[0].ToString();
                Console.WriteLine(category);
                names.Add(category);
                forms.Add(new frmCatgory(forms, index, category , textName.Text));
                Console.WriteLine(names[index]);
                index++;
            }
            forms.First().Show();           
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            Disply_by_name();
        }
    }
}
