using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Ladder : BoardEntity
    {
        public Ladder(int start, int end) : base(start, end)
        {
            if (end <= start)
            {
                throw new ArgumentException("Ladder tail position cannot be less than head position");
            }
        }
    }
}
