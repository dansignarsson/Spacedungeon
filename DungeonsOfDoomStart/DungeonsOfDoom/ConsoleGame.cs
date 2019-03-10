using System;
using System.Collections.Generic;

namespace DungeonsOfDoom
{
    static class ConsoleGame
    {
        static Player player;
        static Room[,] world;
        static Random random = new Random();

        public static void Play()
        {
            CreatePlayer();
            CreateWorld();

            Console.WriteLine("Welcome to Spacedungeon");
            Console.WriteLine("Press any key to play...");
            Console.ReadKey();

            do
            {
                Console.Clear();
                DisplayWorld();
                DisplayStats();
                if (AskForMovement())
                {
                    PickUpItem();
                    InitFight();
                    //Console.WriteLine("Pick up an item!");
                }
                if (Monster.MonsterCount == 0)
                {
                    break;
                }

            } while (player.Health > 0);

            EndGame();
        }

        private static void InitFight()
        {
            if (world[player.X, player.Y].Monster != null)
            {
                //Console.WriteLine("There is a monster in the room! Woho!");

                world[player.X, player.Y].Monster.Fight(player); // monster mot player  

                if (player.Health != 0)
                {
                    player.Fight(world[player.X, player.Y].Monster); // player mot monster
                }

                if (world[player.X, player.Y].Monster.Health == 0)
                {
                    if (world[player.X, player.Y].Monster.Name == "Skeleton")
                        world[player.X, player.Y].Monster.Name = "Pile of bones";
                    else
                        world[player.X, player.Y].Monster.Name = "Zombie remains";

                    player.Backpack.Add(world[player.X, player.Y].Monster);
                    world[player.X, player.Y].Monster = null;
                    Monster.MonsterCount--;
                }

            }
        }

        private static void PickUpItem()
        {
            if (player.Backpack.Count <= 3)
            {

                if (world[player.X, player.Y].Item != null)
                {
                    player.Backpack.Add(world[player.X, player.Y].Item);


                    world[player.X, player.Y].Item.PickUp(player);

                    world[player.X, player.Y].Item = null;
                    Console.WriteLine("There is an Item in the room! Woho!");
                }

            }
        }

        private static void CreatePlayer()
        {
            List<IPickUp> backpack = new List<IPickUp>();

            player = new Player(1000, 0, 0, backpack, "Jedimaster");
        }

        private static void CreateWorld()
        {
            world = new Room[20, 5];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    int percentage = random.Next(0, 100);
                    if (percentage < 5)
                        world[x, y].Monster = new Skeleton(30);
                    else if (percentage > 5 && percentage < 10)
                        world[x, y].Monster = new Zombie(30);
                    else if (percentage < 15)
                        world[x, y].Item = new Sword("Sword", 5);
                    else if (percentage < 20)
                        world[x, y].Item = new Potion("Potion", 5);
                    else if (percentage < 25)
                        world[x, y].Item = new Shield("Shield", 5);
                }
            }
        }

        private static void DisplayWorld()
        {

            Console.WriteLine(" _________________________________________________________________________________");
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Console.Write(" |");
                    Room room = world[x, y];

                    if (player.X == x && player.Y == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" P");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    else if (room.Monster != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" M");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    else if (room.Item != null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" I");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                        Console.Write(" .");
                }
                Console.WriteLine(" |");
            }
            Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
            Console.ResetColor();
        }

        private static void DisplayStats()
        {
            if (world[player.X, player.Y].Monster != null)
            {
                Console.WriteLine($"Monster health: {world[player.X, player.Y].Monster.Health}");
            }
            Console.Write($"Health: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player.Health);
            Console.ResetColor();
            Console.Write($"Monster: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Monster.MonsterCount);
            Console.ResetColor();
            Console.WriteLine("Backpack: ");

            foreach (var item in player.Backpack)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static bool AskForMovement()
        {
            int newX = player.X;
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidKey = false; break;
            }

            if (isValidKey &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;

                return true;
            }
            return false;

        }

        private static void EndGame()
        {
            if (player.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Game over...");
                Console.ReadKey();
                Play();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("YOU WON!!!!");
                Console.ReadKey();
                Play();
            }

        }
    }
}
