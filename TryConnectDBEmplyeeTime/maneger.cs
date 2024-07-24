using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;


namespace TryConnectDB
{
    internal class maneger
    {        
        private static string _loginSQL = File.ReadAllText("C:\\Users\\admin\\source\\repos\\TryConnectDB\\TextFileSQL_Login.sql");
        private static string _changePasswordSQL = File.ReadAllText("C:\\Users\\admin\\source\\repos\\TryConnectDB\\TextFileupdetePassword.sql");
        private static string sqldisply = "select * from  presence where userEmploye = @code";
       
        public static string Login(string fool_Namestring,string id, string password)
        {
            
            string[] parameters = { "@fuul_name", "@id_Employe", "@password" };
            string[] values = { fool_Namestring, id, password };
             string res = DBconnect.runSQL(_loginSQL, parameters, values);            
            return res;
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            string[] parameters = { "@id", "@Oldpassword", "@password", "@configPassword" };
            string[] values = { id, oldPass, newPass , confirmPass };
            string res = DBconnect.runSQL(_changePasswordSQL, parameters, values);            
            return res;            
        }
        public static DataTable Disply(int code) 
        {
            DataTable dt = new DataTable();
            DBconnect.runSQL(sqldisply,dt, code);
            return dt;
        }
    }
}
