using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolegame
{
    internal class Rand
    {
        public static int GenerateRandomNumber()
        {
            Random rand = new Random();
            int num = rand.Next(1, 101);
            return num;
        }
    }
}
