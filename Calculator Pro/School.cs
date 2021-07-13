﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// ICollection<T> - определяет методы, используемые для управления универсальными коллекциями.

namespace TypeTest
{
    public class Class1 : IInterface1, IInterface2
    {
        // Поля.         
        public int myint;
        private string mystring = "Hello";

        // Конструкторы.
        public Class1() { }
        public Class1(int i)
        {
            this.myint = i;
        }

        // Свойства.
        public int myProp
        {
            get { return myint; }
            set { myint = value; }
        }

        public string MyString
        {
            get { return mystring; }
        }

        // Методы.
        public void MethodA() { }
        public void MethodB() { }

        private void MethodC(string str, string str2)
        {
            Console.WriteLine(str + str2);
        }

        public void myMethod(int p1, string p2) { }
    }
    public interface IInterface1
    {
        void MethodA();
    }

    public interface IInterface2
    {
        void MethodB();
    }


}
