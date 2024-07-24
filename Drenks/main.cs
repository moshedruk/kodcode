using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Drenk
{
    internal class main
    {
        public static string _pathString;
        public static XmlDocument xmlDocument;
        public main() { }
        public static XmlDocument Main()
        {
            string pathString = Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\XMLDreank.xml";
            _pathString = pathString;
            // לבדוק אם הקובץ קיים
            if (File.Exists(pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathString);
                xmlDocument = xmlDoc;
                return xmlDoc;
            }
            return null;
        }
        public static void Save()
        {
            xmlDocument.Save(_pathString);
        }
    }
}
