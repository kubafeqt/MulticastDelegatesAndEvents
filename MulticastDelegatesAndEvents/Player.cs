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
        }

        public void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID : {PlayerName}");
        }

        public void EndGame()
        {
            Console.WriteLine($"Removing Player with ID : {PlayerName}");
        }
    }
}
