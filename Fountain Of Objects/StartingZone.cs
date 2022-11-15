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
        private string _endGame = "The Fountain of Objects has been reactivated, and you have escaped with your life!\nYou Win!";
        public string EnterRoom() => FountainStatus ? _endGame : _enterRoom;

        public bool FountainStatus;
        public StartingZone() { }

        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(EnterRoom());
            Console.ResetColor();

        }
    }
}
