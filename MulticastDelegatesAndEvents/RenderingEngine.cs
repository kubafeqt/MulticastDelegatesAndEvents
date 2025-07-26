using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegatesAndEvents
{
    class RenderingEngine
    {
        public RenderingEngine()
        {
            //subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame; //subscribe to the OnGameStart event
            GameEventManager.OnGameOver += GameOver; //subscribe to the OnGameOver event
        }

        private void StartGame()
        { 
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals ...");
        }

        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}
