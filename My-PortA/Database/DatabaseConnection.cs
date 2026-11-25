using Azure.Identity;
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
            string connectionString = "Data Source=gruppe6.database.windows.net;Persist Security Info=False;User ID=ProgramUser;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";

            await using var connection = new SqlConnection(connectionString);

            await connection.OpenAsync();

        }




       






    }                          
}
