using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project_try
{
    internal class Employe
    {
        public Employe( ) 
        {
        }

        public void Get_age()
        {
            
        }

        public int Current_year { get; set; }
        public int age
        {
            get
            {
                return DateTime.Now.Year - Date_of_birth.Year;
            }
            set
            { }
        }
        public string _first_name;
        public string _last_name;
        private string id_number;
        public string Id
        {
            get
            {
                return id_number;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 9 || !Regex.IsMatch(value, @"^\d{9}$"))
                {
                    throw new ArgumentException("is id is unvalid");
                }
                id_number = value;
            }
        }
        public string First_Name { 
            get
            {
                return _first_name;
            }
            set 
            {
                
                if (string.IsNullOrEmpty(value) || Regex.IsMatch(value, @"[^a-zA-Z]")) 
                {
                    throw new ArgumentException("is First name is unvalid");
                }
                _first_name = value;
            }
        }
        public string Last_name {
            get
            {
                return _last_name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || Regex.IsMatch(value, @"[^a-zA-Z]"))
                {
                    throw new ArgumentException("is last name is unvalid");
                }
                _last_name = value;
            }
        }
        public DateTime Date_of_birth { get; set; }
        public string address { get; set; }
        public int Home_phone { get; set; }
        public int phone { get; set; }
        public string city { get; set; }
        public int number_address { get; set; }
        public bool is_male_status { get; set; }
        public string status { get; set; }
        public int code { get; set; }
        public string image { get; set; }


    }
}
