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

    delegate void checkButton();

    class eventsButton
    {
        public event checkButton checkButtonS = null;
        public event checkButton checkButtonW = null;

        public void eventS()
        {
            if(checkButtonS != null)
            {
                checkButtonS.Invoke();
            }
        }

        public void eventW()
        {
            if(checkButtonW != null)
            {
                checkButtonW.Invoke();
            }
        }
    }
    class Program
    {
        static void buttonSClick()
        {
            Console.WriteLine("Вперед");
        }

        static void buttonWClick()
        {
            Console.WriteLine("Вперед");
        }


        static void Main()
        {
            eventsButton sOrw = new eventsButton();

            sOrw.checkButtonS += buttonSClick;
            sOrw.checkButtonW += buttonWClick;

            ConsoleKey consoleKey;

            while (true)
            {
                consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.W :
                        sOrw.eventW();
                        break;
                    case ConsoleKey.S:
                        sOrw.eventS();
                        break;  

                }
            }

    
        }
    }
}
