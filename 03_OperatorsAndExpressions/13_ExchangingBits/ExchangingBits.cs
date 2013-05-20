using System;

class ExchangingBits
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int newNumber;

        Console.WriteLine("Initial number is:");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        int bit3 = (n & (1 << 3)) >> 3; // Get the bit of the 3-rd position
        int bit24 = (n & (1 << 24)) >> 24; // Get the bit of the 24-th position 

        int bit4 = (n & (1 << 4)) >> 4; // Get the bit of the 4-th position
        int bit25 = (n & (1 << 25)) >> 25; // Get the bit of the 25-th position

        int bit5 = (n & (1 << 5)) >> 5; // Get the bit of the 5-th position
        int bit26 = (n & (1 << 26)) >> 26; // Get the bit of the 26-th position

        if (bit3 == 1 && bit24 == 0)
        {
            newNumber = n & (~(1 << 3));
            newNumber = newNumber | (1 << 24);
        }
        else
        {
            newNumber = n & (~(1 << 24));
            newNumber = newNumber | (1 << 3);
        }

        if (bit4 == 1 && bit25 == 0)
        {
            newNumber = newNumber & (~(1 << 4));
            newNumber = newNumber | (1 << 25);
        }
        else
        {
            newNumber = newNumber & (~(1 << 25));
            newNumber = newNumber | (1 << 4);
        }

        if (bit5 == 1 && bit26 == 0)
        {
            newNumber = newNumber & (~(1 << 5));
            newNumber = newNumber | (1 << 26);
        }
        else
        {
            newNumber = newNumber & (~(1 << 26));
            newNumber = newNumber | (1 << 5);
        }

        Console.WriteLine("After exchange the number is:");
        Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}