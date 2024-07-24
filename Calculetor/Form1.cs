using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculetor
{
    public partial class Form1 : Form
    {
        private TextBox selectTextBox;
        private Button click_number;

        public Form1()
        {
            InitializeComponent();
        }      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            if (txtnumber1.Text == "" || txtnumber2.Text == "")
            {
                lblResult.Text = "Erorr";
                return;
            }
            //Convert string to int
            if (float.TryParse(txtnumber1.Text, out float num1) && float.TryParse(txtnumber2.Text, out float num2))
                {

                // valibate inputs
                // Check that txtnumber2 is not 0
                string case_active = cmb.SelectedItem.ToString();
                switch (case_active)
                {
                    case "+":
                        lblResult.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        // code block
                        lblResult.Text = (num1 - num2).ToString();
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            return;
                        }
                        lblResult.Text = (num1 / num2).ToString();
                        break;
                    case "*":

                        lblResult.Text = (num1 * num2).ToString();
                        break;
                    default:
                        break;

                } }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtnumber1_Enter(object sender, EventArgs e)
        {
            selectTextBox = sender as TextBox;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            lblResult.Text = "0";
            txtnumber1.Text = "";
            txtnumber2.Text = "";
            cmb.Text = "";
        }
        private void btn_Click(object sender, EventArgs e)
        {
            selectTextBox.Text += ((Button)sender).Text;
        }
        private void btn_operator_Click(object sender, EventArgs e)
        {
            cmb.SelectedItem = ((Button)sender).Text;
            selectTextBox = txtnumber2;
        }        
    }
}
