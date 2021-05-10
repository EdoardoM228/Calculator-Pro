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

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введи знак / or *");
                string p = Console.ReadLine();
                if(p == "/")
                {
                    int i = Convert.ToInt32(Console.ReadLine());
                    int j = Convert.ToInt32(Console.ReadLine());
                    int c = i / j;
                    Console.WriteLine(c);
                }
                else
                {
                    int i = Convert.ToInt32(Console.ReadLine());
                    int j = Convert.ToInt32(Console.ReadLine());
                    int c = checked(i * j);
                    Console.WriteLine(c);
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Слишком большое число");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Деление на ноль");
            }
            catch(Exception ex)
            {
                Console.WriteLine("какая-то");
            }
            finally
            {
                Console.WriteLine("Работа завершена");
                Console.ReadKey();
            }
        }
        
    }
}

