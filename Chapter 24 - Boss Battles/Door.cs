using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_24___Boss_Battles
{
    internal class Door
    {
        public state State { get; set; }

        public enum state { Locked, Open, Closed };
        private int _passcode;
        public int Passcode { get { return _passcode; } set { _passcode = value; } }
        public Door()
        {
            Console.WriteLine("Please enter a password for your door. It must be within 1000-9999");
            int passcode = Convert.ToInt32(Console.ReadLine());
            while (!PasswordAcceptable(passcode))
            {
                Console.WriteLine("That password didn't match our requirements, 1000-9999");
                passcode = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thank you. Your door has been locked.");
            State = state.Locked;
            _passcode = passcode;


        }
        //public void PasswordChange(int passcode)
        //{
        //    if (_passcode != passcode)
        //    {
        //        Console.WriteLine("That is not the password. Please try again...");
        //    }
        //    else if (PasswordAcceptable(passcode))
        //    {
        //        _passcode = passcode;
        //    }
        //}
        public bool PasswordAcceptable(int passcode)
        {
            return passcode > 999 && passcode < 10000 ? true : false;
        }
    }
}
