
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TestWeek3
{
    internal class ConnectDB
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-184MO21\\SQLSERVER;initial catalog=testweek3; user id=sa; password=1234;TrustServerCertificate=Yes";
        public static bool Connect()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static void RunSQL_insert(string sql, string[] parameters, List<string> values)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    if (parameters != null && values != null)
                    {
                        // Add parameters
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static string RunSQL_(string sql, string parameters, string values)
        {
            if (Connect())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    if (parameters != null && values != null)
                    {
                        // Add parameters
                        
                        
                            cmd.Parameters.AddWithValue(parameters, values);
                        
                    }

                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return "";
        }
        public static void Disply_table(string sql, DataTable dt, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public static SqlDataReader RunSQL_get(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }                    
                    SqlDataReader rdr = cmd.ExecuteReader();
                    return rdr;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;

        }
    }
}


   

        //public static SqlDataReader runSQL_Disply_Catgory(string sql)
        //{
        //    if (Connect())
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = sqlConnection;
        //            cmd.CommandText = sql;
        //            //cmd.Parameters.AddWithValue("@code", 4);
        //            //using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
        //            //adapter.Fill(dt);
        //            SqlDataReader rdr = cmd.ExecuteReader();
        //            return rdr;

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    return null;

        //}
        //public static SqlDataReader runSQL_Disply_Gest(string sql)
        //{
        //    if (Connect())
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = sqlConnection;
        //            cmd.CommandText = sql;
        //            //cmd.Parameters.AddWithValue("@code", 4);
        //            //using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
        //            //adapter.Fill(dt);
        //            SqlDataReader rdr = cmd.ExecuteReader();
        //            return rdr;

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    return null;

        //}
        //public static void Get_Disply_food(string sql, DataTable dt, string parameters, int values)
        //{
        //    if (Connect())
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = sqlConnection;
        //            cmd.CommandText = sql;
        //            cmd.Parameters.AddWithValue(parameters, values);
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
        //                adapter.Fill(dt);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        // print the CustomerID of each record

        //    }

        
        
    

