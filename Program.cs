using System;
using System.Net;
using System.IO;
using System.Data.SqlClient;

namespace testdotnet
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Test(){
		    var login = "root";
            var password = "A6LD9LoPRPCTpe9WKGSq";
            if (login == "root")
            {
                Console.WriteLine(password);
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine(123/n);
                
                var sql= "SELECT * FROM Users WHERE id=" + n.ToString() + ";";
                Console.WriteLine("SELECT * FROM Users WHERE id=" + n.ToString() + ";");
                var unused = "unused";
                
                string path = Console.ReadLine();
        
                if(File.Exists(path)){
                    var test = File.OpenRead(path);
                }
                Console.Write(System.IO.File.ReadAllText(path));


                string userName = Console.ReadLine();
                string userTable = System.Environment.GetEnvironmentVariable("UserTable", EnvironmentVariableTarget.User);
                var sql2= "SELECT * FROM " + userTable + " WHERE UserName='" + userName + "';";

                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;User id="+ login + ";Password="+ password + ";Integrated Security=True";
                using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new System.Data.SqlClient.SqlCommand("SELECT * FROM " + userTable + " WHERE UserName='" + userName + "';", connection);
                }
            }
			

        }
    }
}
