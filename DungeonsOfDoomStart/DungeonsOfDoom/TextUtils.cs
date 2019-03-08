using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DungeonsOfDoom
{
    static class TextUtils
    {
        public static void CoolText(string text, int delay)
        {
            foreach (var c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}
