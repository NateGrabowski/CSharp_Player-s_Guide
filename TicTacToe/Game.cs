using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public int Turn = 0; //Player 1 is 0 && Player 2 is 1
        private string e1 = " ", e2 = " ", e3 = " ", e4 = " ", e5 = " ", e6 = " ", e7 = " ", e8 = " ", e9 = " ";
        public Input input { get; set; }
        public Section section { get; set; }

        public enum Input { X, O }
        public enum Section { BottomLeft, BottomMiddle, BottomRight, MiddleLeft, MiddleMiddle, MiddleRight, TopLeft, TopMiddle, TopRight }

        public void PlayGame()
        {
            while (true) //result of tie & winner should end game
            {
                Console.WriteLine("Where would you like to place your input? Use the number pad to guide your choice.");
                int input = Convert.ToInt16(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Board(Turn, Section.BottomLeft);
                        break;
                    case 2:
                        Board(Turn, Section.BottomMiddle);
                        break;
                    case 3:
                        Board(Turn, Section.BottomRight);
                        break;
                    case 4:
                        Board(Turn, Section.MiddleLeft);
                        break;
                    case 5:
                        Board(Turn, Section.MiddleMiddle);
                        break;
                    case 6:
                        Board(Turn, Section.MiddleRight);
                        break;
                    case 7:
                        Board(Turn, Section.TopLeft);
                        break;
                    case 8:
                        Board(Turn, Section.TopMiddle);
                        break;
                    case 9:
                        Board(Turn, Section.TopRight);
                        break;
                }

            }
        }
        public void Board(int turn, Section section)
        {
            bool isSectionTaken = CheckIfSpotTaken();
            if (!isSectionTaken)
            {
                switch (turn, section)
                {
                    case (0, Section.BottomLeft):
                        e1 = Enum.GetName(Input.X);
                        break;
                    case (0, Section.BottomMiddle):
                        e2 = Enum.GetName(Input.X);
                        break;
                    case (0, Section.BottomRight):
                        e3 = Enum.GetName(Input.X);
                        break;
                    case (0, Section.MiddleLeft):
                        e4 = Enum.GetName(Input.X);
                        break;
                    case (0, Section.MiddleMiddle):
                        e5 = Enum.GetName(Input.X);
                        break;
                    case (0, Section.MiddleRight):
                        e6 = Enum.GetName(Input.X);
                        break;
                    case (0, Section.TopLeft):
                        e7 = Enum.GetName(Input.X);
                        break;
                    case (0, Section.TopMiddle):
                        e8 = Enum.GetName(Input.X);
                        break;
                    case (0, Section.TopRight):
                        e9 = Enum.GetName(Input.X);
                        break;
                    case (1, Section.BottomLeft):
                        e1 = Enum.GetName(Input.O);
                        break;
                    case (1, Section.BottomMiddle):
                        e2 = Enum.GetName(Input.O);
                        break;
                    case (1, Section.BottomRight):
                        e3 = Enum.GetName(Input.O);
                        break;
                    case (1, Section.MiddleLeft):
                        e4 = Enum.GetName(Input.O);
                        break;
                    case (1, Section.MiddleMiddle):
                        e5 = Enum.GetName(Input.O);
                        break;
                    case (1, Section.MiddleRight):
                        e6 = Enum.GetName(Input.O);
                        break;
                    case (1, Section.TopLeft):
                        e7 = Enum.GetName(Input.O);
                        break;
                    case (1, Section.TopMiddle):
                        e8 = Enum.GetName(Input.O);
                        break;
                    case (1, Section.TopRight):
                        e9 = Enum.GetName(Input.O);
                        break;
                }
            }
            else
            {

                Console.WriteLine("Sorry that spot is already taken!");
                //Board(turn, section); TODO: replay turn
            }
            TurnChanger();
            Console.WriteLine($" {e7} | {e8} |{e9}  "); //top row
            Console.WriteLine($"---+---+---"); //top line
            Console.WriteLine($" {e4} | {e5} |{e6}  "); //middle row
            Console.WriteLine($"---+---+---"); //top line //middle line
            Console.WriteLine($" {e1} | {e2} |{e3}   "); //bottom row

        }
        public bool CheckIfSpotTaken()
        {
            string[] eValues = { e1, e2, e3, e4, e5, e6, e7, e8, e9 };
            bool isSectionTaken = false;
            for (int i = 0; i < eValues.Length; i++)
            {
                if (eValues[i] == "X" || eValues[i] == "O") { isSectionTaken = true; }
            }

            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int TurnChanger()
        {
            return Turn == 0 ? Turn += 1 : Turn -= 1;
        }
        //public void PlaceInput(int turn, Section section)
        //{
        //    if (turn == 0) { Console.WriteLine(Input.X); }
        //    if (turn == 1) { Console.WriteLine(Input.O); }
        //}
        //public void BottomLeft() { }
        //public void BottomMiddle() { }
        //public void BottomRight() { }
        //public void MiddleLeft() { }
        //public void MiddleMiddle() { }
        //public void MiddleRight() { }
        //public void TopLeft() { }
        //public void TopMiddle() { }
        //public void TopRight() { }

    }
}
