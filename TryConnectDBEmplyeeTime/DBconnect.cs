using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace TryConnectDB
{
    internal class DBconnect
    {
        // string connect to my DB
        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-184MO21\\SQLSERVER;initial catalog=master; user id=sa; password=1234;TrustServerCertificate=Yes";
        // fun connect and open
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
        // fun servis into my DB and create parameyrs
        public static string runSQL(string sql, string[] parameters, string[] values)
        {
            if (Connect())
            {                
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    
                    // Add parameters
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameters[i], values[i]);
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
        // fun servis into my DB  and get data in SqlDataAdapter
        public static void runSQL(string sql,DataTable dt, int code) 
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@code", code);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        adapter.Fill(dt);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
