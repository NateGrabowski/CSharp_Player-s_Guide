using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_24___Boss_Battles
{
    internal class Door
    {
        private state State { get; set; }

        public enum state { Locked, Open, Closed };
        private int _passcode;
        //public int Passcode { get { return _passcode; } set { _passcode = value; } }
        public Door()
        {
            Console.WriteLine("Please enter a password for your door. It must be within 1000-9999");
            int passcode = Convert.ToInt32(Console.ReadLine());
            while (!PasswordAcceptable(passcode))
            {
                Console.WriteLine("That password didn't match our requirements, 1000-9999");
                passcode = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thank you. Your door has been created.");
            State = state.Closed;
            _passcode = passcode;


        }
        public void PasswordChange()
        {
            Console.WriteLine("Before we get started I am going to need your current passcode. Please enter it below:");
            int passcode = Convert.ToInt32(Console.ReadLine());
            while (_passcode != passcode)
            {
                Console.WriteLine("That is not the password. Please try again...");
                passcode = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Great! Now what is your new passcode going to be?");
            passcode = Convert.ToInt32(Console.ReadLine());
            while (!PasswordAcceptable(passcode))
            {
                Console.WriteLine("Sorry that passcode doesn't meet the minimum requirements. Please try again.");
                passcode = Convert.ToInt32(Console.ReadLine());

            }
            _passcode = passcode;
            Console.WriteLine("Thanks your new passcode has been accepted! I will now return you to the main menu.");
        }
        private bool PasswordAcceptable(int passcode)
        {
            return passcode > 999 && passcode < 10000 ? true : false;
        }
        public void DoorAction()
        {
            string input = "";
            while (input != "5")
            {
                Console.WriteLine($"Your door is currently {this.State}. Please type a number from the following menu:\nLock Door - 1\nUnlock Door - 2\nOpen Door - 3\nClose Door - 4\nDone - 5");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1": //Lock
                        if (this.State != state.Closed)
                        {
                            Console.WriteLine("You can't lock your door because it is not closed or already locked!");
                        }
                        else
                        {
                            Console.WriteLine("Before I can lock your door I need your passcode! Please enter your passcode:");
                            int passcode = Convert.ToInt32(Console.ReadLine());
                            if (_passcode == passcode)
                            {
                                Console.WriteLine("Your door has been locked!");
                                this.State = state.Locked;
                            }
                        }
                        break;
                    case "2": //Unlock
                        if (this.State != state.Locked)
                        {
                            Console.WriteLine("You can't unlock your door because it is not closed or not locked!");
                        }
                        else
                        {
                            Console.WriteLine("Before I can unlock your door I need your passcode! Please enter your passcode:");
                            int passcode = Convert.ToInt32(Console.ReadLine());
                            if (_passcode == passcode)
                            {
                                Console.WriteLine("Your door has been unlocked!");
                                this.State = state.Closed;
                            }
                        }
                        break;
                    case "3": //Open
                        if (this.State != state.Closed)
                        {
                            Console.WriteLine("You can't open your door because it's locked or is not closed!");
                        }
                        else Console.WriteLine("Your door has been opened!"); this.State = state.Open;
                        break;
                    case "4": //Close
                        if (this.State != state.Open)
                        {
                            Console.WriteLine("You can't close your door because it's already closed!");
                        }
                        else Console.WriteLine("Your door has been closed!"); this.State = state.Closed;
                        break;
                    case "5": //Done
                        break;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
