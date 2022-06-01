using System;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        { Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please enter your first number:"); string firstNumber = Console.ReadLine(); Console.WriteLine("Please enter your second number:"); string secondNumber = Console.ReadLine(); Console.WriteLine("Please enter your operator:"); string operatorInput = Console.ReadLine(); double firstNumberDouble = double.Parse(firstNumber); double secondNumberDouble = double.Parse(secondNumber);
            double result = 0; switch (operatorInput) { case "+": result = firstNumberDouble + secondNumberDouble; break; case "-": result = firstNumberDouble - secondNumberDouble; break; case "*": result = firstNumberDouble * secondNumberDouble; break; case "/": result = firstNumberDouble / secondNumberDouble; break; default: Console.WriteLine("Invalid operator"); break; } Console.WriteLine($"The result is {result}"); Console.ReadLine();
        }
    }
}