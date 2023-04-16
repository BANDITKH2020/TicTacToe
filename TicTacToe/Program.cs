using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] playField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };


        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool checkInput = true;


            do
            {
                
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }   
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                setFeild();

                char[] playerChar = { 'X', 'O' };

                foreach(char playerChars in playerChar)
                {
                    if ((playField[0,0] == playerChars) && (playField[0,1] == playerChars) && (playField[0,2] == playerChars))
                    {
                        Console.WriteLine("\nWe have a Winner !!!");
                    }
                    else if ((playField[1, 0] == playerChars) && (playField[1, 1] == playerChars) && (playField[1, 2] == playerChars))
                    {
                        Console.WriteLine("\nWe have a Winner !!!");
                    }
                    else if ((playField[2, 0] == playerChars) && (playField[2, 1] == playerChars) && (playField[2, 2] == playerChars))
                    {
                        Console.WriteLine("\nWe have a Winner !!!");
                    }
                    else if ((playField[0, 0] == playerChars) && (playField[1, 0] == playerChars) && (playField[2, 0] == playerChars))
                    {
                        Console.WriteLine("\nWe have a Winner !!!");
                    }
                    else if ((playField[0, 1] == playerChars) && (playField[1, 1] == playerChars) && (playField[2, 1] == playerChars))
                    {
                        Console.WriteLine("\nWe have a Winner !!!");
                    }
                    else if ((playField[0, 2] == playerChars) && (playField[1, 2] == playerChars) && (playField[2, 2] == playerChars))
                    {
                        Console.WriteLine("\nWe have a Winner !!!");
                    }
                    else if ((playField[0, 0] == playerChars) && (playField[1, 1] == playerChars) && (playField[2, 2] == playerChars))
                    {
                        Console.WriteLine("\nWe have a Winner !!!");
                    }
                    else if ((playField[0, 2] == playerChars) && (playField[1, 1] == playerChars) && (playField[2, 0] == playerChars))
                    {
                        Console.WriteLine("\nWe have a Winner !!!");
                    }
                }

                do
                {                   

                    Console.Write("\nPlayer {0} : Choose youe field : ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter Number !!!");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        checkInput = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        checkInput = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        checkInput = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        checkInput = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        checkInput = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        checkInput = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        checkInput = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        checkInput = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        checkInput = true;
                    else
                    {
                        Console.WriteLine("Please use another field !!");
                        checkInput = false;
                    }


                } while (!checkInput);

                
            }while (true);
            Console.ReadKey();
        }

        public static void setFeild()
        {
            Console.Clear();
            Console.WriteLine("     |      |      ");
            Console.WriteLine("  {0}  |   {1}  |   {2}  ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");

            Console.WriteLine("  {0}  |   {1}  |   {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");

            Console.WriteLine("  {0}  |   {1}  |   {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("_____|______|______");
            Console.WriteLine("     |      |      ");
        }

        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 2)
                playerSign = 'X';
            else if (player == 1)
                playerSign = 'O';

            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }

    }
}
