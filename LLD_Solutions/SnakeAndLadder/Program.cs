using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(1,6);
         
             
           
            Dictionary<int, int> ladders = new Dictionary<int, int>();
       
            List<BoardEntity> entities = new List<BoardEntity>() { new Snake(11, 2) ,new Snake(24,12),new Snake(49,21), new Snake(75,21), 
                new Snake(95,72),new Ladder(7, 14), new Ladder(29, 54), new Ladder(36, 74), new Ladder(68,99)};
            Board board = new Board(entities, 100);
            Player player1 = new Player(21, "Ramesh");
            Player player2 = new Player(28, "Suresh");
            Game game = new Game(board,new List<Player>() { player1, player2 }, dice);
            while(game.status == GameStatus.InProgress)
            {
                game.Play();
            }
            Console.ReadLine();

        }
    }
}
