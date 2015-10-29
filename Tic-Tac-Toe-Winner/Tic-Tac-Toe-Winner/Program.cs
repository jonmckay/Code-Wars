using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Winner
{
    class Program
    {
        static void Main(string[] args)
        {
        }



        private static string CalculateWinner(string board, int positionOne, int positionTwo, int positionThree)
        {
            if (board.ElementAt(positionOne).ToString() == "x" && board.ElementAt(positionTwo).ToString() == "x" && board.ElementAt(positionThree).ToString() == "x")
            {
                return "x";
            }
            if (board.ElementAt(positionOne).ToString() == "o" && board.ElementAt(positionTwo).ToString() == "o" && board.ElementAt(positionThree).ToString() == "o")
            {
                return "o";
            }
            return "";
        }

        public static string TicTacToeWinner(string board)
        {
            
            var xWins = false;
            var oWins = false;
            if ("" == board) return null;
            if (CalculateWinner(board, 0, 1, 2) == "x" ||
                CalculateWinner(board, 0, 5, 10) == "x" ||
                CalculateWinner(board, 0, 4, 8) == "x" ||
                CalculateWinner(board, 1, 5, 9) == "x" ||
                CalculateWinner(board, 2, 5, 8) == "x" ||
                CalculateWinner(board, 2, 6, 10) == "x" ||
                CalculateWinner(board, 4, 5, 6) == "x" ||
                CalculateWinner(board, 8, 9, 10) == "x")
            {
                xWins = true;
            }
            if (CalculateWinner(board, 0, 1, 2) == "o" ||
                CalculateWinner(board, 0, 5, 10) == "o" ||
                CalculateWinner(board, 0, 4, 8) == "o" ||
                CalculateWinner(board, 1, 5, 9) == "o" ||
                CalculateWinner(board, 2, 5, 8) == "o" ||
                CalculateWinner(board, 2, 6, 10) == "o" ||
                CalculateWinner(board, 4, 5, 6) == "o" ||
                CalculateWinner(board, 8, 9, 10) == "o")
            {
                oWins = true;
            }

            if (xWins && !oWins)
            {
                return "Player X is the winner";
            }
            if (oWins && !xWins)
            {
                return "Player O is the winner";
            }
            return "Game is a tie";
        }
    }
}
