using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Utils
{
    public static class TextUtils
    {
        /// <summary>
        /// Makes text look cool!
        /// </summary>
        /// <param name="text"></param>
        /// <param name="delay"></param>
        
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
