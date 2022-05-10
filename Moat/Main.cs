using System;

namespace Kaysi_Game
{
    enum Stats
    {
        health, mana, magic, gold, ex, attack, defense, speed
    }

    class Person
    {
        public string name, vocation = "Mortal";
        public int health, mana, magic, gold, ex = 0, attack, defense, speed;
    }

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

            if (name_input == "Kaysi")
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
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }
    }
}