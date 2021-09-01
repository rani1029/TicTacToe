using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        public static void CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }

        }
        public static void PlayerMove()
        {
            Console.WriteLine("Enter O or X to play your move");
            String PlayersMove = Console.ReadLine();
            Console.WriteLine("player move is :" + PlayersMove);
        }
        public static void ComputerMove()
        {
            Console.WriteLine("its Computer turn to play move");
            Random rm = new Random();
            int ComputersMove = rm.Next(1, 3);
            if (ComputersMove == 1)
                Console.WriteLine("Computers move is :" + "O");
            else
                Console.WriteLine("Computers move is :" + "X");

        }




    }
}
