using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Data.SqlClient;

class ADONetExample
{

    private string connectionString = "Server=tcp:plasqlserver.database.windows.net,1433;Initial Catalog=person;Persist Security Info=False;User ID=ramesh;Password=PL11!!LP;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public void ConnectToDatabase()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection Opened Successfully.");
                
                string query = "SELECT * FROM People"; // Replace with your actual query

                using (SqlCommand sQLCommand = new SqlCommand(query, connection))
                using (SqlDataReader reader = sQLCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Displaying Person Name: " + reader["FirstName"] + reader["LastName"]); // Replace with your actual column names
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection Closed.");
            }
        }

    }
}