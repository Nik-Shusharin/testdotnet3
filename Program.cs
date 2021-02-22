using System;
using System.Net;
using System.IO;

namespace testdotnet
{
    class Program
    {
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
                Console.Write(System.IO.File.ReadAllText(path));

                var sql2= "SELECT * FROM Users WHERE id=" + n.ToString() + ";";

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
    }
}
