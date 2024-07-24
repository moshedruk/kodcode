using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest
{
    internal class Meneger
    {

        private static string sql_get_catgory = "select Name_food from Catgory";
        private static string sql_get_All_Gests = "select UserName from Person";
        private static string sql_AddNamel_Gests = "insert into Person values (@User);";
        private static string sql_Get_all_food = "select NameFood ,count(*) as amount from Geste \r\njoin Catgory on Catgory.Code = Geste.id_Catgory\r\njoin Person on Person.Code = Geste.id_Person\r\nwhere Catgory.Name_food = @nameCatgory and Person.UserName != @User\r\ngroup by Geste.NameFood";
        private static string sql_get_by_part = "select UserName from Person\r\nwhere UserName like '%' + @Part  + '%'";


        public static void Add_Name_To_ListName(string fool_Name)
        {
           
           string[] parameters = { "@User" };
           string[] values = { fool_Name };
           ConnectDB.RunSQL(sql_AddNamel_Gests, parameters, values);
           // 3. Return response
          
        }
        public static SqlDataReader Disply_add_Catgory()
        {
            SqlDataReader sqlDataReader = ConnectDB.runSQL_Disply_Catgory(sql_get_catgory);
            return sqlDataReader;
        }

        public static DataTable Get_All_Gets_frinds(string NameCatgory,string user)
        {
           DataTable dt = new DataTable();
           string[] parameters = { "@nameCatgory", "@User" };
           string[] values = { NameCatgory , user };
           ConnectDB.Get_Disply_food_MY_frinds(sql_Get_all_food, dt, parameters, values);
           return dt;
        }
        public static SqlDataReader Disply_add_Gests()
        {
            SqlDataReader sqlDataReader = ConnectDB.runSQL_Disply_Gest(sql_get_All_Gests);
            return sqlDataReader;
        }
        //public static void Get_disply_one_Catgory(string NameCatgort)
        //{
        //    string[] parameters = { "@CodeCatgory" };
        //    string[] values = { "1" };
        //    string res = ConnectDB.Get_one_Catgory(Sql_disply_one_Catgory, parameters, values);
        //    return res;
        //}
        public static SqlDataReader Disply_add_Catgory_by_Part(string part)
        {
            string[] parameters = { "@Part" };
            string[] values = { part };
            SqlDataReader sqlDataReader = ConnectDB.runSQL_Disply_Catgory_by_part(sql_get_by_part, parameters, values);
            return sqlDataReader;
        }
    }
}
