using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            if (num.HasValue)
            {
                Console.WriteLine($"int has value {num.Value}");
            }
            else
            {
                Console.WriteLine("int is nullable");
            }
        }
    }
}
