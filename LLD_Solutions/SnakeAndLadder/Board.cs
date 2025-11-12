using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Board
    {
        private Dictionary<int,int> snakesAndLadders = new Dictionary<int, int>();
        public int size;

        public Board(List<BoardEntity> boardEntities, int size)
        {

            foreach (BoardEntity entity in boardEntities)
            {
                snakesAndLadders[entity.GetStart()] = entity.GetEnd();
            }
            this.size = size;
        }
        public int GetFinalPosition(int currentPosition)
        {

                if (snakesAndLadders.ContainsKey(currentPosition))
                {
                    Console.WriteLine($"Moved from {currentPosition} to {snakesAndLadders[currentPosition]}");
                    return snakesAndLadders[currentPosition];
                }
            
            return currentPosition;
        }
    }
}
