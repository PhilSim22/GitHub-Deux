using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Deux
{
    static class Utilitaire
    {
        static Random randomGenerator = new Random();

		public static void WriteTable(int [] table)
		{
			for (int i = 0; i < table.Length; ++i) 
			{
				Console.WriteLine (table [i]);
			}
		}
    }
}
