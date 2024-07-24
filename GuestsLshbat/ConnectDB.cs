﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace GuestsLshbat
{
    internal class ConnectDB
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-184MO21\\SQLSERVER;initial catalog=Shbat; user id=sa; password=1234;TrustServerCertificate=Yes";
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
        public static string runSQL(string sql, string[] parameters, string[] values)
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
                    
                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return "";
        }
        public static SqlDataReader runSQL_Disply_Catgory(string sql)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    //cmd.Parameters.AddWithValue("@code", 4);
                    //using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    //adapter.Fill(dt);
                    SqlDataReader rdr  = cmd.ExecuteReader(); 
                    return rdr;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;

        }
        public static void Get_Disply_food(string sql, DataTable dt , string parameters, int values)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(parameters, values);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // print the CustomerID of each record

            }
            
        }
        public static SqlDataReader runSQL_Disply_Catgory_by_part(string sql_get_by_part, string[] parameters, string[] values)
        {
            if (Connect()) 
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql_get_by_part;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameters[i], values[i]);
                    }
                    //cmd.Parameters.AddWithValue("@code", 4);
                    //using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    //adapter.Fill(dt);
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
        
        public static string Get_one_Catgory(string sql, string[] parameters, string[] values) 
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
                    object result = cmd.ExecuteScalar();
                    string nameFood = result.ToString();
                    Console.WriteLine(nameFood);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return ex.Message;
                }
            }
            return "";

        }
    }
}
