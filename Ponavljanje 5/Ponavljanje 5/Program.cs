using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Upisite URL adresu");
            str = Console.ReadLine();

            if (str.Substring(0, 4) == "www." && str.Substring(str.Length - 3) == ".hr")
            {
                Console.WriteLine("URL je tocan");
            }
            else
            {
                Console.WriteLine("URL nije tocan");
            }
            Console.ReadKey();
        }
    }
}
