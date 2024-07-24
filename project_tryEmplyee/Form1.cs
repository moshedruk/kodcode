using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_try
{
    public partial class Form1 : Form
    {
        private Employe[] arremployees = new Employe[0];
        public Form1()
        {
            InitializeComponent();
        }
        private void next_rihgt_Click(object sender, EventArgs e)
        {
            int index = (int.Parse(Code_num.Text)+1) % arremployees.Length;
            Disply(index);
        }
        private void next_left_Click(object sender, EventArgs e)
        {
            int index = (int.Parse(Code_num.Text) -1 + arremployees.Length) % arremployees.Length;
            Disply(index);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void add_Click(object sender, EventArgs e)
        {

        }        
        private void Increases()
        {
            Employe[] tmp_arremployees = new Employe[arremployees.Length + 1];
            for (int i = 0; i < arremployees.Length; i++)
            {
                tmp_arremployees[i] = arremployees[i];
            }
            arremployees = tmp_arremployees;
        }
        private Employe create_one()
        {
          
            Employe employe = new Employe();
            employe.code = arremployees.Length;
            employe.Id = id.Text;
            employe.First_Name = first_name.Text;
            employe.Last_name = last_name.Text;
            employe.Date_of_birth = DateTime.Parse(dateTimePicker.Text);
            employe.phone = int.Parse(phon.Text);
            employe.address = street.Text;
            employe.number_address = int.Parse(number_adress.Text);
            employe.city = city.Text;
            employe.Home_phone = int.Parse(Home_phone.Text);
            employe.is_male_status = is_man.Checked;
            employe.status = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            return employe;           

        }
        private void Disply(int index)
        {
            Code_num.Text = arremployees[index].code.ToString();
            id.Text = arremployees[index].Id.ToString();  
            first_name.Text = arremployees[index].First_Name ;


            last_name.Text = arremployees[index].Last_name;
            dateTimePicker.Text = arremployees[index].Date_of_birth.ToString();
            phon.Text = arremployees[index].phone.ToString();
            street.Text = arremployees[index].address;
            number_adress.Text = arremployees[index].number_address.ToString();
            city.Text = arremployees[index].city;
            Home_phone.Text = arremployees[index].Home_phone.ToString();
            is_man.Checked = arremployees[index].is_male_status;
            panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text == arremployees[index].status).Checked = true;
            Age.Text = arremployees[index].age.ToString();

        }
        
        private void add__Click(object sender, EventArgs e)
        {
            try
            {
            Employe new_one = create_one();               

            Increases();
            arremployees[arremployees.Length - 1] = new_one;
            
                MessageBox.Show("Employee added successfully");
            
            Disply((new_one.code));
            }
            catch (Exception ex)
            {
                MessageBox.Show((ex.Message));
               ;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Disply(int.Parse(Code_num.Text));
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete_(int.Parse(Code_num.Text));
           
        }
        private void delete_(int index)
        {

            foreach (Control control in this.Controls)
            {


                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";

                }              

            }
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            popup mypopup = new popup("Search_By_id" ,"Enter_id");
            
            if (mypopup.ShowDialog() == DialogResult.OK)
            {
                Sherch_id(mypopup.id);
            }


        }
        private void Sherch_code(int index)
        {
            Employe result = Array.Find(arremployees, step => step.code == index);
            if (result == null)
            {
                Console.WriteLine(result.code + "jjjjjj");
                return;
            }
            else
            {
                Disply(result.code);
            }
        }
        private void Sherch_id(string str) 
        {
            Employe result = Array.Find(arremployees, step => step.Id == str);
            if (result == null) 
            {
            Console.WriteLine(result.code + "jjjjjj");
                return;
            }
            else
            {
                Disply(result.code);
            }
        }

        private void searh_Click(object sender, EventArgs e)
        {
            popup mypopup = new popup("Search_By_code" ,"Enter_code");

            if (mypopup.ShowDialog() == DialogResult.OK)
            {
                Sherch_code(mypopup.index);
            }
        }
    }
}
