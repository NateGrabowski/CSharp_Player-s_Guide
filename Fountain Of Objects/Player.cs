using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects
{
    internal class Player
    {
        public int X { get; set; } = 0;
        public int Column { get; set; } = 0;

        //public (int X, int Column) PlayerPosition;

        Map GameMap;

        public Player()
        {

        }

        public void MovePlayerOnMap() //function that checks Map to see if I hit any zones
        {
            Console.WriteLine(GameMap.gameGrid[X, Column]);
        }

    }
}
