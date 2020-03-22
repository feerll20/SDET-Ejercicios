using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_devCS
{
    public interface ISDETInterface
    {
         void Printhello();
    }
    class ClassA : ISDETInterface
    {
        private string Word1= "sdaaaaasda";
        private string Word2="sdaaaaasda";
        public bool CompareTwoStrings()
        {
            if(Word1.Length == Word2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<int> List1 = new List<int> {1,5,3,1,4,13,31,45,6,1,2,4,5};
        private List<int> List2 = new List<int> {9,7,11,10,50,22,65,1,4,6,7,9,6};
        private int CountList1 = 0, CountList2 = 0;
        public bool CompareTwoLists()
        {
            foreach(var x in List1)
            {
                CountList1++;
            }
            foreach(var y in List2)
            {
                CountList2++;
            }
            if(CountList1 == CountList2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Printhello()
        {
            throw new NotImplementedException();
        }
    }
}
