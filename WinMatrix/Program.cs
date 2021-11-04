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
            Populate();

            var columns = WindowWidth - 1;
            var rows = WindowHeight - 1;

            var columnList = new List<string>();

            var test01 = GenerateCascade(0);
            var test02 = GenerateCascade(0);

            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            CursorVisible = false;

            for (int i = 0; i < rows && i < test01.Length - 1; i++)
            {
                SetCursorPosition(0, 0);
                Grid[i, 0] = test01[i];
                Draw();
                SetCursorPosition(1, 0);
                Grid[i, 1] = test02[i];
                Draw();
            }

            ReadKey();
            ResetColor();
        }
    }
}
