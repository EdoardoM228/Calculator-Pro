using System;
using System.Threading;

namespace CalculatorPro
{
    partial class classRoom
    {
        partial void classRoom1()
        {
            Console.WriteLine("Hello Im Classroom 10-A");
        }

        partial void classRoom2()
        {
            Console.WriteLine("Hello Im Class 10-B");
        }

        public void startClassRoomMethod()
        {
            classRoom1();
            classRoom2();
        }
    }
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

            classRoom classRoom = new classRoom();

            classRoom.startClassRoomMethod();

            Console.ReadKey();
        }
    }
}