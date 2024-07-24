using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gest
{
    public partial class frmCatgory : Form
    {
        public List<frmCatgory> frmCatgories = new List<frmCatgory>();
        public int _index;
        public string Name_User;
        public frmCatgory(List<frmCatgory> frmCatgories, int index,string NameCatgory ,string user)
        {
            InitializeComponent();
            this.frmCatgories = frmCatgories;
            _index = index;
            label1.Text = NameCatgory;
            Name_User = user;
        }

        private void frmCatgory_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Meneger.Get_All_Gets_frinds(label1.Text, Name_User);
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            if (_index < frmCatgories.Count-1 && _index >= 0)
            {
                frmCatgories[_index+1].Visible = true;
            }
            else {
                frmCatgories[0].Visible = true;
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (_index > 0 )
            {
                frmCatgories[_index - 1].Visible = true;
            }
            else
            {
                frmCatgories[frmCatgories.Count-1].Visible = true;
            }
        }
    }
}
