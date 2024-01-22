
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

enum WeaponType
{
    Arrow,
    Claw, 
    Dagger,
    Fire,
    IceArrow,
    Lighting,
    Spike,
    Sword
}
public abstract class Weapon : CommunicatingClass{

    public Weapon() {
    }

}