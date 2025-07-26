using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegatesAndEvents
{
    class RenderingEngine
    {
        public void StartGame()
        { 
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals ...");
        }

        public void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}
