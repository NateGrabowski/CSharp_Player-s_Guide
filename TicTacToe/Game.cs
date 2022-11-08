using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public int Turn = 0; //Player 1 && Player 2 1
        //private string e1, e2, e3, e4, e5, e6, e7, e8, e9;
        private string e1 = " ", e2 = " ", e3 = " ", e4 = " ", e5 = " ", e6 = " ", e7 = " ", e8 = " ", e9 = " ";
        public Input input { get; set; }
        public Section section { get; set; }
        public enum Input { X, O }
        public enum Section { BottomLeft, BottomMiddle, BottomRight, MiddleLeft, MiddleMiddle, MiddleRight, TopLeft, TopMiddle, TopRight }

        public void PlayGame()
        {
            while (true) //result of tie & winner should end game
            {
                Console.Title = "Tic-Tac-Toe Console App";
                DisplayBoard();
                Console.WriteLine("Where would you like to place your input? Use the number pad to guide your choice.");
                Console.Write($"Player {Turn}: ");
                int input = Convert.ToInt16(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        PlaceMark(Turn, Section.BottomLeft);
                        break;
                    case 2:
                        PlaceMark(Turn, Section.BottomMiddle);
                        break;
                    case 3:
                        PlaceMark(Turn, Section.BottomRight);
                        break;
                    case 4:
                        PlaceMark(Turn, Section.MiddleLeft);
                        break;
                    case 5:
                        PlaceMark(Turn, Section.MiddleMiddle);
                        break;
                    case 6:
                        PlaceMark(Turn, Section.MiddleRight);
                        break;
                    case 7:
                        PlaceMark(Turn, Section.TopLeft);
                        break;
                    case 8:
                        PlaceMark(Turn, Section.TopMiddle);
                        break;
                    case 9:
                        PlaceMark(Turn, Section.TopRight);
                        break;
                }
            }
        }
        public void PlaceMark(int turn, Section section)
        {
            switch (turn, section)
            {
                case (0, Section.BottomLeft):
                    if (e1 == " ") { e1 = Enum.GetName(Input.X); }
                    break;
                case (0, Section.BottomMiddle):
                    if (e2 == " ") { e2 = Enum.GetName(Input.X); }
                    break;
                case (0, Section.BottomRight):
                    if (e3 == " ") { e3 = Enum.GetName(Input.X); }
                    break;
                case (0, Section.MiddleLeft):
                    if (e4 == " ") { e4 = Enum.GetName(Input.X); }
                    break;
                case (0, Section.MiddleMiddle):
                    if (e5 == " ") { e5 = Enum.GetName(Input.X); }
                    break;
                case (0, Section.MiddleRight):
                    if (e6 == " ") { e6 = Enum.GetName(Input.X); }
                    break;
                case (0, Section.TopLeft):
                    if (e7 == " ") { e7 = Enum.GetName(Input.X); }
                    break;
                case (0, Section.TopMiddle):
                    if (e8 == " ") { e8 = Enum.GetName(Input.X); }
                    break;
                case (0, Section.TopRight):
                    if (e9 == " ") { e9 = Enum.GetName(Input.X); }
                    break;
                case (1, Section.BottomLeft):
                    if (e1 == " ") { e1 = Enum.GetName(Input.O); }
                    break;
                case (1, Section.BottomMiddle):
                    if (e2 == " ") { e2 = Enum.GetName(Input.O); }
                    break;
                case (1, Section.BottomRight):
                    if (e3 == " ") { e3 = Enum.GetName(Input.O); }
                    break;
                case (1, Section.MiddleLeft):
                    if (e4 == " ") { e4 = Enum.GetName(Input.O); }
                    break;
                case (1, Section.MiddleMiddle):
                    if (e5 == " ") { e5 = Enum.GetName(Input.O); }
                    break;
                case (1, Section.MiddleRight):
                    if (e6 == " ") { e6 = Enum.GetName(Input.O); }
                    break;
                case (1, Section.TopLeft):
                    if (e7 == " ") { e7 = Enum.GetName(Input.O); }
                    break;
                case (1, Section.TopMiddle):
                    if (e8 == " ") { e8 = Enum.GetName(Input.O); }
                    break;
                case (1, Section.TopRight):
                    if (e9 == " ") { e9 = Enum.GetName(Input.O); }
                    break;
            }
        }

        //public bool CheckIfSpotTaken()
        //{
        //    string[] eValues = { e1, e2, e3, e4, e5, e6, e7, e8, e9 };




        //    //bool isSectionTaken = false;
        //    //for (int i = 0; i < eValues.Length; i++)
        //    //{
        //    //    if (eValues[i] == "X" || eValues[i] == "O") { isSectionTaken = true; }
        //    //}

        //}
        public void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine($" {e7} | {e8} |{e9}  "); //top row
            Console.WriteLine($"---+---+---"); //top line
            Console.WriteLine($" {e4} | {e5} |{e6}  "); //middle row
            Console.WriteLine($"---+---+---"); //top line //middle line
            Console.WriteLine($" {e1} | {e2} |{e3}   "); //bottom row
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
