using System;
using System.Threading;

namespace CalculatorPro
{
    class Program
    {
        static void Main()
        {
            Animal[] animal = new Animal[3];

            cat cat = new cat();
            cat.Name = "KOSARA";

            dog dog = new dog();
            dog.Name = "COBAKEN";

            duck duck = new duck();
            duck.Name = "DONALID DUCK";

            animal[0] = cat;
            animal[1] = dog;
            animal[2] = duck;

            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine($"Животное - {animal[i].Name}");
                animal[i].Roar();
            }

            Car lamba = new sportCar();
            lamba.carMove();

            Car men = new truck();
            men.carMove();

            Car acura = new Car();
            acura.carMove();
            
            Console.ReadKey();
        }
    }
}