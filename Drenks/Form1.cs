using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Drenk
{
    public partial class Form1 : Form
    {
        private MenegerDrimk _drinkMeneger;

        
        public Form1()
        {
            InitializeComponent();
            XmlDocument drinkDocument = main.Main();
            _drinkMeneger = new MenegerDrimk(drinkDocument);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<List<string>> all_drinks = _drinkMeneger.Get_All_Drinks();
            foreach (var drink in all_drinks)
            {
                dataGridView1.Rows.Add(drink.ToArray());
            }           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {              
            ItemDrink itemDrink = new ItemDrink(textdrink.Text, float.Parse(comboBoxcacou.Text), float.Parse(comboBoxsugger.Text), float.Parse(comboBoxcofee.Text), float.Parse(comboBoxmilk.Text),int.Parse( textBoxprice.Text));

            _drinkMeneger.CreateDrinkElement(itemDrink);
            
            _drinkMeneger.Save();
            MessageBox.Show("delete");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _drinkMeneger.Save();           
        }

        private void btb_delete_Click(object sender, EventArgs e)
        {
            //_drinkMeneger.Sherch_Drink(textdrink.Text);
            _drinkMeneger.Delete_Drink(textdrink.Text);
            _drinkMeneger.Save();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // קבלת השורה הנלחצת
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // בניית מחרוזת המכילה את כל הערכים בשורה
                StringBuilder rowData = new StringBuilder();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData.Append(cell.Value?.ToString() + " ");
                }

                // הצגת המחרוזת בהודעה
                MessageBox.Show($"Row data: {rowData.ToString()}");
            }
        }

        private void textdrink_TextChanged(object sender, EventArgs e)
        {

            //List<string> drink = _drinkMeneger.Sherch_Drink(textdrink.Text);
            //DialogResult result = MessageBox.Show("לעדכן?", "עדכן משקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //comboBoxcacou.Text = drink[1];
            //comboBoxsugger.Text = drink[2];
            //comboBoxcofee.Text = drink[3];
            //comboBoxmilk.Text = drink[4];
            //textBoxprice.Text = drink[5];
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float price = float.Parse(textBoxprice.Text);
            if (price > 0)
            {
                price -= 0.5f;
                textBoxprice.Text = price.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            float price = float.Parse(textBoxprice.Text);
           
            price +=  0.5f;
            textBoxprice.Text = price.ToString();

            

        }

        private void btnUpdete_Click(object sender, EventArgs e)
        {
            ItemDrink itemDrink = new ItemDrink(textdrink.Text, float.Parse(comboBoxcacou.Text), float.Parse(comboBoxsugger.Text), float.Parse(comboBoxcofee.Text), float.Parse(comboBoxmilk.Text), int.Parse(textBoxprice.Text));
            
             
               
             
            //_drinkMeneger.Updete_Drink(itemDrink,);
            _drinkMeneger.Save();
        }
    }

}


