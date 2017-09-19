using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionConsole
{
    class Program
    {
        int _firstNumber = 0;
        int _secondNumber = 0;
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter first number");
            int firstNumber = program.CheckFirstNumber();
            Console.WriteLine("Enter second number");
            int secondNumber = program.CheckSecondNumber();
            
            Console.WriteLine("Sum is: " + (firstNumber + secondNumber));

        }

        private int CheckFirstNumber()
        {
            string firstNumberStr = Console.ReadLine();
            int firstNumber = 0;
            if (firstNumberStr == null || int.TryParse(firstNumberStr, out firstNumber) == false)
            {   
                Console.WriteLine("Enter first number again!");
                CheckFirstNumber();
            }

            return firstNumber;
        }

        private int CheckSecondNumber()
        {
            string secondNumberStr = Console.ReadLine();
            int secondNumber= 0;

            if (secondNumberStr == null || int.TryParse(secondNumberStr, out secondNumber) == false)
            {
                Console.WriteLine("Enter second number again!");
                CheckSecondNumber();
            }

            return secondNumber;
        }
    }
}
