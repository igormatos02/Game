using Game.UI.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.UI.UIHelpers
{
    public static class ConsoleHelper
    {
        internal static void PrintBlue(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void PrintLine()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(UIConstants.LineText);
            Console.WriteLine();

        }

        internal static void PrintYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void PrintEndGame()
        {
            PrintLine();
            PrintBlue(String.Format("{0} : ", UIConstants.Winner));
            PrintLine();

            PrintYellow(UIConstants.NewGame);
            PrintYellow(UIConstants.QuitGame);
        }

        internal static void PrintEndMatch()
        {
            //PrintLine();
            //PrintBlue(String.Format("{0} : ", UIConstants.Winner));
            //PrintLine();

            //Console.WriteLine("1 - NEW GAME");
            //Console.WriteLine("2 - QUIT");
        }

        internal static void PrintRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void PrintWhite(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }

        internal static void ShowGameMenuForPlayer()
        {
            PrintLine();
            PrintYellow(UIConstants.RoundOptions);
            PrintLine();
            PrintBlue(String.Format("{0} - {1}", 1,UIConstants.Rock));
            PrintBlue(String.Format("{0} - {1}", 2, UIConstants.Paper));
            PrintBlue(String.Format("{0} - {1}", 3, UIConstants.Scissor));
        }

        internal static void PrintTieInTheGame(string player1Movement,string player2Movement)
        {
            PrintYellow(UIConstants.NoWinner);
            PrintWhite(String.Format("{0} OVER {1}",player1Movement , player2Movement));

        }

        internal static void PrintWinner(string playerDescription, string looserMoveDescription,string winnerMoveDescription)
        {
            PrintBlue(UIConstants.Winner);
            PrintWhite(String.Format("{0} OVER {1}", winnerMoveDescription, looserMoveDescription));
           
        }

        internal static void PrinEndTurn()
        {
            PrintRed(UIConstants.PressKey);
            PrintLine();
        }

        internal static void PrintMainMenu()
        {
            PrintWhite(String.Format("{0},{1},{2} GAME", UIConstants.Rock, UIConstants.Scissor, UIConstants.Paper));
            PrintLine();
            PrintBlue(UIConstants.SelectePlayerOption);
            PrintLine();
            PrintYellow(String.Format("1 - {0}",UIConstants.HumanPlayer));
            PrintYellow(String.Format("2 - {0}", UIConstants.RandomComputerPlayer));
            PrintYellow(String.Format("3 - {0}", UIConstants.TaticalComputerPlayer));
            PrintLine();
        }
    }
}
