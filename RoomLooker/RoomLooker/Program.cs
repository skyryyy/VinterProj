using System;
using System.Collections.Generic;

namespace RoomLooker
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Room> Rooms = new List<Room>()
            {
                new Room(),
                new TreasureRoom(),
                new DeathRoom(),
                new TrapRoom(),
                new ArmourRoom(),
                new PortalRoom3(),
                new PortalRoom1(),
                new PortalRoom2()
            };



            Player player = new Player();

            Room currentRoom = Rooms[0];

            Random generator = new Random();

            Console.WriteLine("Welcome to RoomLooker, the game where you look into rooms!");
            Console.WriteLine("Do you want to start the game? If so, type Start. If not, type Exit.");

            string start = "";
            int idiotCounter = 0;
            int jackassStacker = 0;
            //int moronEnumerator = 0;

            while (start != "exit" && player.Alive)
            {

                while (start == "")
                {
                    start = Console.ReadLine().Trim().ToLower();

                    if (start != "start" && start != "exit" && idiotCounter <= 2)
                    {
                        Console.WriteLine("Dont try it Anakin");
                        idiotCounter++;
                        start = "";
                    }
                    if (start != "start" && start != "exit" && idiotCounter >= 3)
                    {
                        Console.WriteLine("Come on man, I know you're smarter than this, please just stop being stupid.");
                        start = "";
                    }
                }

                if (start == "start")
                {
                    currentRoom.Interact(player);
                    if (player.Alive == true)
                    {
                        while (player.Direction == "")
                        {
                            Console.WriteLine("You have a door to the left and one to the right.");
                            Console.WriteLine("Go where?");
                            Console.WriteLine("Or do you want to check your inventory?");
                            Console.WriteLine("*Then type inv*");

                            player.Direction = Console.ReadLine().Trim().ToLower();

                            if (player.Direction != "left" && player.Direction != "right" && player.Direction != "inv" && jackassStacker <= 2)
                            {
                                Console.WriteLine("That's not a valid input.");
                                jackassStacker++;
                                player.Direction = "";
                            }

                            if (player.Direction != "left" && player.Direction != "right" && jackassStacker >= 3)
                            {
                                Console.WriteLine("Stop it, get some help.");
                                player.Direction = "";
                            }

                            if (player.Direction == "inv")
                            {
                                foreach (string Item in player.Inventory)
                                {
                                    Console.WriteLine(Item);
                                }
                                player.Direction = "";
                            }

                            if (player.Direction == "left")
                            {
                                int selectRoom = generator.Next(Rooms.Count);
                                currentRoom.roomToTheLeft = Rooms[1];
                                currentRoom = currentRoom.roomToTheLeft;

                            }
                            else if (player.Direction == "right")
                            {
                                int selectRoom = generator.Next(Rooms.Count);
                                currentRoom.roomToTheRight = Rooms[3];
                                currentRoom = currentRoom.roomToTheRight;

                            }
                        }
                    }
                }
                if (player.Alive == false)
                {
                    Console.WriteLine("You are now dead");
                    Console.WriteLine("Everything you gathered will be lost to time and will never matter");
                    Console.WriteLine("You have no chance of regaining the life you lost");
                    Console.WriteLine("The game will now close as you can reflect upon your actions... idiot");
                    Console.ReadLine();
                }

                else if (start == "exit")
                {
                    Console.WriteLine("Bye bye biatch.");

                    Console.ReadLine();
                }
            }
        }
    }
}
