using System;

class OddNumber
{
    static void Main()
    {
		int N = int.Parse(Console.ReadLine());
		long oddNumber = 0;

		for (int i = 1; i <= N; i++)
		{
			long number = long.Parse(Console.ReadLine());
			oddNumber ^= number;
		}

		Console.WriteLine(oddNumber);
    }
}