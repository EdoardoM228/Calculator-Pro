using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorPro
{
    partial class classRoom
    {
        partial void classRoom1();

        partial void classRoom2();
    }
    class fullNameChild
    {
        private string name, surname, patronymic;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Patronymic
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

        public fullNameChild(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }

    }
}