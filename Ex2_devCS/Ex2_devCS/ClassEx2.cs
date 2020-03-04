using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2_devCS
{
    class ClassEx2
    {
        private string ColorOfCar;
        private string ModelOfCar;
        public void Car(string color = "black", string model = "mazda3")
        {
            ColorOfCar = color;
            ModelOfCar = model;
            Console.WriteLine("My {0} is color {1}\n\n", ModelOfCar, ColorOfCar);
        }

        public string TypeOfCar;
        public int YearOfCar;
        public double PriceOfCar;

        public void CarDetails(string t, int y, double p)
        {
            TypeOfCar = t;
            YearOfCar = y;
            PriceOfCar = p;
            Console.WriteLine("My car's details are:");
            Console.WriteLine("Type of car: {0}", TypeOfCar);
            Console.WriteLine("Year of car: {0}", YearOfCar);
            Console.WriteLine("Price of car: {0}\n", PriceOfCar);
        }
        public void CarDetails(int y, double p, string t)
        {
            YearOfCar = y;
            TypeOfCar = t;
            PriceOfCar = p;
            Console.WriteLine("My car's details are:");
            Console.WriteLine("Type of car: {0}", TypeOfCar);
            Console.WriteLine("Year of car: {0}", YearOfCar);
            Console.WriteLine("Price of car: {0}\n", PriceOfCar);
        }
        private string _PalindromeWord;
        private int count = 0;
        private bool PalindromeFlag = true;
        public string IsAPalindrome
        {
            get
            {
                return _PalindromeWord;
            }
            set
            {
                while (PalindromeFlag && count < value.Length)
                {
                    if (value[count] == value[(value.Length - 1)-count])
                    {
                        count++;
                    }
                    else
                    {
                        PalindromeFlag = false;
                    }
                }
                if (PalindromeFlag)
                {
                    _PalindromeWord = "The word is a palindrome";
                }
                else
                {
                    _PalindromeWord = "The word is not a palindrome";
                }
            }
        }

        StringBuilder DiagonalNumber = new StringBuilder("14356",20);
        private string InsertedSpaces = "";
        public void PrintDiagonalNumber()
        {
            for(int i = 0; i < DiagonalNumber.Length; i++)
            {
                Console.WriteLine(InsertedSpaces + DiagonalNumber[i] + "\n");
                InsertedSpaces += " ";
            }
        }
    }
}
