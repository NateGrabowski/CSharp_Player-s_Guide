using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects
{
    internal class Map : Player
    {



        //public T[,] gameGrid = new T[3, 3];
        Object[,] game = new object[3, 3];
        StartingZone zone;

        //public T[,] GameGrid { get => gameGrid; private set => gameGrid = value; }
        //0 {0, 1, 2, 3},
        //1 {0, 1, 2, 3},
        //2 {0, 1, 2, 3},
        //3 {0, 1, 2, 3} 
        //   0  1  2  3

        public Map()
        {
            game[0, 0] = Run();
        }

        public void Run()
        {
            zone.EnterRoom();

        }


    }
}
