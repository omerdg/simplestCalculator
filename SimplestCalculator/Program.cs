using System;

namespace SimplestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            double result;
            char symbol;
            bool play = true;

            Console.Clear();

            while (play == true)
            {          
                Console.WriteLine("********************************************************************");

                Console.WriteLine("Enter first number: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Enter your operation symbol (*, /, + or -)");
                symbol = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.WriteLine("Enter second number: ");
                secondNumber = Convert.ToDouble(Console.ReadLine());

                switch (symbol)
                {
                    case '*':
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"Result: {result}");
                        break;

                    case '/':
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"Result: {result}");
                        break;
                    case '+':
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"Result: {result}");
                        break;

                    case '-':
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"Result: {result}");
                        break;
                    default:
                        Console.WriteLine("You entered an invalid input");
                        break;    
                }

                Console.WriteLine(@"
Would you like to calculate again? 
Type ' y ' for yes, ' n ' for no.
                                ");
                string answer = Console.ReadLine().ToLower();
                play = (answer.Equals("y")) ? true : false;

  
            }
        }
    }
}