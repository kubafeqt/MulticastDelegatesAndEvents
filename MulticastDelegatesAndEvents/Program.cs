using MulticastDelegatesAndEvents;

AudioSystem audioSystem = new AudioSystem(); //create an audio system

RenderingEngine renderingEngine = new RenderingEngine(); //create a rendering engine

Player player1 = new Player("StxlCow"); //create a player
Player player2 = new Player("Kubaf"); //create another player
Player player3 = new Player("Ragnarox"); //create another player

GameEventManager.TriggerGameStart(); //trigger the game start event

Console.WriteLine("\nGame is Running ... Press enter key to end the game.\n");

Console.Read(); //pause the game until a key is pressed

GameEventManager.TriggerGameOver(); //trigger the game over event


Console.WriteLine("\nPress any key to exit the application."); //prompt to exit
