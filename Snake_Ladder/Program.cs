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
            int PlayerPosition = 0;
            int start = 0;
            Console.WriteLine("Start Position:" + start);
           
            Random random = new Random();
            int roll = random.Next(0, 7);
            Console.WriteLine("After Rolling a dice"+roll);
            int Option = random.Next(0, 3);
            Console.ReadLine(); 
            if (Option == 0)
            {
                PlayerPosition = PlayerPosition - roll;
                Console.WriteLine("snake " + PlayerPosition);
            }
            else if (Option == 1)
            {
                PlayerPosition = PlayerPosition + roll;
                Console.WriteLine("ladder " + PlayerPosition);
            }
            else
            {
                Console.WriteLine("no play " + PlayerPosition);
            }
            Console.ReadLine();
        }
    }
}

