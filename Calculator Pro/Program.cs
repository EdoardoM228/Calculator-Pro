using System;
using System.Collections;
using System.Collections.Specialized;

namespace Collection
{
    class Program
    {
        static void Main()
        {
            var que = new Queue();

            object i = 1;

            que.Enqueue(i);
            que.Enqueue("2");
            que.Enqueue("3");
            que.Enqueue("4");

            object obj = que.Peek();
            Console.WriteLine(obj as string);

            if(que.Peek() is string)
            {
                Console.WriteLine(que.Dequeue());
            }

            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }

            var stack = new Stack();

            object j = 2;

            stack.Push(j);
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");

            object sta = stack.Peek();
            Console.WriteLine(sta as string);

            if(stack.Peek() is string)
            {
                Console.WriteLine(stack.Pop());
            }

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }


            var list = new ArrayList();
            object insert = j;


            //Добавляет одиночные элементы 
            string s = "Hello World";
            list.Add(s);
            list.Add("Hello");
            list.Add(255);
            list.Add(new object());

            //Добавляет группу элементов
            var aList = new[] { "Misa", "Kolea", "Petea" };
            list.AddRange(aList);

            //Вставка элемента в определенный индекс
            list.Insert(3, insert);

            var bList = new[] { "Vanea", "Grisa" };
            list.InsertRange(4, bList);

            list[1] = "Hello2";

            //Удаление элемента 
            list.Remove("Hello2");

            list.RemoveAt(6);

            //Удаление с диапазона
            list.RemoveRange(2, 6);

            var dictionary = new ListDictionary();
           
            dictionary["matemitaca"] = "8, 8, 8";
            dictionary["himia"] = "8, 8, 8";
            dictionary["russkii"] = "7, 7, 7";

            foreach (DictionaryEntry entry in dictionary)
            {
                Console.WriteLine($"Ключевое слово {entry.Key}, его значения {entry.Value}");
            }

            Console.WriteLine(dictionary.Equals(dictionary));

            Console.ReadKey();
        }
    }
}
