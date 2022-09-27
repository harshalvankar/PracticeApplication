using System;
using System.Security.Cryptography;

namespace PracticeApplication
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string key = Guid.NewGuid().ToString();

            string data = "b3HQPsY3UBi98nlZUqLCy9Z5WWppR0cO";

            string data2 = Base64Encrypter.Encrypt(data);
            string data3 = Base64Encrypter.Decrypt(data2);

            Console.WriteLine(data);
            Console.WriteLine(data2);
            Console.WriteLine(data3);

            //Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
            //Console.WriteLine(FormatDate(DateTime.Now));
            //Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture);
            //Console.ReadLine();
        }
        public static string FormatDate(DateTime dateTime)
        {
            return string.Format(Convert.ToString(dateTime), "dd:MM:yyyy hh:MI:ss");
        }
    }
}
