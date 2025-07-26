﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegatesAndEvents
{
    class AudioSystem
    {
        public AudioSystem()
        {
            //subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame; //subscribe to the OnGameStart event
            GameEventManager.OnGameOver += GameOver; //subscribe to the OnGameOver event
        }

        private void StartGame()
        {
            Console.WriteLine("Audio System Started");
            Console.WriteLine("Playing Audio ...");
        }

        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
