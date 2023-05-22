using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yopmail.code.control
{
    public class RandomMail
    {
        private static readonly Random random = new Random();
        private static readonly string characters = "abcdefghijklmnopqrstuvwxyz0123456789";

        public static string GenerateRandom(int length)
        {
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(characters.Length);
                result.Append(characters[randomIndex]);
            }
            return result.ToString();
        }
    }
}
