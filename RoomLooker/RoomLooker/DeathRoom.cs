using System;

namespace RoomLooker
{
    public class DeathRoom : Room
    {
        int deathRoll;
        string consent = "";

        Random differentDeaths = new Random();

        public override void Interact(Player player)
        {
            int deathRoll = differentDeaths.Next(1, 5);

            if (deathRoll == 1)
            {
                Console.WriteLine("After you've walked through a corridor for what seems like ages you fall to the ground.");
                Console.WriteLine("'Why is my body so heavy.' You think to yourself.");
                Console.WriteLine("Before you have time to think another thought you hear heavy footsteps coming toward you.");
                Console.WriteLine("'Who's there!' you yell out.");
                Console.WriteLine("'Your new mommy little boy' you hear a feminine, but still very assertive, voice reply.");
                Console.WriteLine("'New mommy?' As the thought strikes your mind you feel all your clothes boing ripped off and a hard, fleshy and warm object against your back.");
                Console.WriteLine("It's strangely not that cold even without your clothes, but that's not the main issue at hand anyways.");
                Console.WriteLine("'What is that?' you ask the one standing behind you, even though you know to 99% what just hit your back.");
                Console.WriteLine("'You know fully what that was.' You can almost hear the smirk as she talks. As she talks you're also flipped over and can now see the owner of the voice.");
                Console.WriteLine("A hot, buff, tall, well endowed and green woman. Through your extensive fantasy knowledge you could guess she's an ogre.");
                Console.WriteLine("You can also now see that the object was indeed a long, thick and green cock.");
                Console.WriteLine("'Do you consent?' Y/N");

                while (consent == "")
                {
                    consent = Console.ReadLine().ToLower().Trim();

                    if (consent != "y" && consent != "n")

                        if (consent == "y")
                        {
                            Console.WriteLine("I was gonna write some shit about you getting fucked to death, but a really can't be arsed.");
                            Console.WriteLine("So yea, you're dead, unclimactic I know but hey, somehow I feel this is better anyways.");
                            Console.WriteLine("But you're still dead.");
                            player.Alive = false;
                        }

                    if (consent == "n")
                    {
                        Console.WriteLine("'Okay, then I'll leave you alone, bye bye'");
                        Console.WriteLine("You are in shock. 'What just happened???'");
                        Console.WriteLine("You keep walking and to your surprise, you're out? You escaped the dungeon.");
                        Console.WriteLine("'Fuck this, no more dungeons for me.' You think as you walk into the sunlight.");
                        player.Escaped = true;
                    }
                }

            }

            if (deathRoll == 2)
            {
                Console.WriteLine("");
            }

            if (deathRoll == 3)
            {
                Console.WriteLine();
            }

            if (deathRoll == 4)
            {
                Console.WriteLine();
            }
        }
    }
}