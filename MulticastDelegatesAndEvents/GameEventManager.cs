using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegatesAndEvents
{
    internal class GameEventManager
    {
        //a new delagate type named GameEvent
        public delegate void GameEvent();

        //create two delegates variables named OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            //check if the OnGameStart event is not empty
            //meaning that other methods already subscribed to this delegate
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started...\n");
                //invoke the OnGameStart delegate that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            //check if the OnGameOver event is not empty
            //meaning that other methods already subscribed to it
            if (OnGameOver != null)
            {
                Console.WriteLine("The game is over...\n");
                //invoke the OnGameOver delegate that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }
    }
}
