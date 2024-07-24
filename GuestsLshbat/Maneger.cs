using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GuestsLshbat
{
    internal class Maneger
    {
        private static string sql_get_allFood = "select count(*)as amount, NameFood  from Geste \r\nwhere Geste.id_Catgory = @NameCodeCatgory\r\ngroup by Geste.NameFood";
        private static string Sql_disply_one_Catgory = "declare @res varchar(25)\r\nselect @res = (\r\nselect Name_food  from Catgory \r\nwhere Catgory.Code = @CodeCatgory )\r\nselect @res";
        private static string sql_get_catgory = "select Name_food from Catgory";
        private static string script_insert_Sql = "declare @answer varchar(25) =  'Successfully registered'\r\nif not EXISTS (select Name_food from Catgory where Name_food = @fool_NameCatgort )\r\n\tBEGIN\r\n\t\tinsert into Catgory values (@fool_NameCatgort);\r\n\tEND\r\nelse\r\n\tBEGIN\r\n\t\tselect @answer = 'Already exists'\r\n\tEND\r\nselect @answer";
        private static string _loginSQL = File.ReadAllText("C:\\Users\\admin\\source\\repos\\TryConnectDB\\TextFileSQL_Login.sql");
        private static string _changePasswordSQL = File.ReadAllText("C:\\Users\\admin\\source\\repos\\TryConnectDB\\TextFileupdetePassword.sql");
        private static string sql_get_by_part = "select Name_food from Catgory\r\nwhere Name_food like '%' + @Part  + '%'";


        public static string AddCatgort(string fool_NameCatgort)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@fool_NameCatgort" };
            string[] values = { fool_NameCatgort };
            string res = ConnectDB.runSQL(script_insert_Sql, parameters, values);
            // 3. Return response
            return res;
        }   

        public static DataTable Disply_food(int index)
        {
            DataTable dt = new DataTable();
            string parameters =  "@NameCodeCatgory" ;
            int values =  index ;
            ConnectDB.Get_Disply_food(sql_get_allFood, dt, parameters, values);
            return dt;
        }
        public static SqlDataReader Disply_add_Catgory() 
        {
            SqlDataReader sqlDataReader = ConnectDB.runSQL_Disply_Catgory(sql_get_catgory);
            return sqlDataReader;
        }
        public static string Get_disply_one_Catgory(string NameCatgort)
        {
            string[] parameters = { "@CodeCatgory" };
            string[] values = {"1"};
            string res = ConnectDB.Get_one_Catgory(Sql_disply_one_Catgory, parameters , values);
            return res;
        }
        public static SqlDataReader Disply_add_Catgory_by_Part(string part) 
        {
            string[] parameters = {"@Part"};
            string[] values = { part };
            SqlDataReader sqlDataReader = ConnectDB.runSQL_Disply_Catgory_by_part(sql_get_by_part, parameters, values);
            return sqlDataReader;
        }

    }
}
