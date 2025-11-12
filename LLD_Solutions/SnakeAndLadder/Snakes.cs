using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Snake : BoardEntity
    {
        public Snake(int start,int end) : base(start,end)
        {
            if(end >= start)
            {
                throw new ArgumentException("Snake start head position cannot be less than tail position");
            }
        }
    }
}
