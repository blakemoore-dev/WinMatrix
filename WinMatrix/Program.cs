using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using static System.Console;
using static WinMatrix.Buff;
using static WinMatrix.Strings;
using Pastel;
using System.Collections.Generic;

namespace WinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create grid
            Populate();

            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            CursorVisible = false;

            while (true) // TODO: Abstract to method or class
            {
                for (int i = 0; i < WindowHeight; i++)
                {
                    for (int j = 0; j < WindowHeight - 1; j++)
                    {
                        var randStr = GenerateCascade();

                        var curPos = GetCursorPosition();

                        if (curPos.Top == WindowHeight - 1)
                        {
                            j = 1;
                        }

                        // Trailing chars
                        SetCursorPosition(0, j);
                        ForegroundColor = ConsoleColor.Cyan;
                        WriteLine(randStr[j]);

                        // Head char
                        SetCursorPosition(0, j + 1);
                        ForegroundColor = ConsoleColor.White;
                        WriteLine((char)rand.Next(33,126));
                        Thread.Sleep(100); // <<<<< TODO: Delay variable
                    }
                }
            }

            //while (true)
            //{
            //    var test = GenerateCascade();
            //    Console.WriteLine(test + '|');
            //    Thread.Sleep(100);
            //}
        }
    }
}
