using School;
using System;
using System.Threading;

namespace CalculatorPro
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set
            {
                field = value;
            }
            get
            {
                return field;
            }

        }
    }
    class Program
    {
        static void Main()
        {
            MyClass obj = new MyClass();

            obj.Field = "Hello world";

            Console.WriteLine(obj.Field);

            string nameProgram = Console.ReadLine();
            string surnameProgram = Console.ReadLine();
            string patronymicProgram = Console.ReadLine();

            fullNameChild name = new fullNameChild(nameProgram, surnameProgram, patronymicProgram);
            Console.WriteLine($"Ваше имя : {name.Name}, ваша фамилия : {name.Surname}, ваше очество : {name.Patronymic}");


            Console.ReadKey();
        }
    }
}