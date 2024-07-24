using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodKod
{
    internal class Item
    {
        public string _day;
        public string _dayMonth;
        public string _Month;
        public string _year;
        
        public Item(string day, string dayMonth, string Month, string year)
        {
            _day = day;
            _dayMonth = dayMonth;
            _Month = Month;
            _year = year;           
        }
    }
}
