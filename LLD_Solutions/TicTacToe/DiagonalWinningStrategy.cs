using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class DiagonalWinningStrategy : IWinStrategies
    {
        public bool IsWinner(Symbol symbol, Cell[,] cells, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (cells[i,i].symbol != symbol)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
