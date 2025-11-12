using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe.gamestatus = GameStatus.InProgress;
            Player player1 = new Player("tanuj", Symbol.X);
            Player player2 = new Player("deepika", Symbol.O);

            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.CreateGame(2, player1, player2);

            if (TicTacToe.gamestatus == GameStatus.InProgress && ticTacToe.IsValidToAssignSymbol( 0, 0))
            {
                ticTacToe.AssignSymbol(player1, 0, 0);
            }
            if (TicTacToe.gamestatus == GameStatus.InProgress &&  ticTacToe.IsValidToAssignSymbol(0, 2))
            {
                ticTacToe.AssignSymbol(player2, 0, 2);
            }

            if (TicTacToe.gamestatus == GameStatus.InProgress &&  ticTacToe.IsValidToAssignSymbol(1, 0))
            {
                ticTacToe.AssignSymbol(player1, 1, 0);
            }
            if (TicTacToe.gamestatus == GameStatus.InProgress &&  ticTacToe.IsValidToAssignSymbol(1, 2))
            {
                ticTacToe.AssignSymbol(player2, 1, 2);
            }
            if (TicTacToe.gamestatus == GameStatus.InProgress &&  ticTacToe.IsValidToAssignSymbol(2, 0))
            {
                ticTacToe.AssignSymbol(player1, 2, 0);
            }
            Console.WriteLine(TicTacToe.gamestatus);
          
         

        }
    }
}
