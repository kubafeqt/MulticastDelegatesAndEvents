﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegatesAndEvents
{
    class AudioSystem
    {
        public void StartGame()
        {
            Console.WriteLine("Audio System Started");
            Console.WriteLine("Playing Audio ...");
        }

        public void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
