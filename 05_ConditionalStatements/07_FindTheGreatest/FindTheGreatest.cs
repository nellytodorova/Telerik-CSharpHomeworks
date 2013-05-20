using System;

class FindTheGreatest
{
	static void Main()
	{
		int[] numbers = new int[5];

		for (int i = 0; i < numbers.Length; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}

		int bigger = numbers[0];

		for (int j = 1; j < numbers.Length; j++)
		{
			if (numbers[j] > bigger)
			{
				bigger = numbers[j];
			}
		}

		/* Easier solution:
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int d = int.Parse(Console.ReadLine());
		int e = int.Parse(Console.ReadLine());

		int big = a;

		if (big < b) {
			big = b;
		}

		if (big < c) {
			big = c;
		}

		if (big < d)
		{
			big = d;
		}

		if (big < e)
		{
			big = e;
		}
		*/

		Console.WriteLine("The greates number is {0}", bigger);
	}
}
