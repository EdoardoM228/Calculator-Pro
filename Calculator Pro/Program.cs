using System;
using System.Collections.Generic;
using System.Threading;

namespace CalculatorPro
{
    public class MyClass
    {
        public IList<string> List { get; set; }
        public IEnumerable<string> BasicList { get; set; }
    }


    delegate void midPoint(int number);

    class eventMidPoint
    {
        public event midPoint point = null;

        public void Count(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i == start + (end - start) / 2)
                {
                    point(i);
                }
            }
        }
    }

    delegate void checkButton();
    class eventsButton
    {
        public event checkButton checkButtonS = null;
        public event checkButton checkButtonW = null;

        public void eventS()
        {
            if (checkButtonS != null)
            {
                checkButtonS.Invoke();
            }
        }

        public void eventW()
        {
            if (checkButtonW != null)
            {
                checkButtonW.Invoke();
            }
        }
    }
    class Program
    {
        static object locker = new object();

        static void obj()
        {
            for(int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', 10) + "Locker");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }    
        }

        //static void printSecond()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine(new string(' ', 10) + "Secondary");
        //    }
        //}

        static void Main()
        {
            ////  ThreadStart writeSecond = new ThreadStart(printSecond);
            //  //Thread thread = new Thread(printSecond);
            //  //thread.Start();

            //  while (true)
            //  {
            //      Console.WriteLine("Primary");
            //  }
            Console.SetWindowSize(80, 45);

            ThreadStart locker1 = new ThreadStart(obj);
            Thread thread = new Thread(obj);
            thread.Start();

            for(int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("UnLocker");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
        }

    }
}

