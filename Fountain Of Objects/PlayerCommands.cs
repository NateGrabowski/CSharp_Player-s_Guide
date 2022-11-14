using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects
{
    internal class PlayerCommands
    {
        public bool OutOfBounds(Player p)//TODO: need to implement out of bounds for positive barrier
        {
            if (p.X < 0 || p.Y < 0 || p.X > 3 || p.Y > 3)
            {
                Console.WriteLine("Out of bounds! I have brought you back to your last room");
                return true;
            }
            return false;
        }

    }

    internal class NorthCommand : PlayerCommands
    {
        internal NorthCommand(Player p)
        {
            p.Y += 1;
            if (OutOfBounds(p))
            {
                p.Y -= 1;
            }
        }

    }

    internal class SouthCommand : PlayerCommands
    {
        internal SouthCommand(Player p)
        {
            p.Y -= 1;
            if (OutOfBounds(p))
            {
                p.Y += 1;
            }
        }
    }
    internal class WestCommand : PlayerCommands
    {
        internal WestCommand(Player p)
        {
            p.X -= 1;
            if (OutOfBounds(p))
            {
                p.X += 1;
            }
        }
    }
    internal class EastCommand : PlayerCommands
    {
        internal EastCommand(Player p)
        {
            p.X += 1;
            if (OutOfBounds(p))
            {
                p.X -= 1;
            }
        }
    }
}
