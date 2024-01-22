
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Arsenal : CommunicatingClass {

    public Arsenal() {
        Weapons = new HashSet<Weapon> { new Weapon { } };
    }

    public HashSet<Weapon> Weapons;

}