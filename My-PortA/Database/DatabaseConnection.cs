using Azure.Identity;
using Microsoft.Data.SqlClient;
using My_PortA.Database;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows;

namespace My_PortA.Database
{
    public class DatabaseConnection
    {

       public static async void OpenConnectionAsync() 
        {
            string connectionString = "Server = tcp:gruppe6.database.windows.net,1433;" + "Initial Catalog=DIT_DATABASENAVN;" + "User ID=ProgramUser;" + "Password=porta123!!;" + "Encrypt=True;TrustServerCertificate=False;Connection Timeout=60;"; 

            await using var connection = new SqlConnection(connectionString);

            await connection.OpenAsync();

        }




       






    }                          
}
