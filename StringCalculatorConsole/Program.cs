using StringCalculatorLibrary;
using System;
using System.Text.RegularExpressions;


namespace StringCalculatorConsoleApp
{
    class Program
    {
 

        static void Main(string[] args)
        {
         
            string input = args[0];


            IStringCalculator stringCalculator = new StringCalculator();
            IReadFile readFile = new ReadFileWrapper();

            Console.WriteLine("(1) The result of Add method call (//[***]\n1***2***3) using input argument");
            Console.WriteLine("Result is {0} ", stringCalculator.Add(input));
            Console.WriteLine("");

            Console.WriteLine("(2) The result of Add method call (1,2)");
            Console.WriteLine("Result is {0} ", stringCalculator.Add(readFile.ReadLine("StringData01.txt")));
            Console.WriteLine("");


            //Given example test 1\n2,3
            Console.WriteLine("");
            Console.WriteLine("(3)  The result of Add method call with example data (1\n2,3)");
            Console.WriteLine("Result is {0} ", stringCalculator.Add(readFile.ReadLine("StringData02.txt")));
            Console.WriteLine("");


            // Numbers bigger than 1000 should be ignored, so adding 2 + 1001  = 2
            Console.WriteLine("");
            Console.WriteLine("(4) The result of Add method call (Numbers bigger than 1000 should be ignored - 2 + 1001)");
            Console.WriteLine("Result is {0} ", stringCalculator.Add(readFile.ReadLine("StringData03.txt")));
            Console.WriteLine("");


            //For example: "//[***]\n1***2***3" should return 6.
            Console.WriteLine("");
            Console.WriteLine("(5) The result of Add method call (//[***]\n1***2***3)");
            Console.WriteLine("Result is {0} ", stringCalculator.Add(readFile.ReadLine("StringData04.txt")));
            Console.WriteLine("");


            //For example: "//[*][%]\n1*2%3" should return 6.
            Console.WriteLine("");
            Console.WriteLine("(6) The result of Add method call (//[*][%]\n1*2%3)");
            Console.WriteLine("Result is {0} ", stringCalculator.Add(readFile.ReadLine("StringData05.txt")));
            Console.WriteLine("");

            // Support different delimiters //;\n1;2 should retur 3
            Console.WriteLine("");
            Console.WriteLine("(7) The result of Add method call (//;\n1;2)");
            Console.WriteLine("Result is {0} ", stringCalculator.Add(readFile.ReadLine("StringData06.txt")));
            Console.WriteLine("");

            // Allow the Add method to handle unknown amount of numbers 1\n2,3,5,6,7,9,12,15 will return 60
            Console.WriteLine("");
            Console.WriteLine("(8) The result of Add method call (1\n2,3,5,6,7,9,12,15)");
            Console.WriteLine("Result is {0} ", stringCalculator.Add(readFile.ReadLine("StringData07.txt")));
            Console.WriteLine("");



            Console.ReadKey();
        }

 
    }
}
