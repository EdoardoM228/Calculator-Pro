using System;

namespace Collection
{
    class Program
    {
        static void Main()
        {
            Persone[] persone = { new Persone("Edward", "Mihai"), new Persone("Petea", "Mazilu") };

            var personeCollection = new People(persone);

            foreach(var persone1 in personeCollection)
            {
                Console.WriteLine($"fName : {persone1.fName}, sName : {persone1.sName}");
            }
            Console.ReadKey();
        }
    }
}
