using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_Test
{
    public class RPGgame
    {
        public void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\r\n ███▄    █ ▄▄▄    ▄▄▄█████▓██░ ██ ▄▄▄      ███▄    █  ██████     ██▀███  ██▓███   ▄████ \r\n ██ ▀█   █▒████▄  ▓  ██▒ ▓▓██░ ██▒████▄    ██ ▀█   █▒██    ▒    ▓██ ▒ ██▓██░  ██▒██▒ ▀█▒\r\n▓██  ▀█ ██▒██  ▀█▄▒ ▓██░ ▒▒██▀▀██▒██  ▀█▄ ▓██  ▀█ ██░ ▓██▄      ▓██ ░▄█ ▓██░ ██▓▒██░▄▄▄░\r\n▓██▒  ▐▌██░██▄▄▄▄█░ ▓██▓ ░░▓█ ░██░██▄▄▄▄██▓██▒  ▐▌██▒ ▒   ██▒   ▒██▀▀█▄ ▒██▄█▓▒ ░▓█  ██▓\r\n▒██░   ▓██░▓█   ▓██▒▒██▒ ░░▓█▒░██▓▓█   ▓██▒██░   ▓██▒██████▒▒   ░██▓ ▒██▒██▒ ░  ░▒▓███▀▒\r\n░ ▒░   ▒ ▒ ▒▒   ▓▒█░▒ ░░   ▒ ░░▒░▒▒▒   ▓▒█░ ▒░   ▒ ▒▒ ▒▓▒ ▒ ░   ░ ▒▓ ░▒▓▒▓▒░ ░  ░░▒   ▒ \r\n░ ░░   ░ ▒░ ▒   ▒▒ ░  ░    ▒ ░▒░ ░ ▒   ▒▒ ░ ░░   ░ ▒░ ░▒  ░ ░     ░▒ ░ ▒░▒ ░      ░   ░ \r\n   ░   ░ ░  ░   ▒   ░      ░  ░░ ░ ░   ▒     ░   ░ ░░  ░  ░       ░░   ░░░      ░ ░   ░ \r\n         ░      ░  ░       ░  ░  ░     ░  ░        ░      ░        ░                  ░ \r\n                                                                                        \r\n\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to begin your quest...");
            Console.ReadKey();
            Console.Clear();

            while (true)
            {
                
                Console.WriteLine($"SELECT YOUR CLASS: Warrior // Rogue // Wizard\n");
                string heroSelect = Console.ReadLine().ToLower();
                string choice;
                string nameRegex = @"^[a-zA-Z\s]+$";
                string name;

                switch (heroSelect)
                {                   
                    case "warrior":
                        Console.Clear();
                        Console.WriteLine("  ▄ ▄   ██   █▄▄▄▄ █▄▄▄▄ ▄█ ████▄ █▄▄▄▄\r\n █   █  █ █  █  ▄▀ █  ▄▀ ██ █   █ █  ▄▀\r\n█ ▄   █ █▄▄█ █▀▀▌  █▀▀▌  ██ █   █ █▀▀▌ \r\n█  █  █ █  █ █  █  █  █  ▐█ ▀████ █  █ \r\n █ █ █     █   █     █    ▐         █  \r\n  ▀ ▀     █   ▀     ▀              ▀   \r\n         ▀                             \n");
                        Console.WriteLine("A stalwart defender, clad in heavy armor that gleams with faint scratches and nicks - testaments to countless battles. Their weathered face is etched with determination, and a calloused hand rests on the hilt of a trusty blade.");
                        Console.WriteLine("\nDo you wish to continue as a Warrior? Y/N");
                        choice = Console.ReadLine().ToLower();
                        if (choice == "y")
                        {
                            Warrior warrior = new Warrior();                            
                            
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Enter your name:");
                                name = Console.ReadLine();

                                if (!Regex.IsMatch(name, nameRegex))
                                {
                                    Console.WriteLine("Invalid name. Please enter letters and spaces only.");
                                }
                            } 
                            while (!Regex.IsMatch(name, nameRegex));
                            warrior._name = name;
                            Console.Clear();
                            Console.WriteLine($"Warrior {name}, a name to be feared that's for sure...\n");
                            Console.WriteLine("Press any key to continue with your journey...");
                            Console.ReadKey();
                            break;
                        }
                        Console.Clear();
                        break;
                        


                    case "rogue":
                        Console.Clear();
                        Console.WriteLine("█▄▄▄▄ ████▄   ▄▀    ▄   ▄███▄  \r\n█  ▄▀ █   █ ▄▀       █  █▀   ▀ \r\n█▀▀▌  █   █ █ ▀▄  █   █ ██▄▄   \r\n█  █  ▀████ █   █ █   █ █▄   ▄▀\r\n  █          ███  █▄ ▄█ ▀███▀  \r\n ▀                 ▀▀▀         \n");
                        Console.WriteLine("A shadowy figure, cloaked in dark leather that seems to absorb the light. A mischievous glint shines in their eyes, and a hint of a smile plays on their lips. Hidden weapons bulge beneath their cloak, and their movements are swift and silent.");
                        Console.WriteLine("\nDo you wish to continue as a Rogue? Y/N");
                        choice = Console.ReadLine().ToLower();
                        if (choice == "y")
                        {
                            Rogue rogue = new Rogue();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Enter your name:");
                                name = Console.ReadLine();

                                if (!Regex.IsMatch(name, nameRegex))
                                {
                                    Console.WriteLine("Invalid name. Please enter letters and spaces only.");
                                }
                            }
                            while (!Regex.IsMatch(name, nameRegex));
                            rogue._name = name;
                            Console.Clear();
                            Console.WriteLine($"Sneaky {name}, a name to be feared that's for sure...\n");
                            Console.WriteLine("Press any key to continue with your journey...");
                            Console.ReadKey();
                            break;
                        }
                        Console.Clear();
                        break;


                    case "wizard":
                        Console.Clear();
                        Console.WriteLine("  ▄ ▄   ▄█  ▄▄▄▄▄▄   ██   █▄▄▄▄ ██▄  \r\n █   █  ██ ▀   ▄▄▀   █ █  █  ▄▀ █  █ \r\n█ ▄   █ ██  ▄▀▀   ▄▀ █▄▄█ █▀▀▌  █   █\r\n█  █  █ ▐█  ▀▀▀▀▀▀   █  █ █  █  █  █ \r\n █ █ █   ▐              █   █   ███▀ \r\n  ▀ ▀                  █   ▀         \r\n                      ▀              \n");
                        Console.WriteLine("Their eyes flicker with arcane power, and cryptic symbols are etched on their robes. A worn staff, crackling with faint energy, rests in their hand. The air around them hums with a subtle magic, hinting at the vast potential they hold.");
                        Console.WriteLine("\nDo you wish to continue as a Wizard? Y/N");
                        choice = Console.ReadLine().ToLower();
                        if (choice == "y")
                        {
                            Wizard wizard = new Wizard();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Enter your name:");
                                name = Console.ReadLine();

                                if (!Regex.IsMatch(name, nameRegex))
                                {
                                    Console.WriteLine("Invalid name. Please enter letters and spaces only.");
                                }
                            }
                            while (!Regex.IsMatch(name, nameRegex));                            
                            wizard._name = name;
                            Console.Clear();
                            Console.WriteLine($"Great {name}, a name to be feared that's for sure...\n");
                            Console.WriteLine("Press any key to continue with your journey...");
                            Console.ReadKey();
                            break;
                        }
                        Console.Clear();
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("That class does not exist in this realm, please choose again...\n");
                        break;
                }
            }

        }
    }
}
