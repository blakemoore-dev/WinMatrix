using System;
using System.Threading;
using static System.Console;
using static WinMatrix.Strings;

namespace WinMatrix
{
    public static class Buff
    {
        // Set grid equal to window height and width
        public static object[,] Grid { get; set; } = new object[WindowHeight - 1, WindowWidth - 1];

        // Populate buffer with whitespace to create default grid
        public static void Populate(char defaultCharacter = ' ')
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Grid[i, j] = defaultCharacter;
                }
            }
        }

        // Draw entire buffer
        public static void Draw(int delay = 0)
        {
            SetCursorPosition(0, 0);
            CursorVisible = false;
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Write(Grid[i, j]);
                    Thread.Sleep(delay);
                }
                WriteLine();
            }
        }
    }
}
