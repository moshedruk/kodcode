using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KodKod
{
    internal class Meneger_Ctuva
    {
        public static string _pathString;
        public static XmlDocument _XmlDocument;

        public static Dictionary<string, string> country = new Dictionary<string, string>();

        // add items to dictionary
        
        public Meneger_Ctuva() 
        {
            country.Add("ראשון", "באחד");
            country.Add("שני", "בשני");
            country.Add("שלישי", "בשלישי");
            country.Add("רביעי", "ברביעי");
            country.Add("חמישי", "בחמישי");
            country.Add("ששי", "בששי");

            country.Add("1", " יום אחד");
            country.Add("2", "שני ימים");
            country.Add("3", " שלשה ימים");
            country.Add("4", "ארבעה ימים");
            country.Add("5", "חמשה ימים");
            country.Add("6", "ששה ימים");
            country.Add("7", "אחד");
            country.Add("8", " שמנה ימים");
            country.Add("9", "תשעה ימים");
            country.Add("10", "עשרה ימים");
            country.Add("11", "אחד עשר יום");
            country.Add("12", "שנים עשר יום");
            country.Add("13", "שלשה עשר יום");
            country.Add("14", "ארבעה עשר יום");
            country.Add("15", " חמשה עשר יום");
            country.Add("16", "ששה עשר יום");
            country.Add("17", "שבעה עשר יום");
            country.Add("18", "שמנה עשר יום");
            country.Add("19", "תשעה עשר יום");
            country.Add("20", "עשרים יום");
            country.Add("21", "אחד ועשרים יום");
            country.Add("22", "שנים ועשרים יום ");
            country.Add("23", "שלשה ועשרים יום");
            country.Add("24", "ארבעה ועשרים יום");
            country.Add("25", "חמשה ועשרים יום");
            country.Add("26", "ששה ועשרים יום");
            country.Add("27", "שבעה ועשרים יום");
            country.Add("28", "שמנה ועשרים יום");
            country.Add("29", " תשעה ועשרים יום");
            country.Add("30", "יום שלושים");

            country.Add("תשרי", "תשרי");
            country.Add("מרחשוון", "מרחשון");
            country.Add("כסלו", "כסלו");
            country.Add("טבת", "טבת");
            country.Add("שבט", "שבט");
            country.Add("אדר", "אדר");
            country.Add("אדר הראשון", "אדר הראשון");
            country.Add("אדר השני", "אדר השני");
            country.Add("ניסן", "ניסן");
            country.Add("אייר", "אייר");
            country.Add("סייון", "סייון");
            country.Add("תמוז", "תמוז");
            country.Add("אב", "אב");
            country.Add("אלול", "אלול");
        }

        
        public static XmlDocument Main()
        {
            string pathString = Path.Combine(Directory.GetCurrentDirectory(), @"..\") + "\\XMLRabnut.xml";
            _pathString = pathString;
            // לבדוק אם הקובץ קיים
            if (File.Exists(pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathString);
                _XmlDocument = xmlDoc;
                return xmlDoc;
            }
            else 
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode Queries = xmlDoc.CreateElement("Queries");
                xmlDoc.AppendChild(Queries);
                xmlDoc.Save(pathString);
            }
            return null;
        }
        public static string CreateDrinkElement(Item obj)
        {
            

            XmlElement QueryElement = _XmlDocument.CreateElement("Query");
            XmlElement nameElement = _XmlDocument.CreateElement("Day");
            nameElement.InnerText = obj._day;
            QueryElement.AppendChild(nameElement);

            XmlElement DayMonthElement = _XmlDocument.CreateElement("DayMonth");
            DayMonthElement.InnerText = obj._dayMonth;
            QueryElement.AppendChild(DayMonthElement);

            XmlElement MonthElement = _XmlDocument.CreateElement("Month");
            MonthElement.InnerText = obj._Month;
            QueryElement.AppendChild(MonthElement);

            XmlElement YearElement = _XmlDocument.CreateElement("Year");
            YearElement.InnerText = obj._year;
            QueryElement.AppendChild(YearElement);

            XmlElement ResultElement = _XmlDocument.CreateElement("Result");
            ResultElement.InnerText = $" {country[obj._day].ToString()} בשבת  {country[obj._dayMonth].ToString()} לירח  {country[obj._Month].ToString()} ";
            QueryElement.AppendChild(ResultElement);
            string res = ResultElement.InnerText;



            XmlElement newQueryElement = QueryElement;

            // הוספת הצומת החדש למסמך
            _XmlDocument.DocumentElement.AppendChild(newQueryElement);
            // שמירת המסמך המעודכן
            _XmlDocument.Save(_pathString);
            return res;

        }
       


    }
}
