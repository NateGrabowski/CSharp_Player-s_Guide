using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects
{
    internal class Player
    {
        public int X { get; set; }
        public int Y { get; set; }

        public (int X, int Y) PlayerPosition;

        Map GameMap;
        
        public Player()
        {
            X = 0;
            Y = 0;
        }

        public void MovePlayerOnMap() //function that checks Map to see if I hit any zones
        {
            Console.WriteLine(GameMap.gameGrid[X, Y]); 
        }
        
    }
}
