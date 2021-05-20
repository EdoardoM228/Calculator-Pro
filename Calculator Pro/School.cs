using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// ICollection<T> - определяет методы, используемые для управления универсальными коллекциями.

namespace Collection
{
    public class Persone
    {
        public string fName;
        public string sName;

        public Persone(string f , string s)
        {
            fName = f;
            sName = s;
        }
    }    

    public class People : IEnumerable
    {
        private Persone[] persone;

        public People(Persone[] personeArray)
        {
            persone = new Persone[personeArray.Length];

            for(int i = 0; i < personeArray.Length; i++)
            {
                persone[i] = personeArray[i];
            }   
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public peopleEnum GetEnumerator()
        {
            return new peopleEnum(persone);
        }

    }

    public class peopleEnum : IEnumerator
    {
        public Persone[] persone;

        int position = -1;

        public peopleEnum(Persone[] listPersone)
        {
            persone = listPersone;
        }

        public bool MoveNext()
        {
            position++;
            return (position < persone.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public Persone Current
        {
            get
            {
                try
                {
                    return persone[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
                finally
                {
                    Console.WriteLine("Завершение");
                }
            }
        }


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
    }
}
