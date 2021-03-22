using System;

namespace CalculatorPro 
{
    class Program
    {
        static double Calculator(string line, double number1, double number2)
        {
            double number3;
            switch (line)
            {
                case "/":
                    number3 = number1 / number2;
                    return number3;
                case "+":
                    number3 = number1 + number2;
                    return number3;
                case "-":
                    number3 = number1 - number2;
                    return number3;
                case "*":
                    number3 = number1 * number2;
                    return number3;
                default:
                    return 0;
            }
        }



        static void Main(string[] args)
        {
            int[] matrix = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= matrix.Length - 1; i++)
            {
                if (matrix[i] % 3 == 0)
                {
                    Console.WriteLine($"{matrix[i]} ");
                }
                else
                {
                    Console.Write($"{matrix[i]} ");
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("+ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("0 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("/ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("= ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("* ");
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine("\nDoriti sa calculati ceva ?");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "Da":
                    case "da":
                    case "Yes":
                    case "yes":
                        Console.WriteLine("Ce operatiune doriti ?(+,-,*,/)");
                        string symbol = Console.ReadLine();
                        Console.Write("Prima cifra : ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Al doilea : ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Raspunsul este : {Calculator(number1: num1, number2: num2, line: symbol)}");
                        break;
                    default:
                        break;
                }

            }

        }


    }
}