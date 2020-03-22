using System;

namespace Ex3_devCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB Clase = new ClassB();
            Clase.ListsAndStringsMatching();
            Console.WriteLine("\n");
            ClassB OrderedWords = new ClassB();
            OrderedWords.OrderListAscDesc("asc");
            Console.WriteLine("\n");
            ClassB FilterSpaces = new ClassB();
            FilterSpaces.SpaceFilteredList();
            Console.WriteLine("\n");
            ClassB RemovedDuplicated = new ClassB();
            RemovedDuplicated.RemoveDuplicateInts();
            Console.WriteLine("\n");
            ClassB PrintHelloWorld = new ClassB();
            PrintHelloWorld.Printhello();
        }
    }
}
