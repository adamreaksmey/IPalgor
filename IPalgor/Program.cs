using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPalgor
{
    internal class Program
    {
        public static bool valid_ip(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        static void Main(string[] args)
        {
            bool result = valid_ip("192.0.2.146");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
