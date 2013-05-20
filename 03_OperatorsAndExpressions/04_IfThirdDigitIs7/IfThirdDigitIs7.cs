using System;

class IfThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int numberDivided = number / 100;
        int thirdDigit = numberDivided % 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine("The third digit is 7");
        }
        else
        {
            Console.WriteLine("The third digit is not 7");
        }
    }
}
