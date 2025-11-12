using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class BoardEntity
    {

        private int start;
        private int end;
        public BoardEntity(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public int GetStart() { return start; }
        public int GetEnd() { return end; }

    }
}
