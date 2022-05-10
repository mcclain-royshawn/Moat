using System;

namespace Kaysi_Game
{
   

    class MainClass
    {
        public static void Main(string[] args)
        {
            /////////
            string name_input, vocation;
            int choice;

            /////////
            Console.WriteLine("\n Hello! What is your name?");
            name_input = Console.ReadLine();

            if (name_input == "Kaysi" || name_input == "kaysi")
            {
                Console.WriteLine(" \n Hi there sweets!");
            }

            Console.WriteLine("\n What type of person are you?");
            Console.WriteLine("\n 1. Warrior... \n 2. Mage... \n 3. Theif...");
            choice = Convert.ToInt32(Console.ReadLine());

            Person player = new Person();
            player.name = name_input;

            switch (choice)
            {
                case 1:
                    {
                        player.vocation = "Warrior";
                        player.health = 20;
                        player.attack = 3;
                        player.defense = 3;
                        player.mana = 10;
                        player.magic = 1;
                        player.gold = 50;
                        player.speed = 1;
                        break;
                    }
                case 2:
                    {
                        player.vocation = "Mage";
                        player.health = 20;
                        player.attack = 1;
                        player.defense = 3;
                        player.mana = 30;
                        player.magic = 3;
                        player.gold = 40;
                        player.speed = 2;
                        break;
                    }
                case 3:
                    {
                        player.vocation = "Theif";
                        player.health = 20;
                        player.attack = 2;
                        player.defense = 2;
                        player.mana = 20;
                        player.magic = 2;
                        player.gold = 60;
                        player.speed = 3;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.WriteLine("\n Ahhh, so you're a " + player.vocation + " eh?");
            

        }
    }

    enum Stats
    {
        health, mana, magic, gold, ex, attack, defense, speed
    }

    class Person
    {
        public string name, vocation = "Mortal";
        public int health, mana, magic, gold, ex = 0, attack, defense, speed, lv = 1;

        public bool levelup() => (ex / lv) > 1000 * lv;
    }
}