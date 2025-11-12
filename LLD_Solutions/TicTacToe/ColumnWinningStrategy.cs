using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class ColumnWinningStrategy : IWinStrategies
    {
        public bool IsWinner(Symbol symbol, Cell[,] cells,int length)
        {
            bool isWinner = true;
            for (int i = 0; i < length; i++)
            {
                isWinner = true;
                for (int j=0;j<length;j++)
                {
                    if (cells[j,i].symbol != symbol)
                    {
                        isWinner = false;
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
