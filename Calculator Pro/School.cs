using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorPro
{
    interface engine
    {
        void engineStart();
        void engineStop();
        int weight { get; }
        int power { get; }
    }

    class rocket
    {
        public  engine engine { get; set; }
        public  rocketHad rocketHad{ get; set; }

        public int weight
        {
            get
            {
                return rocketHad.massRocketHad() + engine.weight;
            }
        }
    }

    class rocketHad
    {
        public int cosmonavt { get; set; }
        public int massShell { get; set; }

        public rocketHad()
        {
            cosmonavt = 3;
            massShell = 2000000;
        }

        public int massRocketHad()
        {
            return (cosmonavt * 80) + massShell;
        }
    }

    class dieselEngine : engine
    {
        public int power { get; }
        public int weight { get; }

        public dieselEngine()
        {
            weight = 150000;
            power = 600;
        }

        public void engineStart()
        {
            Console.WriteLine("Двигатель запущен..");
        }

        public void engineStop()
        {
            Console.WriteLine("Двигатель заглушен..");
        }
    }

    class benzinEngine : engine
    {
        public int weight { get; }
        public int power { get; }

       public int chooseWeight()
        { 
            int weight = 0;
            Console.Write("Введи вес двигателя : ");
            return weight = Convert.ToInt32(Console.ReadLine());
        }

        public int choosePower()
        {
            int power = 0;
            Console.Write("Введи силу двигателя : ");
            return power = Convert.ToInt32(Console.ReadLine());
        }

        public void engineStart()
        {
            Console.WriteLine("Двигатель запущен..");
        }

        public void engineStop()
        {
            Console.WriteLine("Двигатель заглушен..");
        }
    }
}