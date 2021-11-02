using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using static System.Console;
using static WinMatrix.Buff;
using static WinMatrix.Strings;
using Pastel;

namespace WinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Populate();
            var test01 = GenerateCascade(rand.Next(WindowWidth));

            Clear();
            ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < WindowHeight - 1 && i < test01.Length - 1; i++)
            {
                Grid[i, 0] = test01[i];
                Draw();
            }


            ReadKey();
            ResetColor();
        }
    }
}
