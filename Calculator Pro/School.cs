using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorPro
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void Roar()
        {
            Console.WriteLine("AYE");
        }
    }

    class cat : Animal
    {
        public override void Roar()
        {
            Console.WriteLine("Мяу");
        }
    }

    class dog : Animal
    {
        public override void Roar()
        {
            Console.WriteLine("Гав");
        }

    }

    class duck : Animal
    {
        public override void Roar()
        {
            Console.WriteLine("Кря");
        }
    }

    class Car
    {
        protected virtual void startEngine()
        {
            Console.WriteLine("Мотор завелся");
        }

        public virtual void carMove()
        {
            startEngine();
            Console.WriteLine("Я еду");
        }
    }

    class sportCar : Car
    {
        protected override void startEngine()
        {
            Console.WriteLine("AKRAPOVICH");
        }

        public override void carMove()
        {
            startEngine();
            Console.WriteLine("Я гоню");
        }
    }

    class truck : Car
    {
        protected override void startEngine()
        {
            Console.WriteLine("IM BIG TRUCK");
        }

        public override void carMove()
        {
            startEngine();
            Console.WriteLine("Я медленно плетусь , за то я огромный");
        }
    }
}