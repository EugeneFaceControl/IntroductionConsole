using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionConsole
{
    class Program
    {
        private int _firstNumber = 0;
        private int _secondNumber = 0;

//        public int FirstNumber { get; set; }
//        public int SecondNumber { get; set; }

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter first number");
            program.CheckFirstNumber();
            Console.WriteLine("Enter second number");
            program.CheckSecondNumber();

            Console.WriteLine("Sum is: " + (program._firstNumber + program._secondNumber));

        }

        private void CheckFirstNumber()
        {
            string firstNumberStr = Console.ReadLine();
            //            int firstNumber = 0;
            
            if (firstNumberStr == null || int.TryParse(firstNumberStr, out _firstNumber) == false)
            {
                Console.WriteLine("Enter first number again!");
                CheckFirstNumber();
            }
        }

        private void CheckSecondNumber()
        {
            string secondNumberStr = Console.ReadLine();
//            int secondNumber= 0;

            if (secondNumberStr == null || int.TryParse(secondNumberStr, out _secondNumber) == false)
            {
                Console.WriteLine("Enter second number again!");
                CheckSecondNumber();
            }
        }
    }
}
