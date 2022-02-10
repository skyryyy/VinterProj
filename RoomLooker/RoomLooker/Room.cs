using System;

namespace RoomLooker
{
    public class Room
    {
        public int difficulty = 5;

        public Room roomToTheLeft;
        public Room roomToTheRight;

        public virtual void Interact(Player player)
        {
            Console.WriteLine("its just a room, you walk around and find literally nothing but rocks");
            Console.WriteLine("you think too yourself");
            Console.WriteLine("'this is shit'");
            Console.WriteLine("You feel an immense sense of dissapointment.");
        }
    }
}