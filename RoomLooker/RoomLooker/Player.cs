using System;
using System.Collections.Generic;
namespace RoomLooker
{
    public class Player
    {
        public int hp;
        public List<string> Inventory = new List<string>() { "Flashlight", "5 Bucks" };

        public bool Alive;
        public bool Escaped;
        public string Direction;
        public string attack;
        public bool shiny_Chestpiece;
        public bool shiny_Boots;
        public bool rusty_Chestpiece;
        public bool rusty_Boots;
        public bool sword;
        public int healthPot;
        public int armour;


        public Player()
        {
            hp = 150;
            Alive = true;
            Escaped = false;
            Direction = "";
            int EXP = 0;
            attack = "";

            int lvl = 1;

            // void xpGain(Zombie zombie)
            // {
            //     xp += zombie.expDrop;
            //     lvl = lvl + xp / 15;
            // }
        }

        public void TakeDamage(int amount)
        {
            amount -= armour;
            hp -= amount;
        }
    }
}

