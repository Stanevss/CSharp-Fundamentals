﻿using System;
using System.Data;

namespace TryAndCatchC
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
               
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't devide by zero!");
            }



            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            } 
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exeption, the number was too long or to short for  an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.Read();

        }
    }
}
