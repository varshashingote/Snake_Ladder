using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            Console.WriteLine("Start Position:" + start);
           
            Random random = new Random();
            int roll = random.Next(0, 7);
            Console.ReadLine();


        }

    }
    }
}
