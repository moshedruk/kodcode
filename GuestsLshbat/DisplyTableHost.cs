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

namespace GuestsLshbat
{
    public partial class DisplyTableHost : Form
    {
        public List<string> ArrOfCategory = new List<string>();

        public int _index = 0;
        public  string _name_catgory = "";


        public DisplyTableHost(List<string> arrOfCategory)
        {
            InitializeComponent();
            ArrOfCategory = arrOfCategory;
            //Console.WriteLine(ArrOfCategory[1]);
            NameCatgory.Text = ArrOfCategory[_index];
            int firstIndex = ArrOfCategory.IndexOf(ArrOfCategory[0])+1;
            string index = firstIndex.ToString(); 
            //NameCatgory.Text = Maneger.Get_disply_one_Catgory(ArrOfCategory[0]).ToString();
            DataTable dt = Maneger.Disply_food(firstIndex);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
             _index  = ((_index +1) % ArrOfCategory.Count);
            NameCatgory.Text = ArrOfCategory[_index];
            DataTable dt = Maneger.Disply_food(_index+1);
            dataGridView1.DataSource = dt;

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _index = (_index - 1 + ArrOfCategory.Count) % ArrOfCategory.Count;
            NameCatgory.Text = ArrOfCategory[_index];
            DataTable dt = Maneger.Disply_food(_index + 1);
            dataGridView1.DataSource = dt;
        }
    }
}
