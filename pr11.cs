using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace testdotnet
{
    public class unsec11
    {
        public static string GetRequest()
        {
            var login = "root";
            var password = "A6LD9LoPRPCTpe9WKGSq";
            Console.WriteLine("Hello World!");
            if (login == "root")
            {
                Console.WriteLine(password);
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine(123 / n);
                var sql = "SELECT * FROM Users WHERE id=" + n.ToString() + ";";
                Console.WriteLine("SELECT * FROM Users WHERE id=" + n.ToString() + ";");
                var unused = "unused";

                string path = Console.ReadLine();
                Console.Write(System.IO.File.ReadAllText(path));

                var sql2 = "SELECT * FROM Users WHERE id=" + n.ToString() + ";";

                Console.Write(GetRequest());
            }

            return "";
        }
    }
}
