using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_try
{
    public partial class popup : Form
    {
        public popup(string name_popup, string name_serch)
        {
            InitializeComponent();
            this.Name = name_popup;
            name_input.Text = name_serch;
        }
        private string _id;
        private int _index;
        public string name_popup;



        public int index { get { return _index; } set { _index = value; } }
        public string id { get { return _id; } set { _id = value; } }
        private void popup_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            id = input.Text;
            index = int.Parse(input.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
