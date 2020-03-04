using System;

namespace Ex2_devCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassEx2 ConstructorEx = new ClassEx2();
            ConstructorEx.Car();
            ClassEx2 Car1Details = new ClassEx2();
            ClassEx2 Car2Details = new ClassEx2();
            Car1Details.CarDetails("Pickup", 2015, 215000.90);
            Car2Details.CarDetails(2019, 198900.50, "Sedan");
            ClassEx2 NumbersInDiagonal = new ClassEx2();
            NumbersInDiagonal.PrintDiagonalNumber();
            ClassEx2 PalindromeWords = new ClassEx2();
            PalindromeWords.IsAPalindrome = "anitalavalatina";
            Console.WriteLine(PalindromeWords.IsAPalindrome);
        }
    }
}
