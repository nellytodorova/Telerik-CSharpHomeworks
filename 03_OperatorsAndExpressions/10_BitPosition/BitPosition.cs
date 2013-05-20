using System;

class BitPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of the postion: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int numberAndMask = v & mask;
        int bit = numberAndMask >> p;

        bool result = Convert.ToBoolean(bit);
        Console.WriteLine(result);
    }
}