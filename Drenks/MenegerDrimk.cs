using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace Drenk
{
    internal class MenegerDrimk
    {
        XmlDocument _XmlDocument;
        public MenegerDrimk(XmlDocument XmlDocument)
        {               
            _XmlDocument = XmlDocument;
        }

        public void CreateDrinkElement(ItemDrink obj)
        {

            XmlElement drinkElement = _XmlDocument.CreateElement("Drink");
            XmlElement nameElement = _XmlDocument.CreateElement("Name");
            nameElement.InnerText = obj._name;
            drinkElement.AppendChild(nameElement);
            XmlElement sugerElement = _XmlDocument.CreateElement("Suger");
            sugerElement.InnerText = obj._suger.ToString();
            drinkElement.AppendChild(sugerElement);

            XmlElement milkElement = _XmlDocument.CreateElement("Milk");
            milkElement.InnerText = obj._milk.ToString();
            drinkElement.AppendChild(milkElement);

            XmlElement cofeeElement = _XmlDocument.CreateElement("Cofee");
            cofeeElement.InnerText = obj._cofee.ToString();
            drinkElement.AppendChild(cofeeElement);

            XmlElement cacouElement = _XmlDocument.CreateElement("Cacou");
            cacouElement.InnerText = obj._coca.ToString();
            drinkElement.AppendChild(cacouElement);

            XmlElement priceElement = _XmlDocument.CreateElement("Price");
            priceElement.InnerText = obj._price.ToString();
            drinkElement.AppendChild(priceElement);

            XmlElement newDrinkElement = drinkElement;

            // הוספת הצומת החדש למסמך
            _XmlDocument.DocumentElement.AppendChild(newDrinkElement);

            // שמירת המסמך המעודכן
            
        }
        

        public List<List<string>> Get_All_Drinks()
        {
            XmlNodeList list_drinks = _XmlDocument.SelectNodes("/Drinks");
            List<List<string>> all_drinks = new List<List<string>>();           
            
            foreach (XmlNode node in list_drinks)
            {
                if (node != null)
                {
                    foreach (XmlNode child in node.ChildNodes) 
                    {
                        if (child.ChildNodes != null) 
                        {
                            List<string> _drinks = new List<string>();
                            foreach (XmlNode child2 in child.ChildNodes)
                            {
                                string name = child2.InnerText;
                                Console.WriteLine(name);
                                _drinks.Add(name);
                            }
                            all_drinks.Add(_drinks);
                        }
                    }                    
                }
            }
            return all_drinks;
        }
        public List<string> Sherch_Drink(string name)
        {
            XmlNodeList xmlNode  = _XmlDocument.GetElementsByTagName("Name");
            List<string> arr = new List<string>();
            foreach (XmlNode node in xmlNode)
            {
                if (node.InnerText == name)
                    arr = GetAll_data(node.ParentNode); 
                    break;
            }
            return arr;            
        }
        public List<string> GetAll_data(XmlNode node)
        {
            List<string> arr = new List<string>();
            foreach (XmlNode node_ in node.ChildNodes)
            {
                arr.Add(node_.InnerText);
            }       
            return arr;
        }
        public void Updete_Drink(ItemDrink drink,string oldname )
        {
            XmlNode NodeNew = _XmlDocument.SelectSingleNode($"Drinks/Drink[Name = '{oldname}']");

            NodeNew.SelectSingleNode("Name").InnerText = drink._name;
            NodeNew.SelectSingleNode("Suger").InnerText = drink._suger.ToString();
            NodeNew.SelectSingleNode("Milk").InnerText = drink._milk.ToString();
            NodeNew.SelectSingleNode("Cofee").InnerText = drink._cofee.ToString();
            NodeNew.SelectSingleNode("Cacou").InnerText = drink._coca.ToString();
            NodeNew.SelectSingleNode("Price").InnerText = drink._price.ToString();   
            
        }
        public void Delete_Drink(string drink)
        {
            XmlNode Node = _XmlDocument.SelectSingleNode($"Drinks/Drink[Name = '{drink}' ]");                   
                    
                    
                
                Node.ParentNode.RemoveChild(Node);
                
                    
                
        }
            public void Save()
        {
            main.Save();
        }
        //public void Get_Employee_by_id(string id)
        //{
        //    XmlNode node = _XmlDocument.SelectSingleNode($" [@id = {id}]");
        //    if (node.Attributes != null)
        //    {
        //        foreach (XmlAttribute attribute in node.Attributes)
        //        {
        //            Console.WriteLine($"{attribute.Name}: {attribute.Value}");
        //        }
        //    }
        //    if (node.ChildNodes != null)
        //    {
        //        Get_All_Employee(node.ChildNodes);
        //    }
        //}
    }
}
