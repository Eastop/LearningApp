using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
//using System.Data.SqlClient;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyAPP.Data
{
    public static class Utilities
    {

        public static string SHA512(string value)
        {
            var signature = string.Empty;

            SHA512 shaM = new SHA512Managed();

            byte[] messageBytes = Encoding.UTF8.GetBytes(value);
            byte[] hash = shaM.ComputeHash(messageBytes);
            for (int i = 0; i < hash.Length; i++)
            {
                signature += hash[i].ToString("x2"); // hex format
            }
            return signature;
        }


        public static string UploadImage(string imagePath)
        {
            //string imagePath = @"E:\images\sample.png";

            string imgBase64String = GetBase64StringForImage(imagePath);

            return imgBase64String;

            //return Console.WriteLine(imgBase64String);
        }

        private static string GetBase64StringForImage(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

















        //Data Source = NGLA0999LP2287; Initial Catalog = Users; Integrated Security = True


        //SqlConnection con = new SqlConnection("Server=localhost,Authentication=Windows Authentication, Database=employeedetails");
        //con.Open();
        //SqlCommand cmd;
        //string s = "delete employee where empid=103";

    }

}
