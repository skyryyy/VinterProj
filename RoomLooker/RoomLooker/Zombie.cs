using System;

namespace RoomLooker
{
    public class Zombie : Enemy
    {
        public Zombie()
        {
            hp = 50;

            dmg = 10;

            expDrop = 5;

            Alive = true;

            armour = 5;
            // void otherAttack(Player player)
            // {
            //     dmg -= player.armour;
            //     player.hp -= dmg;
            // }
        }

        public void Attack(Player player)
        {
            player.TakeDamage(dmg);
        }
    }
}