using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Deux
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGen = new Random();

            for(int i = 0; i < 10; ++i)
            {
                Console.WriteLine(randomGen.Next(0, 151));
            }
            Console.ReadLine();
        }
    }
}
