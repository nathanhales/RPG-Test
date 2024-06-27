using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace RPG_Test
{
    public class Enemy
    {
        public string _name { get; set; }
        public int _level { get; set; } = 1;
        public int _healthValue { get; set; }
        public int _manaValue { get; set; }             
    }
}
