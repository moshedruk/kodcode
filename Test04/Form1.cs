using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KodKod
{


    public partial class Form1 : Form
    {

        private XmlDocument _Document;
        public Form1()
        {
            InitializeComponent();
            _Document = Meneger_Ctuva.Main();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item(comboBox1.Text,comboBox2.Text, comboBox3.Text, comboBox4.Text);
            Meneger_Ctuva meneger_Ctuva = new Meneger_Ctuva();
            textBox1.Text =  Meneger_Ctuva.CreateDrinkElement(item);    


        }
    }
}
