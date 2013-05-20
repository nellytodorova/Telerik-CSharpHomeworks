using System;

class ExchangingBitsMore
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter p position: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter q position: ");
        int q = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the size of the groups: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Initial number is:");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        int newNumber = n;
        int bitP;
        int bitQ;

        for (int i = 0; i < k; i++)
        {
            bitP = (newNumber & (1 << p)) >> p; // Get the bit on position p
            bitQ = (newNumber & (1 << q)) >> q; // Get the bit on position q

			if (bitP != bitQ)
			{
				if (bitP == 1 && bitQ == 0)
				{
					newNumber = newNumber & (~(1 << p));
					newNumber = newNumber | (1 << q);
				}
				else
				{
					newNumber = newNumber & (~(1 << q));
					newNumber = newNumber | (1 << p);
				}
			}

			p++;
			q++;
        }

        Console.WriteLine("After exchange the number is:");
        Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}
