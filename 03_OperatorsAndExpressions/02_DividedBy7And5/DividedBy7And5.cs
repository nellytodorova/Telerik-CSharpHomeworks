using System;

class DividedBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool result = (number % 7 == 0 && number % 5 == 0);
        Console.WriteLine(result);
    }
}