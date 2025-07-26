using MulticastDelegatesAndEvents;

AudioSystem audioSystem = new AudioSystem(); //create an audio system

RenderingEngine renderingEngine = new RenderingEngine(); //create a rendering engine

Player player1 = new Player("StxlCow"); //create a player
Player player2 = new Player("Kubaf"); //create another player

audioSystem.StartGame(); //start the audio system
renderingEngine.StartGame(); //start the rendering engine

player1.StartGame(); //start the first player
player2.StartGame(); //start the second player

Console.WriteLine("\nGame is Running ... Press enter key to end the game.\n");

Console.Read(); //pause the game until a key is pressed

renderingEngine.GameOver(); //stop the rendering engine
audioSystem.GameOver(); //stop the audio system
player1.EndGame(); //end the first player
player2.EndGame(); //end the second player
Console.WriteLine("\nGame Over!"); //print game over message

Console.WriteLine("\nPress any key to exit the application."); //prompt to exit
