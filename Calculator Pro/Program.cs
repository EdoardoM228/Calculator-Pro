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

    enum colors 
    {
        White,
        Green,
        Blue,
        Yellow,
        Red,
        Magenta, 
        Gray
    }



    class Program
    {
        static void Main()
        {
            var aobj = new MyClass();

            aobj.List = new List<string>();

            aobj.List.Add("1asfsdfg");
            aobj.List.Add("sdfsdf2");
            aobj.List.Add("sdfsdfsdf");

            int i = 10;
            //Boxing
            object obj = i;
            //Unboxing
            int j = (int)obj;

            string enumColor = Console.ReadLine();
            bool ignoreCase;
            colors colors = (colors)Enum.Parse(typeof(colors), enumColor, ignoreCase = true);
            Console.WriteLine(colors);

            switch (colors)
            {
                case CalculatorPro.colors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(colors);
                    break;
                case CalculatorPro.colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(colors);
                    break;
                case CalculatorPro.colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(colors);
                    break;
                case CalculatorPro.colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(colors);
                    break;
                case CalculatorPro.colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(colors);
                    break;
                case CalculatorPro.colors.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(colors);
                    break;
                case CalculatorPro.colors.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(colors);
                    break;
                default:
                    break;
            }

            while (true)
            {
                ConsoleKey consoleKey = Console.ReadKey().Key;

                int consoleKeyCode = (int)consoleKey;

                Console.WriteLine($"Клавиша которую нажал : {consoleKey},\n Код этой клавиши : {consoleKeyCode}");
            }


        }
    }
}