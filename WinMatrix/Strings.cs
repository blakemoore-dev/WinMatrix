using System;
using System.Collections.Generic;
using static System.Console;

namespace WinMatrix
{
    public static class Strings
    {
        public static char[] alphaNum = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', '{', ']', '}', '\\', '|', ';', ':', '\'', '"', ',', '<', '.', '>', '/', '?' };

        public static Random rand = new Random();

        public static string GenerateCascade(int startY)
        {
            var temp = new char[rand.Next(0, WindowHeight)];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = alphaNum[rand.Next(alphaNum.Length - 1)];
            }

            return new String(temp);
        }
    }
}
