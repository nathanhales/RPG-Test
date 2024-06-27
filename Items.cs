using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RPG_Test
{
    // WEAPONS

    public class Weapons
    {
        public int _damage {get; set;}
        public int _attackSpeed { get; set;}
    }

    public class Swords : Weapons
    {
        public Swords()
        {
            
        }
    }

    // ARMOR

    public class Armor
    {

    }

    // ADDITIONAL ITEMS

    public class AdditionalItems
    {

    }
}

enum WeaponType { Ranged, Melee }
enum Weapons { Sword, TwoHandedSword, Bow, Staff, Flail, Spear, Dagger }
enum Armor { Head, Gloves, Boots, Chest, Legs }
enum ArmorType { Light, Medium, Heavy }
enum AddItems { Ring, Necklace, Trinket}
