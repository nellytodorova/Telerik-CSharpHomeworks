using System;

class ExtractBitFromNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int i = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of the postion: ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int numberAndMask = i & mask;
        int bit = numberAndMask >> b;

        Console.WriteLine(bit);
    }
}