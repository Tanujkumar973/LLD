using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        public Cell[,] cells;
        public Player player1;
        public Player player2;
        int boardSize;

        public Board(int size)
        {
            boardSize = size;
            this.cells = new Cell[size,size];
        }

        public void initializeCells()
        {
            for(int i = 0; i < boardSize; i++)
            {
                for(int j=0;j< boardSize; j++)
                {
                    cells[i, j] = new Cell();
                }
            }
        }

        public Symbol GetCellValue(int row,int col)
        {
            return cells[row, col].symbol;
        }

        public void AssignCellValue(int row,int col,Player player)
        {
            cells[row, col].symbol = player.symbol;
        }



    }
}
