using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Drenk
{
    internal class ItemDrink
    {
        public float _milk;
        public float _cofee;
        public float _coca;
        public float _suger;
        public float _price;
        public string _name;
        public ItemDrink(string name, float coca, float suger, float cofee,float milk, int price ) 
        {                             
            _name = name;           
            _coca = coca;             
            _suger = suger;
            _cofee = cofee;           
            _milk = milk;
            _price = price;            
        }
        public ItemDrink Updete(ItemDrink newItemDrink)
        {
            _name = newItemDrink._name;
            _coca = newItemDrink._coca;
            _suger = newItemDrink._suger;
            _cofee = newItemDrink._cofee;
            _milk = newItemDrink._milk;
            _price= newItemDrink._price;
            return this;
        }
        
    }
    
}
