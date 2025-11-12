using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToe
    {
        public Board board;
        public List<IWinStrategies> wins = new List<IWinStrategies>() { new DiagonalWinningStrategy(),new ColumnWinningStrategy(), new RowWinningStartegy()};
        public static GameStatus gamestatus = GameStatus.NotStarted;
        public TicTacToe()
        {
            
        }
        public void CreateGame(int size,Player player1,Player player2)
        {
            board = new Board(3);
            board.player1 = player1;
            board.player2 = player2;
            board.initializeCells();
        }

        public bool IsValidToAssignSymbol( int row, int col)
        {
            return board.GetCellValue(row, col) == Symbol._;
        }
        public void AssignSymbol(Player player,int row,int col)
        {
            board.AssignCellValue(row, col, player);
            IsWinner(player);

        }

        public bool IsWinner(Player player)
        {
            foreach (IWinStrategies strategy in wins)
            {
                if (strategy.IsWinner(player.symbol,board.cells,3))
                {
                    gamestatus = GameStatus.Won;
                    return true;
                }
            }
            return false;
        }

    }
}
