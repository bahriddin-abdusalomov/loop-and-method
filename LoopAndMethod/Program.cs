using LoopAndMethod;
using LoopAndMethod.Service;

namespace Algorithm 
    { 
        public class Program
        {
            public static void Main(string[] args)
            {
                AlgoritmService algoritmService = new AlgoritmService();

                //masala1
                List<string> names = new List<string>
                {"Bahriddin", "Sanjarbek", "Jasurbek", "Davronbek", "Ijodbek", "Shohruh", "Arabboy"};

                algoritmService.FirstLetter(names);
                Console.WriteLine();

                //masala2
                long number = -12345;

                long result = algoritmService.InverseNumber(number);
                Console.WriteLine(result);
                Console.WriteLine();

                //masala3
                long number2 = 2345515432;
                bool isPalindrom = algoritmService.IsPalindrome(number2);
                string result2 = isPalindrom ? "Palindrom son" : "Palindrom son emas";
                Console.WriteLine(result2);
                Console.WriteLine();

                //masala4
                int number3 = int.Parse(Console.ReadLine());
                algoritmService.StarRhombus(number3);
                Console.WriteLine();



            }
        }
    }
