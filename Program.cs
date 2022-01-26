/*
 * Tic Tac Toe
 * Pawelski
 * 1/25/2022
 * Read over the code and run the program a few times to determine what
 * the program does. Once you know what the program does and how it works,
 * answer the questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[ , ] board = {{"X", "O", "X"},
                                 {"X", "X", "O"},
                                 {"O", "X", "O"}};
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("{0, -2}", board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
