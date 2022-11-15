
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects
{
    internal class FountainZone
    {

        public bool FountainStatus { get; set; }

        public void FountainIsOff() => Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");

        public void FountainIsOn() => Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");



        public FountainZone()
        {


        }

        public void Run()
        {
            if (!FountainStatus)
            {
                FountainIsOff();
            }
            else
            {
                FountainIsOn();
            }
        }
    }
}
