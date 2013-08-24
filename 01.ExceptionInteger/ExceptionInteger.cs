// Write a program that reads an integer number and calculates and prints its square root. If the number is invalid 
// or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;

class ExceptionInteger
{
    static void Main()
    {
        Console.Write("Enter number: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArithmeticException();
            }
            Console.WriteLine(Math.Sqrt(number));
        }
        // exception if the input is not a number
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        // exception if the input is out of integer 
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        // exception if the input is null
        catch (ArgumentNullException) 
        {
            Console.WriteLine("Invalid number!");
        }
        // exception if the input is negative number
        catch (ArithmeticException) 
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }            
    }
}
