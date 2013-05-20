using System;

class CompareFloatingPoint
{
    static void Main()
    {
        decimal firstNumber;
        decimal secondNumber;

        Console.Write("Write the first real number for comparison: ");
        firstNumber = decimal.Parse(Console.ReadLine());

        Console.Write("Write the second real number for comparison: ");
        secondNumber = decimal.Parse(Console.ReadLine());

        firstNumber = Math.Round(firstNumber, 6);
        secondNumber = Math.Round(secondNumber, 6);

        bool equal = (firstNumber == secondNumber);

        Console.WriteLine(equal);
    }
}
