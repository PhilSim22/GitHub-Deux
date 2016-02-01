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
			Utilitaire.WriteTable (Utilitaire.CreateTable(15,0,150));
			Console.WriteLine ();
        }
    }
}
