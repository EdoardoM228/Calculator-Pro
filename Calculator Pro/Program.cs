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

    struct MyStruct
    {
        private string firstName, secondName, patronymic;
        private int age;

        public MyStruct(string firstName, string secondName, string patronymic, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.patronymic = patronymic;
            this.age = age;
        }

        public string MyStructName 
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string MyStruct2Name
        {
            get
            {
                return secondName;
            }
            set
            {
                secondName = value;
            }
        }

        public string MyStructPatronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
            }
        }

        public int MyStructAge
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void MyStructWrite()
        {
            Console.WriteLine($"Ваше имя : {firstName}");
            Console.WriteLine($"Ваша фамилия : {secondName}");
            Console.WriteLine($"Ваше отчество : {patronymic}");
            if (age < 18)
            {
                Console.WriteLine($"Ваш возраст : {age}, вы не совершенно летний.");
            }
            else
            {
                Console.WriteLine($"Ваш возраст : {age}, вы совершенно летний");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var aobj = new MyClass();

            aobj.List = new List<string>();

            aobj.List.Add("1asfsdfg");
            aobj.List.Add("sdfsdf2");
            aobj.List.Add("sdfsdfsdf");

            MyStruct myStruct = new MyStruct("Edward", "Mihai", "Alex", 16);
            myStruct.MyStructWrite();

            MyStruct myStruct1 = new MyStruct("Danil", "Dmitrev", "Andreivici", 54);
            myStruct1.MyStructWrite();

            MyStruct myStruct2 = new MyStruct();
            myStruct2.MyStructName = "Viktor";
            myStruct2.MyStruct2Name = "Druje";
            myStruct2.MyStructPatronymic = "Nikolaevici";
            myStruct2.MyStructAge = 98;
            myStruct2.MyStructWrite();
        }
    }
}