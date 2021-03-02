using System;
using System.Net;
using System.IO;
using System.Data.SqlClient;

namespace testdotnet
{
    class Program
    {
        public static readonly string UserName = new String("DFAWERWR345FASDFAS34fA");

        static void Main(string[] args)
        {
            var login = "root";
            var password = "A6LD9LoPRPCTpe9WKGSq";

            Console.WriteLine("Hello World!");
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

                string connectionString2 = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;User id="+ login + ";Password="+ password + ";Integrated Security=True";
                using (var connection = new System.Data.SqlClient.SqlConnection(connectionString2))
                {
                    connection.Open();
                    var command = new System.Data.SqlClient.SqlCommand("SELECT * FROM " + userTable + " WHERE UserName='" + userName + "' OR Password='" + password + "';", connection);
                }


                Console.Write(GetRequest());
            }

            Console.Write(unsec3.GetRequest());
        }

        public static string GetRequest()
        {
            var MyToken= "asdfERWQEFASDFAWERWR345FASDFAS34fASFDADSFASDF34rqwefSAFDSADFA";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.google.com");
            request.Headers.Add("authorization", "Bearer asdfERWQEFASDFAWERWR345FASDFAS34fASFDADSFASDF34rqwefSAFDSADFA");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using(Stream stream = response.GetResponseStream())
            using(StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static string GetRequest2()
        {
            var MyToken= "asdfERWQEFASDFAWERWR345FASDFAS34fASFDADSFASDF34rqwefSAFDSADFA";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.google.com");
            request.Headers.Add("authorization", "Bearer asdfERWQEFASDFAWERWR345FASDFAS34fASFDADSFASDF34rqwefSAFDSADFA");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using(Stream stream = response.GetResponseStream())
            using(StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
