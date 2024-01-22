using System;
using System.Collections.Generic;

enum MonsterType
{
    Barbarian,
    Magician,
    Thief
}

public abstract class Monster : CommunicatingClass
{
    public int LifePoints { get; set; }
    public Weapon Weapon { get; set; }
    public Weapon EfficientWeapon { get; set; }

    protected Monster()
    {
        // Initialization logic here (if needed)

        // Default values
        LifePoints = 100;
        Weapon = new Weapon();
        EfficientWeapon = new Weapon();

    }

    public void Attack(Hero hero)
    {
        // Implementation code here
        hero.LifePoints -= Weapon.Damage;

        if (hero.LifePoints <= 0)
        {
            Console.WriteLine("Hero is dead");
        }

        Console.WriteLine("Hero has {0} life points left", hero.LifePoints);

    }
}
