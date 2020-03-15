using System;
/*
 * This program allows one player to play against the computer.
 * The computer does not use any intelligence it just plays in an empty spot.
 */
namespace TicTacToe
{
    class Program
    {
        public static void PrintBoard(Char []board)
        {
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine("__"+ "" + "__" + "" + "__");
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine("__" + "" + "__" + "" + "__");
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }
        public static  bool IsWinner(char symbol,char []board)
        {
            return (board[0]==board[1]&&board[0] == board[2]&& board[2]==symbol) || (board[3] == board[4] && board[3] == board[5] && board[5] == symbol) ||
                (board[6] == board[7] && board[7] == board[8] && board[8] == symbol) || (board[0] == board[4] && board[4] == board[8] && board[8] == symbol) ||
                (board[2] == board[4] && board[4] == board[6] && board[6] == symbol) || (board[0] == board[3] && board[3] == board[6] && board[6] == symbol) ||
                (board[1] == board[4] && board[4] == board[7] && board[7] == symbol) || (board[2] == board[5] && board[5] == board[8] && board[8] == symbol);
        }
        public static bool IsGameOver(char []board)
        {
            return IsFull(board) || IsWinner('X', board) || IsWinner('O', board);
        }
        
        public static bool IsFull(char []board)
        {
            
            for(int i=0; i <board.Length; i++)
            {
                if (board[i] == ' ')
                    return false;
            }
            return true;
        }
        public static void MarkPosition(char[] board)
        {
            for(int i=0; i < board.Length; i++)
            {
                if(board[i]==' ')
                {
                    board[i] = 'O';
                    return;
                }
            }
        }
        public static  void Game(char []board)
        {
            Console.WriteLine("Playing against computer");
            char turn = 'X';
            while (!IsGameOver(board))
            {
                if (turn == 'O')
                {
                    MarkPosition(board);
                    turn = 'X';
                }
                else
                {
                    Console.WriteLine("Enter position 0-9:");
                    int position = Convert.ToInt32(Console.ReadLine());
                    while (board[position] != ' ')
                    {
                        Console.WriteLine("Invalid position! Enter position 0-9:");
                        position = Convert.ToInt32(Console.ReadLine());

                    }
                    board[position] = 'X';
                    turn = 'O';
                }
                PrintBoard(board);
                
            }
            if (IsWinner('X', board))
                Console.WriteLine("You won!");
            else
                Console.WriteLine("Computer won!");
                
        }
        static void Main(string[] args)
        {
            Char[] board = {' ',' ',' ',' ',' ',' ',' ',' ',' ' };
            PrintBoard(board);
            Game(board);
            //Console.WriteLine(IsWinner(board));
        }
    }
}
