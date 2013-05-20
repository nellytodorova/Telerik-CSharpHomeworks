using System;

class LeastMajorityMultiple
{
	static void Main()
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int d = int.Parse(Console.ReadLine());
		int e = int.Parse(Console.ReadLine());

		for (int i = 1; i < int.MaxValue; i++)
		{
			int total = 0;

			if (i % a == 0) {
				total++;
			}

			if (i % b == 0)
			{
				total++;
			}

			if (i % c == 0)
			{
				total++;
			}

			if (i % d == 0)
			{
				total++;
			}

			if (i % e == 0)
			{
				total++;
			}

			if (total >= 3) {
				Console.WriteLine(i);
				break;
			}
		}
	}
}