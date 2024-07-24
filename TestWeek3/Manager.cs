using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;
using System.Xml;

namespace TestWeek3
{
    internal class Manager
    {

        private static string sql_insert_Title = "INSERT INTO Title\r\nVALUES\t(@nameTitle, @data, @num ,@time ,@price)";
        private static string sql_disply = "select * from Title";
        private static string sql_insert_Teachers = "INSERT INTO Teachers\r\nVALUES\t(@NameTeacher, @priceTeacher)";
        private static string sql_disply_Teachers = "select NameTeacher,priceTeacher from Teachers";
        private static string sql_get_name_Teachers = "select NameTeacher from Teachers";
        private static string sql_get_name_Title = "select sdegreeNane from Title";
        private static string sql_insert_new_curses = "declare @Namecode_Teachers varchar(25) = (select Code from Teachers\r\nwhere Teachers.NameTeacher = @input_user_Teachers)\r\n\r\ndeclare @Namecode_Title varchar(25) = (select Code from Title\r\nwhere Title.sdegreeNane = @input_user_title)\r\n\r\nINSERT INTO course\r\nVALUES\t(@VALUE1, @VALUE2,@VALUE3,@Namecode_Teachers,@Namecode_Title )";
        private static string sql_disply_by_Teache = "declare @Namecode_Teachers varchar(25) = (select Code from Teachers\r\nwhere Teachers.NameTeacher = @input_user_Teachers)\r\nselect * from course\r\njoin Title on Title.Code = course.code_Title\r\nwhere TeacherCode = @Namecode_Teachers";
        private static string sql_disply_all_curses_by_title = "declare @Namecode_Title varchar(25) = (select Code from Title\r\nwhere Title.sdegreeNane = @input_user_title)\r\nselect * from course\r\njoin Title on Title.Code = course.code_Title\r\nwhere code_Title = @Namecode_Title";
        private static string sql_add_new_student = "INSERT INTO Students\r\nVALUES\t(@New_Name)";
        private static string sql_get_names_student = "select NameStudent from Students";
        private static string sql_get_names_curses = "select courseName from course";
        private static string sql_add_curses_to_student = "declare @Namecode_stusent varchar(25) = (select Code from Students\r\nwhere Students.NameStudent = @input_user_Name)\r\n\r\ndeclare @Namecode_curses varchar(25) = (select Code from course\r\nwhere course.courseName = @input_user_curses)\r\n\r\ndeclare @price varchar(25) = (select price from course\r\nwhere course.courseName =@input_user_curses )\r\nINSERT INTO courses_for_Students\r\nVALUES\t(@Namecode_stusent,@Namecode_curses,@price)";
        private static string sql_get_all_price_for_my = "declare @Namecode_stusent varchar(25) = (select Code from Students\r\nwhere Students.NameStudent = @input_user_Name)\r\n\r\nselect sum(price) from courses_for_Students\r\nwhere NameStudent = @Namecode_stusent";

        public static DataTable disply_all_title()
        {
            DataTable dt = new DataTable();           
            ConnectDB.Disply_table(sql_disply, dt);
            return dt;
        }
        public static DataTable disply_all_curses_byTeache(string[] values)
        {
            DataTable dt = new DataTable();
            string[] parameters = { "@input_user_Teachers" };
            string[] Values = values;
            ConnectDB.Disply_table(sql_disply_by_Teache, dt, parameters, Values);
            return dt;
        }
        public static DataTable disply_all_curses_byT_title(string[] values)
        {
            DataTable dt = new DataTable();
            string[] parameters = { "@input_user_title" };
            string[] Values = values;
            ConnectDB.Disply_table(sql_disply_all_curses_by_title, dt, parameters, Values);
            return dt;
        }
        public static DataTable disply_all_Teachers()
        {
            DataTable dt = new DataTable();
            ConnectDB.Disply_table(sql_disply_Teachers, dt);
            return dt;
        }
        public static void Add_Title(List<string> fool_parameters)
        {
            List<string> values = new List<string>();
            string[] parameters = { "@nameTitle", "@data", "@num", "@time", "@price" };
            values =  fool_parameters ;
            ConnectDB.RunSQL_insert(sql_insert_Title, parameters, values);
            
        }
        public static void Add_student(string fool_parameters)
        {
            List<string> values = new List<string>();
            string[] parameters = { "@New_Name" };
             values.Add(  fool_parameters );
            ConnectDB.RunSQL_insert(sql_add_new_student, parameters, values);
            

        }
        public static void Add_curses(List<string> fool_parameters)
        {
            List<string> values = new List<string>();
            string[] parameters = { "@VALUE1", "@VALUE2","@VALUE3", "@input_user_Teachers", "@input_user_title" };
            values = fool_parameters;
            ConnectDB.RunSQL_insert(sql_insert_new_curses, parameters, values);
            

        }
        public static void Add_curses_to_student(List<string> fool_parameters)
        {
            List<string> values = new List<string>();
            string[] parameters = { "@input_user_Name", "@input_user_curses" };
            values = fool_parameters;
            ConnectDB.RunSQL_insert(sql_add_curses_to_student, parameters, values);
            

        }
        public static void Add_Teacher(List<string> fool_parameters)
        {
            List<string> values = new List<string>();
            string[] parameters = { "@priceTeacher", "@NameTeacher" };
            values = fool_parameters;
            ConnectDB.RunSQL_insert(sql_insert_Teachers, parameters, values);
            

        }
        public static string Get_price(string Name)
        {
            string parameters = "input_user_Name";
            string values = Name;
            string res = ConnectDB.RunSQL_(sql_get_all_price_for_my, parameters, values);
            return res;
        }

        public static SqlDataReader Get_name_student()
        {
            SqlDataReader sqlDataReader = ConnectDB.RunSQL_get(sql_get_names_student);
            return sqlDataReader;
        }
        public static SqlDataReader Get_name_Teachers()
        {
            SqlDataReader sqlDataReader = ConnectDB.RunSQL_get(sql_get_name_Teachers);
            return sqlDataReader;
        }
        public static SqlDataReader Get_name_curses()
        {
            SqlDataReader sqlDataReader = ConnectDB.RunSQL_get(sql_get_names_curses);
            return sqlDataReader;
        }
       
        public static SqlDataReader Get_name_Title()
        {
            SqlDataReader sqlDataReader = ConnectDB.RunSQL_get(sql_get_name_Title);
            return sqlDataReader;
        }       
    }
}
