using System;
using System.Collections.Generic;

namespace RoomLooker
{
    public class TreasureRoom : Room
    {
        string chestOrnot = "";
        string chestChoose = "";
        string greedy = "1";
        string greedy2 = "1";
        int enemyEncounter = 0;

        List<string> Items = new List<string>()
        {
            "Sword",
            "Broken Sword",
            "Rusted Chestpiece",
            "Health potion",
            "Shiny chestpiece",
            "Worn leather shoes",
            "Aluminium boots"
        };

        Random itemSelect = new Random();

        Random enemyEncounters = new Random();

        Random missChance = new Random();

        public TreasureRoom()
        {
            difficulty = 90;
        }

        public override void Interact(Player player)
        {
            enemyEncounter = enemyEncounters.Next(1, 2);
            if (enemyEncounter == 4)
            {
                Zombie zombie = new Zombie();

                Console.WriteLine("Oh no, a god damned zombie appeared, what will you do?");
                while (zombie.hp > 0 || player.attack == "")
                {
                    Random dmgDealtlight = new Random();
                    Random dmgDealtheavy = new Random();
                    int dmgLight = dmgDealtlight.Next(15, 21);
                    int dmgHeavy = dmgDealtheavy.Next(20, 26);
                    Console.WriteLine("Will you use a heavy or light attack?");

                    player.attack = Console.ReadLine().Trim().ToLower();

                    if (player.attack != "light" && player.attack != "heavy")
                    {
                        Console.WriteLine("That's not an attack dumbass, hit it or die!");
                        player.attack = "";
                    }

                    if (player.attack == "light" && player.sword == false)
                    {
                        dmgLight -= zombie.armour;
                        Console.WriteLine("You performed a light attack and dealt " + dmgLight + " damage");
                        zombie.hp -= dmgLight;
                    }

                    if (player.attack == "light" && player.sword == true)
                    {
                        Console.WriteLine("You performed a light attack and dealt " + dmgLight + " damage");
                        zombie.hp -= dmgLight;
                    }

                    if (player.attack == "heavy" && player.sword == false)
                    {
                        int miss = missChance.Next(1, 5);
                        if (miss == 1)
                        {
                            Console.WriteLine("You missed!");
                        }

                        if (miss >= 2)
                        {
                            dmgHeavy -= zombie.armour;
                            Console.WriteLine("You performed a heavy attack and dealt " + dmgHeavy + " damage to the zombie");
                            zombie.hp -= dmgHeavy;
                        }
                    }

                    if (player.attack == "heavy" && player.sword == true)
                    {
                        int miss = missChance.Next(1, 5);
                        if (miss == 1)
                        {
                            Console.WriteLine("You missed!");
                        }

                        if (miss >= 2)
                        {
                            Console.WriteLine("You performed a heavy attack and dealt " + dmgHeavy + " damage to the zombie");
                            zombie.hp -= dmgHeavy;
                        }
                    }

                    if (player.rusty_Boots == false && player.rusty_Chestpiece == false && player.shiny_Chestpiece == false && player.shiny_Boots == false)
                    {
                        zombie.Attack(player);
                        // player.hp -= Enemy.dmg;
                        Console.WriteLine("The fucker hit you!");
                        Console.WriteLine("You have " + player.hp + " health left.");
                    }

                }
                if (zombie.hp <= 0)
                {
                    Console.WriteLine("You defeted the zombie!");
                }
            }
            if (enemyEncounter == 1)
            {
                Salamanderman salamanderman = new Salamanderman();

                Console.WriteLine("Oh no, a... wait, what the fuck, its a salamander... man? Ummm, it might be endangered but hit it I guess?");
                Console.WriteLine("Sala. Salamander!!!");
                while (salamanderman.hp > 0 || player.attack == "")
                {
                    Random dmgDealtlight = new Random();
                    Random dmgDealtheavy = new Random();
                    int dmgLight = dmgDealtlight.Next(15, 21);
                    int dmgHeavy = dmgDealtheavy.Next(20, 26);
                    Console.WriteLine("Will you use a heavy or light attack?");

                    player.attack = Console.ReadLine().Trim().ToLower();

                    if (player.attack != "light" && player.attack != "heavy")
                    {
                        Console.WriteLine("That's not an attack dumbass, hit it or die!");
                        player.attack = "";
                    }

                    if (player.attack == "light" && player.sword == false)
                    {
                        dmgLight -= salamanderman.armour;
                        Console.WriteLine("You performed a light attack and dealt " + dmgLight + " damage");
                        salamanderman.hp -= dmgLight;
                    }

                    if (player.attack == "light" && player.sword == true)
                    {
                        Console.WriteLine("You performed a light attack and dealt " + dmgLight + " damage");
                        salamanderman.hp -= dmgLight;
                    }

                    if (player.attack == "heavy" && player.sword == false)
                    {
                        int miss = missChance.Next(1, 5);
                        if (miss == 1)
                        {
                            Console.WriteLine("You missed!");
                        }

                        if (miss >= 2)
                        {
                            dmgHeavy -= salamanderman.armour;
                            Console.WriteLine("You performed a heavy attack and dealt " + dmgHeavy + " damage to the zombie");
                            salamanderman.hp -= dmgHeavy;
                        }
                    }

                    if (player.attack == "heavy" && player.sword == true)
                    {
                        int miss = missChance.Next(1, 5);
                        if (miss == 1)
                        {
                            Console.WriteLine("You missed!");
                        }

                        if (miss >= 2)
                        {
                            Console.WriteLine("You performed a heavy attack and dealt " + dmgHeavy + " damage to the zombie");
                            salamanderman.hp -= dmgHeavy;
                        }
                    }

                    if (player.rusty_Boots == false && player.rusty_Chestpiece == false && player.shiny_Chestpiece == false && player.shiny_Boots == false)
                    {
                        salamanderman.Attack(player);
                        // player.hp -= Enemy.dmg;
                        Console.WriteLine("The fucker hit you!");
                        Console.WriteLine("You have " + player.hp + " health left.");
                    }

                }
                if (salamanderman.hp <= 0)
                {
                    Console.WriteLine("You defeted the... Salamanderman... mon?");
                }
            }

            Console.WriteLine("You walk through a long corridor before entering a seemingly empty room.");
            Console.WriteLine("When you enter the room you notice two chests standing against the wall, a golden one and a bronze.");
            Console.WriteLine("You debate with yourself if you want to open any of them or not.");
            Console.WriteLine("Do you want to? Y/N");

            while (chestOrnot == "")
            {
                chestOrnot = Console.ReadLine().Trim().ToUpper();

                if (chestOrnot != "Y" && chestOrnot != "N")
                {
                    Console.WriteLine("Congrats, not a valid input.");
                    chestOrnot = "";
                }

                if (chestOrnot == "Y")
                {
                    Console.WriteLine("You walk up to the chests and inspect them.");
                    Console.WriteLine("They're both shiny but the bronze one looks a bit more worn out.");
                    Console.WriteLine("A single thought appears in your head.");
                    Console.WriteLine("'I wonder what's inside?'");
                    Console.WriteLine("Which do you want to open? B/G");
                    Console.WriteLine("*Or you can choose to not open one anyways by typing leave*");
                }

                while (chestChoose == "")
                {

                    chestChoose = Console.ReadLine().Trim().ToUpper();

                    if (chestChoose != "B" && chestChoose != "G" && chestChoose != "LEAVE")
                    {
                        Console.WriteLine("At this point, I don't know what to say.");
                        chestChoose = "";
                    }

                    if (chestChoose == "B")
                    {
                        Console.WriteLine("You drag your hand against the rougher bronze chest and decide to open it.");
                        Console.WriteLine("As you lift up the lid of the chest you ponder what could be inside.");
                        Console.WriteLine("'Maybe a cool sword or diamonds and gold.'");
                        Console.WriteLine("As its open you see your new...");

                        int newItem = itemSelect.Next(Items.Count);
                        Console.WriteLine(Items[newItem]);
                        player.Inventory.Add(Items[newItem]);

                        if (newItem == 0)
                        {
                            Console.WriteLine(@"

              />
 ()          //---------------------------------------------------------(
(*)OXOXOXOXO(*>                                                          \
 ()          \\-----------------------------------------------------------)
              \>

");
                            player.sword = true;
                            Console.WriteLine("Your attacks now ignore armour.");
                        }

                        if (newItem == 1)
                        {
                            Console.WriteLine(@"

              />
 ()          //-----------------------\
(*)OXOXOXOXO(*>                        |>                              
 ()          \\-----------/\-----------/
              \>
              ");

                        }

                        if (newItem == 2)
                        {
                            Console.WriteLine(@"

        .-;`\..../`;-.
       /RR|...::...|R \
      | RR/'''::'''\ RR|
      ;--'\ RR:: R /\--;
      <__>,>._::_.<,<__>
      
      ");
                            player.rusty_Chestpiece = true;
                            Console.WriteLine("You now have more armour.");
                            player.armour++;
                        }

                        if (newItem == 3)
                        {
                            Console.WriteLine(@"

      _____
     `.___,'
      (___)
      <   >
       ) (
      /`-.\
     /     \
    / _    _\
   :,' `-.' `:
   |         |
   :         ;
    \       /
     `.___.' 

");
                            player.healthPot++;
                        }

                        if (newItem == 4)
                        {
                            Console.WriteLine(@"

        .-;`\..../`;-.
       /SS|...::...|S \
      |   /S''::'''\ S |
      ;--'\ S::   /\'--;
      <__>,>._::_.<,<__>
      
      ");
                            player.shiny_Chestpiece = true;
                            Console.WriteLine("You now have more armour.");
                            player.armour++;
                        }

                        if (newItem == 5)
                        {
                            Console.WriteLine(@"

     )___/       )___(
      |x/         \ >
      |x)         / '.
      |x\        (____''._
      \ -\
       \__|
       
       ");
                            player.rusty_Boots = true;
                            Console.WriteLine("You now have more armour.");
                            player.armour++;
                        }

                        if (newItem == 6)
                        {
                            Console.WriteLine(@"
       ,---.
       |:  ,+--.
       |: | __ |
       |: |/__\|
       |: |/__\|
       |`.|/  \(
       (_ |`._)``.
        `=(_      `._
           `=='`-----'   ");
                            player.shiny_Boots = true;
                            Console.WriteLine("You now have more armour.");
                            player.armour++;
                        }

                        Console.WriteLine("At the bottom of the chest you see something carved.");
                        Console.WriteLine("Anyone greedy will meet their demise and succumb to their own greed.");
                        Console.WriteLine("You ponder for a second and then think to yourself.");
                        Console.WriteLine("'Do I risk opening the other chest?'");
                        Console.WriteLine("Do you? Y/N");
                        greedy = "";

                        while (greedy == "")
                        {

                            greedy = Console.ReadLine().Trim().ToUpper();

                            if (greedy != "Y" && greedy != "N")
                            {
                                Console.WriteLine("Brother, just don't.");
                                greedy = "";
                            }

                            if (greedy == "Y")
                            {
                                Console.WriteLine("As you open the golden chest you immedietly get impaled by 5 big spikes.");
                                Console.WriteLine("The last thing you ever thought was");
                                Console.WriteLine("'Hehehe, screw the system.'");
                                Console.WriteLine("What the fuck did you think would happen???");
                                player.Alive = false;
                            }

                            if (greedy == "N")
                            {
                                Console.WriteLine("'Nah fam, this some ominus shit, I ain't fuckin with destiny or fate or whatever.'");
                                Console.WriteLine("This thought crosses your mind");
                            }
                        }
                    }

                    if (chestChoose == "G")
                    {
                        Console.WriteLine("You drag your hand against the shiny golden chest and decide to open it.");
                        Console.WriteLine("As you lift up the lid of the chest you ponder what could be inside.");
                        Console.WriteLine("'Maybe a cool sword or diamonds and gold.'");
                        Console.WriteLine("As its open you see your new...");

                        int newItem = itemSelect.Next(Items.Count);
                        Console.WriteLine(Items[newItem]);
                        player.Inventory.Add(Items[newItem]);

                        if (newItem == 0)
                        {
                            Console.WriteLine(@"

              />
 ()          //---------------------------------------------------------(
(*)OXOXOXOXO(*>                                                          \
 ()          \\-----------------------------------------------------------)
              \>

");
                            player.sword = true;
                            Console.WriteLine("Your attacks now ignore armour.");
                        }

                        if (newItem == 1)
                        {
                            Console.WriteLine(@"

              />
 ()          //-----------------------\
(*)OXOXOXOXO(*>                        |>                              
 ()          \\-----------/\-----------/
              \>
              ");

                        }

                        if (newItem == 2)
                        {
                            Console.WriteLine(@"

        .-;`\..../`;-.
       /RR|...::...|R \
      | RR/'''::'''\ RR|
      ;--'\ RR:: R /\--;
      <__>,>._::_.<,<__>
      
      ");
                            player.rusty_Chestpiece = true;
                            Console.WriteLine("You now have more armour.");
                            player.armour++;
                        }

                        if (newItem == 3)
                        {
                            Console.WriteLine(@"

      _____
     `.___,'
      (___)
      <   >
       ) (
      /`-.\
     /     \
    / _    _\
   :,' `-.' `:
   |         |
   :         ;
    \       /
     `.___.' 

");
                            player.healthPot++;
                        }

                        if (newItem == 4)
                        {
                            Console.WriteLine(@"

        .-;`\..../`;-.
       /SS|...::...|S \
      |   /S''::'''\ S |
      ;--'\ S::   /\'--;
      <__>,>._::_.<,<__>
      
      ");
                            player.shiny_Chestpiece = true;
                            Console.WriteLine("You now have more armour.");
                            player.armour++;
                        }

                        if (newItem == 5)
                        {
                            Console.WriteLine(@"

     )___/       )___(
      |x/         \ >
      |x)         / '.
      |x\        (____''._
      \ -\
       \__|
       
       ");
                            player.rusty_Boots = true;
                            Console.WriteLine("You now have more armour.");
                            player.armour++;
                        }

                        if (newItem == 6)
                        {
                            Console.WriteLine(@"
                            
       ,---.
       |:  ,+--.
       |: | __ |
       |: |/__\|
       |: |/__\|
       |`.|/  \(
       (_ |`._)``.
        `=(_      `._
           `=='`-----' 
           
           ");
                            player.shiny_Boots = true;
                            Console.WriteLine("You now have more armour.");
                            player.armour++;
                        }

                        Console.WriteLine("At the bottom of the chest you see something carved.");
                        Console.WriteLine("Anyone greedy will meet their demise and succumb to their own greed.");
                        Console.WriteLine("You ponder for a second and then think to yourself.");
                        Console.WriteLine("'Do I risk opening the other chest?'");
                        Console.WriteLine("Do you? Y/N");

                        greedy2 = "";

                        while (greedy2 == "")
                        {

                            greedy2 = Console.ReadLine().Trim().ToUpper();

                            if (greedy2 != "Y" && greedy2 != "N")
                            {
                                Console.WriteLine("Brother, just don't.");
                                greedy2 = "";
                            }

                            if (greedy2 == "Y")
                            {
                                Console.WriteLine("As you open the golden chest you immedietly get impaled by 5 big spikes.");
                                Console.WriteLine("The last thing you ever thought was");
                                Console.WriteLine("'Hehehe, screw the system.'");
                                Console.WriteLine("What the fuck did you think would happen???");
                                player.Alive = false;
                            }

                            if (greedy2 == "N")
                            {
                                Console.WriteLine("'Nah fam, this some ominus shit, I ain't throwing my life away for loot.'");
                                Console.WriteLine("This thought crosses your mind");
                            }
                        }
                    }

                    if (chestChoose == "LEAVE")
                    {
                        Console.WriteLine("As you inspect the chests one thought crosses your mind.");
                        Console.WriteLine("'Fuck this, I ain't dying, I'm out.'");
                        Console.WriteLine("You instead look around for other stuff that seems safer.");
                    }
                }

                if (chestOrnot == "N")
                {
                    Console.WriteLine("You think");
                    Console.WriteLine("'Nah, there's something fishy about this'");
                    Console.WriteLine("Instead you decide to look around the room more");
                }
            }

            chestOrnot = "";
            chestChoose = "";
            greedy = "1";
            greedy2 = "1";
            player.Direction = "";
        }

    }
}