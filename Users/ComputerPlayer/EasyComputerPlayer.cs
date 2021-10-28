using System;

namespace battleship.Users.ComputerPlayer
{
    public class EasyComputerPlayer : Player
    {
        public override (int y, int x) GiveAShoot(int size)
        {
            Random random = new Random();
            int x = random.Next(0, size);
            int y = random.Next(0, size);
            
            return (y, x);
        }
    }
}