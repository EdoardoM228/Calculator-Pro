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

    class mercedes<series, typeFuel, engine> : mercedesEngine
    {
        private series classModel;
        private typeFuel typeFuelModel;
        private engine engineModel;
        public series classGet { get; set; }
        public typeFuel typeFuelGet { get; set; }
        public engine engineGet { get; set; }

        public void readyMercedesCarModel()
        {
            Console.WriteLine($"Индекс серии : {classGet}, тип топлива : {typeFuelGet}, размер двигателя : {engineGet}");
        }
    }
    
    class mercedesEngine : engineVechile
    {

        public int weight { get; set; }
        public int power{ get; set; }
        public void engineStartNormalCar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Im normal car");
            Console.ResetColor(); 
        }

        public void engineStartSportCar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Im sport car");
            Console.ResetColor();
        }

        public void engineStop()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ПШШШШШШШШШШШШШШШШ");
            Console.ResetColor();
        }

        
    }

    class Program
    { 
        static void Main()
        {
            mercedes<string, string, double> mercedes = new mercedes<string, string, double>();        
            mercedes.classGet = "G-class";
            mercedes.typeFuelGet = "diesel";
            mercedes.engineGet = 2.9;

            mercedes<string, string, double> mercedes1 = new mercedes<string, string, double>();
            mercedes1.classGet = "S-class";
            mercedes1.typeFuelGet = "diesel";
            mercedes1.engineGet = 3.2;

            if (mercedes.engineGet >= 3.0)
            {
                mercedes.readyMercedesCarModel();
                mercedes.engineStartSportCar();
            }
            else
            {
                mercedes.readyMercedesCarModel();
                mercedes.engineStartNormalCar();
            }

            if (mercedes1.engineGet >= 3.0)
            {
                mercedes1.readyMercedesCarModel();
                mercedes1.engineStartSportCar();
            }
            else
            {
                mercedes1.readyMercedesCarModel();
                mercedes1.engineStartNormalCar();
            }
        }
    }
}
