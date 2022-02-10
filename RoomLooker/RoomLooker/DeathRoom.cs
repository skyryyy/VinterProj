using System;

namespace RoomLooker
{
    public class DeathRoom : Room
    {
        public override void Interact(Player player)
        {
            Console.WriteLine("This is a Deathroom");
        }
    }
}