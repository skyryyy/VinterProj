using System;

namespace RoomLooker
{
    public class ArmourRoom : Room
    {
        string walkUp = "";
        string touch = "";
        string take = "";
        int idiotCounter = 0;
        // int moronEnumerator = 0;
        int jackassStacker = 0;
        Random number = new Random();
        public override void Interact(Player player)
        {
            Console.WriteLine("You walk into the room and see shelfs and stands full of old and rusty armour.");

            Console.WriteLine("Do you walk up to one of the stands? Y/N");

            while (walkUp == "")
            {
                walkUp = Console.ReadLine().Trim().ToUpper();

                if (walkUp != "Y" && walkUp != "N" && idiotCounter <= 2)
                {
                    Console.WriteLine("Not a valid input");
                    idiotCounter++;
                    walkUp = "";
                }
                if (walkUp != "Y" && walkUp != "N" && idiotCounter >= 3)
                {
                    Console.WriteLine("Bitxh are you stupid? Yes or No it is not that hard");
                    walkUp = "";
                }


                if (walkUp == "Y")
                {
                    Console.WriteLine("You walk up to the stand and get a closer look on the probably decennia old dust on it.");
                    Console.WriteLine("You suddenly feel a desperate need to touch, do you? Y/N");
                    while (touch == "")
                    {

                        touch = Console.ReadLine().Trim().ToUpper();

                        if (touch != "Y" && touch != "N")
                        {
                            Console.WriteLine("Still not a valid input");
                            touch = "";
                        }

                        if (touch == "Y")
                        {
                            Console.WriteLine("You touch it and scrape off the layers and layers of old dust.");
                            Console.WriteLine("The dust is actually so old that it feels moist. You think to yourself");
                            Console.WriteLine("'Why the fuck did i decide to do this?'");
                            Console.WriteLine("You again think to yourself");
                            Console.WriteLine("'I want that helmet'.");
                            Console.WriteLine("Take the helmet? Y/N");
                        }

                        while (take == "")
                        {

                            take = Console.ReadLine().Trim().ToUpper();

                            if (take != "Y" && take != "N" && jackassStacker <= 2)
                            {
                                Console.WriteLine("That is still not valid input.");
                                take = "";
                            }

                            if (take == "Y")
                            {
                                int deathRisk = number.Next(1, 4);
                                if (deathRisk == 1 || deathRisk == 2)
                                {
                                    Console.WriteLine("You picked up the helmet and put it in your inventory.");
                                    player.Inventory.Add("Helmet");
                                    Console.WriteLine(@"
                                     
      _,.
    ,` -.)
   ( _/-\\-._
  /,|`--._,-^|            
  \_| |`-._/||          
    |  `-, / |         
    |     || |
     `--._||/ 
     
     ");
                                    deathRisk = 0;
                                }

                                if (deathRisk == 3)
                                {
                                    Console.WriteLine("The entire armour collapsed on you and crushed your skull, instantly removing you from this world.");
                                    player.Alive = false;

                                }
                            }

                            if (take == "N")
                            {
                                Console.WriteLine("You decide that you done enough mentally handicapped things and move on.");
                                Console.WriteLine("You look around for other things.");
                            }
                        }

                        if (touch == "N")
                        {
                            Console.WriteLine("You decide not to touch it as it would absolutely ridicoulus and that you would feel insurmountebly fucking moronic touching the armour");
                            Console.WriteLine("You instead look around for other things");
                        }
                    }

                }

                if (walkUp == "N")
                {
                    Console.WriteLine("You look around the room for other things");
                }
            }
            walkUp = "";
            touch = "";
            take = "";
            player.Direction = "";
        }
    }
}