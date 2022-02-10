using System;

namespace RoomLooker
{
    public class Enemy
    {
        public int hp;

        public int dmg;

        public int expDrop;

        public bool Alive;

        public int armour;

        void attack(Player player)
        {
            player.hp -= dmg;
        }

        void otherAttack(Player player)
        {
            dmg -= player.armour;
            player.hp -= dmg;
        }
    }
}