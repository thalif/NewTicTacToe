using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTicTacToe
{
    class Program
    {
        static public string[] PlayBoard = new string[9] { "_", "_", "_", "_", "_", "_", "_", "_", "_" };
        static public List<int> PlayerHit = new List<int>();
        static bool Player1 = false;
        static bool Player2 = false;
        static void Main(string[] args)
        {
            Toss();
            LoadBoard();
            GameStart();

            Console.ReadKey();
        }
        static public void GameStart()
        {
            GameValidation gv = new GameValidation();
            for (int i = 0; i < 9; i++)
            {
                if (Player1)
                    i -= Player1Input();
                else if (Player2)
                    i -= Player2Input();

                if (i >= 4)
                    if (gv.ValidationProcess(PlayBoard))
                        break;
                    else if(i == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Draw");
                        Console.ResetColor();
                        break;
                    }
            }
        }
        static public void Toss()
        {
            Random random = new Random();
            int ran = random.Next(0, 2);
            if (ran == 0)
            {
                Player1 = true;
                Console.WriteLine("Player X to Start");
            }
            else if (ran == 1)
            {
                Player2 = true;
                Console.WriteLine("Player O to Start");
            }   
        }

        static public bool CheckIsMatchDraw(string[] arr)
        {
            string PreviousValue = "";
            bool IsMatchDraw = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == "_")
                {
                    if (PreviousValue == arr[i])
                    {
                        Console.WriteLine("Match Draw");
                        IsMatchDraw = true;
                        break;
                    }
                    else
                        PreviousValue = arr[i];
                }
                else
                    PreviousValue = arr[i];
            }
            return IsMatchDraw;
        }

        static public void LoadBoard()
        {
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            for (int i = 0; i < PlayBoard.Length; i++)
            {
                if (PlayBoard[i] == "X")
                    Console.ForegroundColor = ConsoleColor.Red;
                else if(PlayBoard[i] == "O")
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(PlayBoard[i] + "\t\t\t\t");
                if (i == 2 || i == 5 || i == 8)
                    Console.Write("\n\n\n\n");
            }
        }

        static public int Player1Input()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Player\tX\t|");
            Console.ResetColor();
            string a = Console.ReadLine();
            int input = int.Parse(a);

            if (!PlayerHit.Contains(input))
            {
                PlayerHit.Add(input);
                PlayBoard[input - 1] = "X";
                LoadBoard();
                Player1 = false;
                Player2 = true;
                return 0;
            }
            else
                return 1;
        }
        static public int Player2Input()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Player\tO\t|");
            Console.ResetColor();
            string a = Console.ReadLine();
            int input = int.Parse(a);

            if (!PlayerHit.Contains(input))
            {
                PlayerHit.Add(input);
                PlayBoard[input - 1] = "O";
                LoadBoard();
                Player1 = true;
                Player2 = false;
                return 0;
            }
            else
                return 1;
        }

        
    }
}
