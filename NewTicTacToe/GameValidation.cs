using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTicTacToe
{
    public class GameValidation
    {
        public bool ValidationProcess(string[] arr)
        {
            if (LeftVerticalCheck(arr))
                return true;
            if (RightVerticalCheck(arr))
                return true;
            if (MiddleVerticalCheck(arr))
                return true;

            if (TopHorizontalCheck(arr))
                return true;
            if (MiddleHorizontalCheck(arr))
                return true;
            if (BottomHorizontalCheck(arr))
                return true;

            if (LeftToRightDiagnol(arr))
                return true;
            if (RightToLeftDiagnol(arr))
                return true;
            return false;
        }

        public bool IsDraw(string[] arr)
        {
            if (!arr.Contains("_"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Match Draw");
                Console.ResetColor();
                return true;
            }
            return false;
        }

        public bool CheckEmptyValues(string v1, string v2, string v3)
        {
            if (v1 != "_" && v2 != "_" && v3 != "_")
                return true;
            else
                return false;
        }

        public bool LeftVerticalCheck(string[] arr)
        {
            string v1 = arr[0];
            string v2 = arr[3];
            string v3 = arr[6];
            if (v1 == v2 && v2 == v3 && CheckEmptyValues(v1, v2, v3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player\t" + v1 + "\tWon Game");
                return true;
            }
            else
                return false;
        }

        public bool RightVerticalCheck(string[] arr)
        {
            string v1 = arr[2];
            string v2 = arr[5];
            string v3 = arr[8];
            if (v1 == v2 && v2 == v3 && CheckEmptyValues(v1, v2, v3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player\t" + v1 + "\tWon Game");
                return true;
            }
            else
                return false;
        }
        public bool MiddleVerticalCheck(string[] arr)
        {
            string v1 = arr[1];
            string v2 = arr[4];
            string v3 = arr[7];
            if (v1 == v2 && v2 == v3 && CheckEmptyValues(v1, v2, v3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player\t" + v1 + "\tWon Game");
                return true;
            }
            else
                return false;
        }

        public bool TopHorizontalCheck(string[] arr)
        {
            string v1 = arr[0];
            string v2 = arr[1];
            string v3 = arr[2];
            if (v1 == v2 && v2 == v3 && CheckEmptyValues(v1, v2, v3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player\t" + v1 + "\tWon Game");
                return true;
            }
            else
                return false;
        }
        public bool MiddleHorizontalCheck(string[] arr)
        {
            string v1 = arr[3];
            string v2 = arr[4];
            string v3 = arr[5];
            if (v1 == v2 && v2 == v3 && CheckEmptyValues(v1, v2, v3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player\t" + v1 + "\tWon Game");
                return true;
            }
            else
                return false;
        }
        public bool BottomHorizontalCheck(string[] arr)
        {
            string v1 = arr[6];
            string v2 = arr[7];
            string v3 = arr[8];
            if (v1 == v2 && v2 == v3 && CheckEmptyValues(v1, v2, v3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player\t" + v1 + "\tWon Game");
                return true;
            }
            else
                return false;
        }

        public bool LeftToRightDiagnol(string[] arr)
        {
            string v1 = arr[0];
            string v2 = arr[4];
            string v3 = arr[8];
            if (v1 == v2 && v2 == v3 && CheckEmptyValues(v1, v2, v3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player\t" + v1 + "\tWon Game");
                return true;
            }
            else
                return false;
        }

        public bool RightToLeftDiagnol(string[] arr)
        {
            string v1 = arr[2];
            string v2 = arr[4];
            string v3 = arr[6];
            if (v1 == v2 && v2 == v3 && CheckEmptyValues(v1, v2, v3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player\t" + v1 + "\tWon Game");
                return true;
            }
            else
                return false;
        }
    }
}
