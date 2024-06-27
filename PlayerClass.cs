using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace RPG_Test
{
    public class PlayerClassBase
    {
        public string _name { get; set; }
        public int _level { get; set; } = 1;
        public int _healthValue { get; set; }
        public int _manaValue { get; set; }             // Starting stats total to 25
        public int _strengthStat { get; set; }  
        public int _agilityStat { get; set; }
        public int _intStat { get; set; }
        public int _armorValue { get; set; }
    }

    public class Warrior : PlayerClassBase
    {
        public Warrior(int Health, int Mana, int Str, int Agi, int Inteli, int Armor)
        {
           /* _healthValue = 250;
            _manaValue = 50;
            _strengthStat = 13;
            _agilityStat = 8;
            _intStat = 4;
            _armorValue = 25; */

        }       
    }

    public class Rogue : PlayerClassBase
    {
        public Rogue(int Health, int Mana, int Str, int Agi, int Inteli, int Armor)
        {
           /* _healthValue = 150;
            _manaValue = 50;
            _strengthStat = 7;
            _agilityStat = 13;
            _intStat = 5;
            _armorValue = 15; */
        }
    }

    public class Wizard : PlayerClassBase
    {
        public Wizard(int Health, int Mana, int Str, int Agi, int Inteli, int Armor)
        {
           /* _healthValue = 100;
            _manaValue = 300;
            _strengthStat = 3;
            _agilityStat = 4;
            _intStat = 18;
            _armorValue = 8; */
        }
    }



}
