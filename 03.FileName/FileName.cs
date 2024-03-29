﻿// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents 
// and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible 
// exceptions and print user-friendly error messages.

using System;
using System.IO;

class FileName
{
    static void ReadFile(string fileName)
    {
        Console.WriteLine("=======File Content=======");
        string content = File.ReadAllText(fileName);
        Console.WriteLine(content);
        Console.WriteLine("==========================");
    }
    static void Main()
    {
        Console.Write("Enter the file (with full path) you want to read: ");
        string fileName = Console.ReadLine();
        //string fileName = "C:\\temp\\test.txt";
        try
        {
            ReadFile(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error!\n{0}: {1}", e.GetType().Name, e.Message);
        }        
    }
}
