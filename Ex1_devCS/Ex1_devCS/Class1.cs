using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks; 

namespace Ex1_devCS
{
    class Class1
    {
        private string Word1 = "sascdgtyasdserferdertrertfdsedera";
        private string Word2 = null;
        private bool ResultOfComparison;
        private int WordIndex = 0;
        public string StringComparison()
        {
            try
            {
                if(Word1 is null || Word2 is null)
                {
                    throw new NullReferenceException();
                }
                if (Word1.Length == Word2.Length)
                {
                    ResultOfComparison = true;
                    while (ResultOfComparison == true && WordIndex < Word1.Length)
                    {
                        if (Word1[WordIndex] == Word2[WordIndex])
                        {
                            WordIndex++;
                        }
                        else
                        {
                            ResultOfComparison = false;
                        }
                    }
                }
                else
                {
                    ResultOfComparison = false;
                }
                return ResultOfComparison.ToString();
            }
            catch (NullReferenceException NullEx)
            {
                Console.WriteLine("Caught FLQA_Exception: {0}\n", NullEx);
                return null;
            }
            //return ResultOfComparison.ToString();
        }

        private int[] NumbersToCompare = { 9, 59, 1, 44, 5, 19, 5, 16, 2, 7 };
        private int SaveValue;
        public void VerifyBiggestNumber()
        {
            for(int i=0; i<NumbersToCompare.Length; i++)
            {
                for(int j=i+1; j<NumbersToCompare.Length; j++)
                {
                    if(NumbersToCompare[i] < NumbersToCompare[j])
                    {
                        SaveValue = NumbersToCompare[i];
                        NumbersToCompare[i] = NumbersToCompare[j];
                        NumbersToCompare[j] = SaveValue;
                    }
                }
            }
            Console.WriteLine("The biggest number in the list is {0}\n", NumbersToCompare[0]);
        }

        public void SortList()
        {
            for (int i=0; i<NumbersToCompare.Length; i++)
            {
                for (int j=i+1; j<NumbersToCompare.Length; j++)
                {
                    if (NumbersToCompare[i] < NumbersToCompare[j])
                    {
                        SaveValue = NumbersToCompare[i];
                        NumbersToCompare[i] = NumbersToCompare[j];
                        NumbersToCompare[j] = SaveValue;
                    }
                }
            }
            for(int k=0; k<NumbersToCompare.Length; k++)
            {
                Console.WriteLine(NumbersToCompare[k]+"\t"+NumbersToCompare[(NumbersToCompare.Length - 1)-k]);
            }
        }

        private int StringLength = 1;
        public int CountStringLength()
        {
            for(int i=0; i<Word1.Length; i++)
            {
                StringLength++;
            }
            return StringLength;
        }
    }
}
