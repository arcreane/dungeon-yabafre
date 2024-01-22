using System;
using System.Collections.Generic;

public class GameManager
{
    public Game MyGame { get; private set; }

    public GameManager()
    {
        MyGame = new Game();
    }

    public void StartGame()
    {
        // Initialize game settings and resources
        MyGame.Initialize();
        // Additional startup procedures can go here
        Console.WriteLine("Game started!");
    }

    public void UpdateGame()
    {
        // Update game state, typically called in a game loop
        MyGame.Update();
        // Additional update logic can go here
    }

    public void EndGame()
    {
        // Handle game ending logic
        // Clean up resources or reset game state if needed
        Console.WriteLine("Game ended!");
    }

    // Additional methods for game management (saving/loading, handling player input, etc.) can be added here
}
