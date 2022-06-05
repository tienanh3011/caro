using System;

namespace Tic_tac_toe
{
    class Caro
    {
        static char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        static int player=1;
        static char playerchar1 = 'X';
        static char playerchar2 = 'O';
        static int pos;
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Toc Toe Ver 0.0");
            Console.WriteLine("Player1({0}) vs Player({1})", playerchar1, playerchar2);
            Board();
        }
        private static char getplayerchar(char c)
        {
            if (c=='-')
            {
                return ' ';
            }
            return c
;        }
        private static void Board()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", getplayerchar(board[0]), getplayerchar(board[1]), getplayerchar(board[2]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", getplayerchar(board[4]), getplayerchar(board[5]), getplayerchar(board[6]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", getplayerchar(board[7]), getplayerchar(board[8]), getplayerchar(board[9]));
        }
    }
}
