using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects
{
    internal class StartingZone
    {
        private string _enterRoom = "You see light coming from the cavern entrance";

        public void EnterRoom() => Console.WriteLine(_enterRoom);
    }
}
