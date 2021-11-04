using System;
using System.Collections.Generic;
using static System.Console;

namespace WinMatrix
{
    public static class Strings
    {
        public static Random rand = new Random();

        public static string GenerateCascade()
        {
            var temp = new char[rand.Next(10, BufferHeight - 1)];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = (char)rand.Next(32, 126);
            }

            return new String(temp);
        }
    }
}
