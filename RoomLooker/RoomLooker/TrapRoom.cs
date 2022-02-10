using System;
using System.Collections.Generic;

namespace RoomLooker
{
    public class TrapRoom : Room
    {
        List<string> Traps = new List<string>()
        {
            "Pressure spikes",
            "Trapped chest",
            "Pitfall",
            "Goldpile"
        };
        Random trapSelect = new Random();

        string grab = "1";
        string open = "2";
        string walk = "3";
        string goldie = "4";
        public override void Interact(Player player)
        {
            int Trapper = trapSelect.Next(1, 5);

            if (Trapper == 1)
            {
                grab = "";
                Console.WriteLine("You walk and walk until you see a door, you open it to find a seemingly empty room with nothing but rocks.");
                Console.WriteLine("Right as you are about to lose intrest you see something shiny at the end of the room.");
                Console.WriteLine("Due to your poor eyesight you can't make out what the object is.");
                Console.WriteLine("'I want it, whatever it is.'");
                Console.WriteLine("You however do know that you want it.");
                Console.WriteLine("Go and grab it? Y/N");

                while (grab == "")
                {
                    grab = Console.ReadLine().Trim().ToUpper();

                    if (grab != "Y" && grab != "N")
                    {
                        Console.WriteLine("Esa no es una entrada válida.");
                        grab = "";
                    }

                    if (grab == "Y")
                    {
                        Console.WriteLine("As you mindlessly walk across the room to the shiny object you feel the flor sink in.");
                        Console.WriteLine("Before you can even react, 7 steel spikes impale you from the floor. As you die you think");
                        Console.WriteLine("'Is that just foolsgold???'");
                        player.Alive = false;
                    }

                    if (grab == "N")
                    {
                        Console.WriteLine("You resist the primal urge to grab the object.");
                        Console.WriteLine("'Must. Not. Fall. For. Trap.'");
                    }
                }
            }

            if (Trapper == 2)
            {
                open = "";
                Console.WriteLine("You walk through a long corridor before entering a seemingly empty room.");
                Console.WriteLine("When you enter the room you notice one chest standing against the wall, a golden and shiny one.");
                Console.WriteLine("You debate with yourself if you want to open any of them or not.");
                Console.WriteLine("Do you want to? Y/N");

                while (open == "")
                {
                    open = Console.ReadLine().Trim().ToUpper();

                    if (open != "Y" && open != "N")
                    {
                        Console.WriteLine("I'm getting real tired of typing these out.");
                        open = "";
                    }

                    if (open == "Y")
                    {
                        Console.WriteLine("As you open the shiny golden chest you're met by the most golden gleem you've ever seen.");
                        Console.WriteLine("It's a big...");
                        Console.WriteLine("Beautiful...");
                        Console.WriteLine("24k pure golden...");
                        Console.WriteLine("Spike that just impaled you right between your eyes.");
                        Console.WriteLine("Det var nära ögat.");
                        player.Alive = false;
                    }

                    if (open == "N")
                    {
                        Console.WriteLine("'HEEEEEELLL NAWWWWWW'");
                        Console.WriteLine("'Only one chest, ONE CHEST! That is waaaay to ominus'");
                        Console.WriteLine("As this thought crosses you mind you instead look around the room for other stuff.");
                    }
                }
            }

            if (Trapper == 3)
            {
                walk = "";
                Console.WriteLine("You walk through a short corridor and enter a relatively small room.");
                Console.WriteLine("In the middle of the room to you amazement you see a massive bag of creatine, your favorite supplement!");
                Console.WriteLine("'GIMME GIMMIE I NEEEED!'");
                Console.WriteLine("Do you walk up and take it? Y/N");

                while (walk == "")
                {

                    walk = Console.ReadLine().Trim().ToUpper();

                    if (walk != "Y" && walk != "N")
                    {
                        Console.WriteLine("Nope, I can't do this anymore.");
                        walk = "";
                    }

                    if (walk == "Y")
                    {
                        Console.WriteLine("You run up and grab the bag of creatine and as you do, the floor collapses underneath you.");
                        Console.WriteLine("In your last dying moments you heave as much creatine as you can.");
                        Console.WriteLine("'GAINNNNSSSSSS'");
                        player.Alive = false;
                    }

                    if (walk == "N")
                    {
                        Console.WriteLine("No, that's too specific, how would they know? How could the dungeon know?");
                        Console.WriteLine("You instead hug the walls tight as you can and look for other stuff.");
                    }
                }
            }

            if (Trapper == 4)
            {
                goldie = "";
                Console.WriteLine("As you enter the room you see the most beatiful thing you've ever laid eyes upon.");
                Console.WriteLine("'A HUGE PILE OF FUCKING GOLD!!!!'");
                Console.WriteLine("Do you run up and grab all you can? Y/N");

                while (goldie == "")
                {
                    goldie = Console.ReadLine().Trim().ToUpper();

                    if (goldie != "Y" && goldie != "N")
                    {
                        Console.WriteLine("I am getting real sick of this now.");
                        goldie = "";
                    }

                    if (goldie == "Y")
                    {
                        Console.WriteLine("You run up and jump in the pile of gold feeling like you're literally Scrooge McDuck.");
                        Console.WriteLine("But as you start scooping it up you feel your entire body burning.");
                        Console.WriteLine("It turns out the gold was laced with acid!!!");
                        Console.WriteLine("As your body slowly gets eaten by the acid you think to yourself in your dying moments.");
                        Console.WriteLine("'How could I be this stupid???'");
                        player.Alive = false;
                    }

                    if (goldie == "N")
                    {
                        Console.WriteLine("'Come on, this is the most obvious trap in the world.");
                        Console.WriteLine("'I bet it's even going to be something lame suchas the gold being laced with acid or some stupid shit like that.'");
                        Console.WriteLine("You instead walk around the trap and continue looking for other stuff.");
                    }
                }
            }
        }
    }
}