using System;

public class GameManager
{
    public Game MyGame;

    private static bool DebugMode = true;

    private static void Main(string[] args)
    {
        UserInterface.DisplayMessage("Bienvenue dans le jeu d'aventure dans le donjon !");

        Game myGame = new Game();

        if (DebugMode)
        {
            UserInterface.DisplayInfo("Mode Debug activé : Tout se passe bien jusqu'ici.");
        }
    }
    public GameManager()
    {
    }

    
}
