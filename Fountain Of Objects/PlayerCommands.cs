using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects
{
    internal class PlayerCommands
    {

    }

    internal class NorthCommand : PlayerCommands
    {
        internal NorthCommand(Player p)
        {
            p.Y = 1;
        }
    }

    internal class SouthCommand : PlayerCommands
    {
        internal SouthCommand(Player p)
        {
            p.Y -= 1;
        }
    }
    internal class WestCommand : PlayerCommands
    {
        internal WestCommand(Player p)
        {
            p.X -= 1;
        }
    }
    internal class EastCommand : PlayerCommands
    {
        internal EastCommand(Player p)
        {
            p.X += 1;
        }
    }
}
