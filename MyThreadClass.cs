using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermsTP
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount <= 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);
            }
        }
    }
}
