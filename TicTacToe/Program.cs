// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("   |   |");
//Console.WriteLine("---+---+---");

using TicTacToe;

//Game game1 = new Game();
//game1.PlayGame();
string e1 = "X", e2 = "X", e3 = "X", e4 = "O", e5 = "X", e6 = "O", e7 = "O", e8 = "X", e9 = "O";

Game play = new Game();
play.PlayGame();

//(string, string, string) xWinner = ("X", "X", "X");
//(string, string, string) oWinner = ("O", "O", "O");


//(string, string, string) BottomRow = (e1, e2, e3);
//(string, string, string) MiddleRow = (e4, e5, e6);
//(string, string, string) TopRow = (e7, e8, e9);
//(string, string, string) FirstColumn = (e7, e4, e1);
//(string, string, string) SecondColumn = (e8, e5, e2);
//(string, string, string) ThirdColumn = (e9, e6, e3);
//(string, string, string) LeftDiagonal = (e7, e5, e3);
//(string, string, string) RightDiagonal = (e1, e5, e9);

//object[] winCon =
//{
//    BottomRow,
//    MiddleRow,
//    TopRow,
//    FirstColumn,
//    SecondColumn,
//    ThirdColumn,
//    LeftDiagonal,
//    RightDiagonal
//};

//if (winCon.Contains(xWinner) || winCon.Contains(oWinner)) { Console.WriteLine($"Player {Turn} has won.") }
