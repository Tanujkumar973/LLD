using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Game
    {
        private Queue<Player> _players = new Queue<Player>();
        private Board _board;
        public GameStatus status;
        private Dice _dice;
        public Game(Board board,List<Player> players,Dice dice)
        {
            _board = board;
            _dice = dice;
            foreach (Player player in players)
            {
                _players.Enqueue(player);
            }
            status = GameStatus.InProgress;
        }
        public void Play()
        {
            Player player = _players.Dequeue();
            Move(player);
          
        }

        public void Move(Player player)
        {
            int diceVal = _dice.Roll();
            Console.WriteLine(player.GetName() + "-" +diceVal);
            int currentPosition = player.GetPosition() + diceVal;
           

          
           int newPosition = _board.GetFinalPosition(currentPosition);

            if (newPosition == _board.size)
            {
                player.SetPosition(newPosition);
                Console.WriteLine("Game finished and completed by" + player.GetName());
                status = GameStatus.Finished;
                return;
            }
            if (newPosition > 100)
            {
                _players.Enqueue(player);
                return;
            }
            if (diceVal == 6)
            {
                player.SetPosition(newPosition);
                Move(player);
            }
            player.SetPosition(newPosition);
            Console.WriteLine($"Dice moved to {newPosition} by {player.GetName()}");
            if (status == GameStatus.InProgress)
            {
                _players.Enqueue(player);
            }
        }
    }
}
