using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Cell
    {
        public Symbol symbol;
        public Cell()
        {
            symbol = Symbol._;
        }
        public Symbol GetCellValue()
        {
            return this.symbol;
        }
    }
}
