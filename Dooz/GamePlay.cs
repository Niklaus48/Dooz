using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dooz
{
    class GamePlay
    {
        public static int[,] XO = new int[3, 3];

        public static int turn = 0;

        public static void Do(int user, int row, int column)
        {
            //check for location to be empty
            if (XO[row, column] != 0)
            {
                //todo
            }

            XO[row, column] = user;

            //if empty then place it
            //else choose another location



            //check if anyone wins
            if (CheckForWinner(user))
            {
                //todo
            }

            //if wins then end the game
            //else move on

            //show game result

            //send new information to server
        }

        public static bool CheckForWinner(int user)
        {
            for (int i = 0; i < 3; i++)
            {
                if (XO[i, 0] == user && XO[i, 1] == user && XO[i, 2] == user)
                {
                    return true;
                }

                if (XO[0, i] == user && XO[1, i] == user && XO[2, i] == user)
                {
                    return true;
                }

            }

            if (XO[0, 0] == user && XO[1, 1] == user && XO[2, 2] == user)
            {
                return true;
            }

            if (XO[0, 2] == user && XO[1, 1] == user && XO[2, 0] == user)
            {
                return true;
            }

            return false;

        }

        static void PrintBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    //if (XO[row, col] == 0)
                    //    Console.WriteLine(0);
                    //else if (XO[row, col] == 1)
                    //    Console.WriteLine("X");
                    //else if (XO[row, col] == 2)
                    //    Console.WriteLine("O");
                    Console.WriteLine(XO[row, col]);

                    if (col < 2)
                        Console.Write(" | ");
                }
                Console.WriteLine();
                if (row < 2)
                    Console.WriteLine("---------");
            }
        }
    }
}
