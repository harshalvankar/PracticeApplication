using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApplication
{
    public class Base64Encrypter
    {
        public static string Encrypt(string data)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(data);
            var plainTextBytes1 = System.Text.Encoding.UTF8.GetBytes(Convert.ToBase64String(plainTextBytes));
            var plainTextBytes2 = System.Text.Encoding.UTF8.GetBytes(Convert.ToBase64String(plainTextBytes1));

            return Convert.ToBase64String(plainTextBytes2);
        }
        public static string Decrypt(string data)
        {
            var plainTextBytes = System.Convert.FromBase64String(data);
            var plainTextBytes1 = System.Convert.FromBase64String(Encoding.UTF8.GetString(plainTextBytes));
            var plainTextBytes2 = System.Convert.FromBase64String(Encoding.UTF8.GetString(plainTextBytes1));
                       
            return System.Text.Encoding.UTF8.GetString(plainTextBytes2);
        }
    }
}
