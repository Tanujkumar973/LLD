using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Dice
    {
        private static readonly Random random = new Random();
        private int start;
        private int end;
        public Dice(int Start, int End)
        {
            start = Start;
            end = End;
        }
        public int Roll()
        {
            return random.Next(start, end+1);
        }
    }
    
}
