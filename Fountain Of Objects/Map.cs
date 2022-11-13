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
        public int[,] gameGrid = new int[4, 4];
        StartingZone startingzone;
        FountainZone fountainzone;

        //public T[,] GameGrid { get => gameGrid; private set => gameGrid = value; }
        //Row 0 {0, 1, 2, 3},
        //1 {0, 1, 2, 3},
        //2 {0, 1, 2, 3},
        //3 {0, 1, 2, 3} 
        //   0  1  2  3
        //Column


        //public void Run(Player p)
        //{
        //    if (p.PlayerPosition == (0, 0))
        //    {
        //        Console.WriteLine("Starting Room");
        //    }
        //}
        public Map()
        {
            gameGrid[0, 0] = 1; //Starting Zone
            gameGrid[0, 2] = 2; //Fountain  

        }

        public void Zone(Player p)
        {
            switch (gameGrid[p.X, p.Column])
            {
                case 1: //Starting Zone
                    startingzone = new();
                    break;
                case 2: //Fountain Zone
                    fountainzone = new();
                    break;
                default:
                    break;
            }
        }

        //public void ZoneLoad(int[,] game, Player p, StartingZone startingZone, FountainZone fountainZone)//switch that goes through specific coordinates and returns zone that was hit
        //{
        //    switch (p.PlayerPosition)
        //    {
        //        case (0, 0):
        //            startingzone.EnterRoom();
        //        default:
        //            break;
        //    }
        //}
    }
}
