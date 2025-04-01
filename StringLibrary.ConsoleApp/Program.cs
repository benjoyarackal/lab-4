using System;
using StringLibrary;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine($"Starts with uppercase? {input.StartsWithUpper()}");
    }
}
