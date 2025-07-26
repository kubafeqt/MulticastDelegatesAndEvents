using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegatesAndEvents
{
    class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            this.PlayerName = name;
            //subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += EndGame;
        }

        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID : {PlayerName}");
        }

        private void EndGame()
        {
            Console.WriteLine($"Removing Player with ID : {PlayerName}");
        }
    }
}
