﻿// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception. 
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ExceptionRangeOfInteger
{
    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter number: ");
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (!(start < number && number < end))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        // exception if the input is not a number
        catch (FormatException)
        {
            Console.WriteLine("The number is not valid!");
            return 0;
        }
        // exception if the input is out of given limits
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is out of given limits!");
            return 0;
        }
        // exception if the input is null
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid input - no value!");
            return 0;
        }
        return number;
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }
    }
}
