using System;
using System.Collections.Generic;

public class Game
{
    public Hero HeroPlayer { get; private set; }
    public Dungeon GameDungeon { get; private set; }
    
    public Game()
    {
        HeroPlayer = new Hero();
        GameDungeon = new Dungeon();
    }

    public void Initialize()
    {
        // Initialize the dungeon layout, rooms, and monsters
        GameDungeon.Initialize();

        // Initialize the hero's starting state
        HeroPlayer.Initialize();

        // Additional initialization code can go here
        Console.WriteLine("Game Initialized");
    }

    public void Update()
    {
        // Update the state of the dungeon and hero
        GameDungeon.Update();
        HeroPlayer.Update();

        // Handle interactions between the hero and the dungeon (e.g., combat, finding items)
        ProcessInteractions();

        // Additional update logic can go here
    }

    private void ProcessInteractions()
    {
        // Implement logic for handling interactions in the dungeon, like combat or finding items
        // This could involve checking the current room of the hero, interacting with monsters, etc.
    }


}
