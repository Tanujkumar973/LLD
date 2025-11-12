using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Player
    {
        private int id;
        private string name;
        private int position;

        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPosition(int position)
        {
            this.position = position;
        }

        public int GetPosition()
        {
            return this.position;
        }
        
    }
}
