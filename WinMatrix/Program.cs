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

            for (int i = 0; i < 10; i++)
            {
                SetCursorPosition(0, i);
                Thread.Sleep(20);
                Console.WriteLine((char)rand.Next(32, 126));
            }

            ReadKey();
            ResetColor();
        }
    }
}
