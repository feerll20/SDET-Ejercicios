using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex3_devCS
{
    class ClassB : ClassA
    {
        public void ListsAndStringsMatching()
        {
            ClassA StringsAndLists = new ClassA();
            if(StringsAndLists.CompareTwoStrings() && StringsAndLists.CompareTwoLists())
            {
                Console.WriteLine("The size of Strings and Lists is matching");
            }
            else
            {
                Console.WriteLine("The size of Strings and Lists is not matching");
            }
        }

        //Create Interface
        public void Printhello()
        {
            Console.WriteLine("Helloooo World!!");
        }

        List<string> ListSDET = new List<string> { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
        public void OrderListAscDesc(string OrderParameter)
        {
            var SortedListAsc = from w in ListSDET
                                 orderby w
                                 select w;
            var SortedListDesc = SortedListAsc.Reverse();
            switch(OrderParameter)
            {
                case "asc":
                    foreach(var word in SortedListAsc)
                    {
                        Console.WriteLine(word);
                    }
                    break;
                case "desc":
                    foreach(var word in SortedListDesc)
                    {
                        Console.WriteLine(word);
                    }
                    break;
                default:
                    Console.WriteLine("The order parameter is not valid, enter asc or desc.");
                    break;
            }
        }

        List<string> ListUnoSqr = new List<string> { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
        public void SpaceFilteredList()
        {
            foreach(var word in ListUnoSqr)
            {
                if (word != " ")
                {
                    Console.WriteLine(word);
                }
            }
        }

        List<int> IntegersList = new List<int> { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
        public void RemoveDuplicateInts()
        {
            for (int i = 0; i < IntegersList.Count(); i++)
            {
                for (int j = i + 1; j < IntegersList.Count(); j++)
                {
                    if (IntegersList[i].ToString() == IntegersList[j].ToString())
                    {
                        IntegersList.RemoveAt(j);
                    }
                }
            }
            foreach (var number in IntegersList)
            {
                Console.WriteLine(number);
            }
        }

    }
}
