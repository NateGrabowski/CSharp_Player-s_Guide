using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects
{
    internal class Map<T>
    {
        // int[,] gameGrid = { //grid with numbers
        // {0, 1, 2, 3}, //0
        // {0, 1, 2, 3}, //1
        // {0, 1, 2, 3}, //2
        // {0, 1, 2, 3}  //3
        ////0  1  2  3
        //};

        T[,] gameGrid = new T[3, 3];
        //0 {0, 1, 2, 3},
        //1 {0, 1, 2, 3},
        //2 {0, 1, 2, 3},
        //3 {0, 1, 2, 3} 
        //   0  1  2  3


        //public T[,] CreateGameGrid<T>() //Not sure if this works
        //{
        //    return new T[3, 3];
        //}

    }
}
