using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake_Ladder
{
    internal class Program
    {
        public const int SNAKE = 2;
        public const int LADDER = 1;
        public const int NOPLYER = 0;
        public const int Player1 = 1;
        public const int Player2 = 2;
        public const int Dice = 0;



        public  static int positionCheck(int Dice, int position, int optionCheck)
        {
            if ((optionCheck == LADDER) && (position + Dice) <= 100)
            {
                Console.WriteLine("Ladder");
                position = position + Dice;
            }

            else if (optionCheck == SNAKE)
            {
                Console.WriteLine("Snake");
                position = position - Dice;
            }
            else
            {
                Console.WriteLine("No Play");
            }
            if (position < 0)
                position = 0;
            Console.WriteLine("position: " + position);
            return position;

        }
            static void Main(String[] args)
            {
            int playerOnePosition = 0;
            int playerTwoPosition = 0;
            int player = Player1;
            Console.WriteLine("playerOnePosition: " + playerOnePosition);
            Console.WriteLine("playerTwoPosition: " + playerTwoPosition);
            Random ran = new Random();
            while ((playerOnePosition < 100) && (playerTwoPosition < 100))
            {

                int dice = ran.Next(0, 7);
                Console.WriteLine("dice: " + dice);
                ++dice;

                int optionCheck = ran.Next(0, 3);
                Console.WriteLine("optionCheck: " + optionCheck);

                if (player == Player1)
                {

                    playerOnePosition = positionCheck(dice, playerOnePosition, optionCheck);
                    if ((optionCheck == SNAKE) || (optionCheck == NOPLYER))
                    {
                        player = Player2;
                        Console.WirteLine("player is:"+player);
                    }
                }
                else if (player == Player2)
                {
                    playerTwoPosition = positionCheck(dice, playerTwoPosition, optionCheck);
                    if ((optionCheck == SNAKE) || (optionCheck == NOPLYER))
                    {
                        player = Player1;
                        Console.WriteLine("player is"+player);
                    }
                }

            }
            Console.ReadLine();
            Console.WriteLine("Player One Position: " + playerOnePosition);
            Console.WriteLine("Player Two Position" + playerTwoPosition);
            Console.WriteLine("diceCount: " + Dice);
            if (playerOnePosition == 100)
            {
                Console.WriteLine("Player One Wins");
            }
            else
            {
                Console.WriteLine("Player Two Wins");
            }
                Console.ReadLine();

        }
    }
}
    
   

   
