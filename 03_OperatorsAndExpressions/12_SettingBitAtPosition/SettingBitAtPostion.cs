using System;

class SettingBitAtPostion
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the postion of bit to set: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the new value of the bit: ");
        int v = int.Parse(Console.ReadLine());

        int newNumber;

        if (v == 1)
        {
            int mask = 1 << p;
            newNumber = n | mask;
        }
        else
        {
            int mask = ~(1 << p);
            newNumber = n & mask;
        }

        Console.WriteLine("The new number is: " + newNumber);  
    }
}
