using System;
using System.Threading;

namespace CalculatorPro
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("На каком топливе запустить ракету(diesel or benzin) : ");
                string chooseFuel = Console.ReadLine();
                switch (chooseFuel)
                {
                    case "diesel":
                        rocket rocket = new rocket();
                        rocket.rocketHad = new rocketHad();
                        rocket.engine = new dieselEngine();
                        rocket.engine.engineStart();
                        Console.WriteLine($"Тяга двигателя : {tiaga(rocket.weight, rocket.engine.power)}");
                        rocket.engine.engineStop();
                        break;

                    case "benzin":
                        benzinEngine benzin = new benzinEngine();
                        benzin.engineStart();
                        int weight = benzin.chooseWeight(), power = benzin.choosePower();
                        Console.WriteLine($"Вес : {weight}, Сила : {power}");
                        Console.WriteLine($"Тяга двигателя : {tiaga(weight, power)}");
                        benzin.engineStop();
                        break;
                    default:
                        Console.WriteLine("такого топлива нет...");
                        break;
                }
                Console.WriteLine("Нажми любую клавишу , чтобы повторить");
                Console.ReadKey();
            }
        }
        public static int tiaga(int mass , int power)
        {
            return (mass / power * 10) + 82;
        }
    }
}