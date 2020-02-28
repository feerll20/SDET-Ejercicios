using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_devCS
{
    class Class2
    {
        List<int> List1 = new List<int>() { 6, 8, 15, 35, 1, 93, 12, 4 };
        List<int> List2 = new List<int>();
        public void PrintFirstFiveValues()
        {
            for (int i = 0; i < 5; i++)
            {
                List2.Add(List1[i]);
            }
            for(int j= 0; j < 5; j++)
            {
                Console.WriteLine(List2[j]);
            }
            Console.WriteLine("\n");
        }

        private int[] NumbersToIterate = { 9, 59, 1, 44, 5, 19, 5, 16, 2, 7 };
        private int SaveValue;
        public void PrintSmallestNumber()
        {
            for (int i = 0; i < NumbersToIterate.Length; i++)
            {
                for (int j = i + 1; j < NumbersToIterate.Length; j++)
                {
                    if (NumbersToIterate[i] < NumbersToIterate[j])
                    {
                        SaveValue = NumbersToIterate[i];
                        NumbersToIterate[i] = NumbersToIterate[j];
                        NumbersToIterate[j] = SaveValue;
                    }
                }
            }
            Console.WriteLine("The smallest number of the array is {0}\n", NumbersToIterate[NumbersToIterate.Length-1]);
        }

        public void PrintDictionaryByKey()
        {
           var FerDictionary = new Dictionary<string, int>()
           {
            {"FerLL", 20},
            {"Orlando", 3},
            {"Flor", 26},
            {"FerLV", 10},
            {"Minie", 13},
            {"Angel", 5},
            {"Robert", 11},
            {"Mary", 29}
           };
            foreach (KeyValuePair<string, int> KeyAndValue in FerDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", KeyAndValue.Key, KeyAndValue.Value);
            }
        }

    }
}
