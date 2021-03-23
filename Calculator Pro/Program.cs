using System;
using System.Threading;

namespace CalculatorPro
{
    class Program
    {
        private static void Main()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(WriteChar));

            Console.WriteLine("Нажмите любую клавишу ");
            Console.ReadKey();

            thread.Start('*');

            for (int i = 0; i < 80; i++)
            {
                Console.Write('-');
                Thread.Sleep(70);
            }
        }

        private static void WriteChar(object arg)
        {
            char item = (char)arg;
            for (int i = 0; i < 80; i++)
            {
                Console.Write(item);
                Thread.Sleep(70);
            }
        }
    }
}