using System;

namespace RoomLooker
{
    public class Salamanderman : Enemy
    {
        public Salamanderman()
        {
            hp = 90;

            dmg = 15;

            expDrop = 15;

            Alive = true;

            armour = 6;
        }
        public void Attack(Player player)
        {
            player.TakeDamage(dmg);
        }
    }
}