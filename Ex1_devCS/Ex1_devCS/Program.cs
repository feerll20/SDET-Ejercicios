using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_devCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class1==================================\n");
            Class1 CompareStrings = new Class1();
            if(CompareStrings.StringComparison() != null)
            {
                Console.WriteLine("The result of two words comparision is {0}\n", CompareStrings.StringComparison());
            }
            Class1 MaxNumber = new Class1();
            MaxNumber.VerifyBiggestNumber();
            Class1 SortDesc = new Class1();
            SortDesc.SortList();
            Class1 StringLength = new Class1();
            Console.WriteLine("\n" + StringLength.CountStringLength() + "\n");
            Console.WriteLine("========================================\n");
            Console.WriteLine("Class2==================================\n");
            Class2 FiveFirstValues = new Class2();
            FiveFirstValues.PrintFirstFiveValues();
            Class2 SmallestNumber = new Class2();
            SmallestNumber.PrintSmallestNumber();
            Class2 PrintDictionary = new Class2();
            PrintDictionary.PrintDictionaryByKey();
            Console.WriteLine("\n========================================\n");
        }
    }
}
