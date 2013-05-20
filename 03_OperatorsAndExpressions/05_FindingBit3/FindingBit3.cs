using System;

class FindingBit3
{
    static void Main()
    {
        int p = 3;

        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;

        bool result = Convert.ToBoolean(bit);
        Console.WriteLine(result);
    }
}
