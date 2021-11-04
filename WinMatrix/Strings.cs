using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace WinMatrix
{
    public static class Strings
    {
        public static Random rand = new Random();

        public static string GenerateCascade()
        {
            var temp = new char[WindowHeight - 1];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = (char)rand.Next(32, 126);
            }

            for (int j = rand.Next(0, temp.Length - 1); j < temp.Length; j++)
            {
                temp[j] = ' ';
            }

            return new string(temp);
        }
    }
}
