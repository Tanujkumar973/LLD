using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class RowWinningStartegy : IWinStrategies
    {
        public bool IsWinner(Symbol symbol, Cell[,] cells,int length)
        {
            bool isWinner = false;
            for (int i = 0; i < length; i++)
            {
                isWinner = true;
                for (int j = 0; j < length; j++)
                {
                    if (cells[i,j].symbol != symbol)
                    {
                        return false;
                    }
                }
                if(isWinner == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
