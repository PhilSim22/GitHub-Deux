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

        public static int CreateRandomTable(int lenght, int min, int max)
        {
            int[] Table = new int[lenght];
            for(int i = 0; i < lenght; ++i)
            {
                Table[i] = randomGenerator.Next(min, max + 1);
            }
            return Table;
        }
    }
}
