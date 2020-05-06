using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SMISSecurity
{
    class RandomString
    {
        private static String seed = "S8XQYnydI3b1Kce8yAXjKozqLm8m1bJbnWN0FLJIaD7gEVsw";

        public static void SetSeed(String s)
        {
            seed += s;
            Shuffle();
        }

        //https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/
        public static String Generate()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()abcdefghijklmnopqrtsuvwxyz" + seed;
            Random random = new Random();

            String rString = new string(Enumerable.Repeat(chars, 128)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return sha265(rString);
        }


        public static String sha265(String str)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // based on https://stackoverflow.com/questions/4739903/shuffle-string-c-sharp
        private static void Shuffle()
        {
            char[] array = seed.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            seed = new string(array);
        }
    }
}
