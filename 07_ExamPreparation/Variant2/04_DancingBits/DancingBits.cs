using System;

class DancingBits
{
	static void Main()
	{
		int k = int.Parse(Console.ReadLine());
		int n = int.Parse(Console.ReadLine());
		string allBits = null;

		int lastBit = -1;
		int length = 0;
		int kCount = 0;

		for (int i = 0; i < n; i++)
		{
			int num = int.Parse(Console.ReadLine());
			allBits += Convert.ToString(num, 2);
		}

		for (int j = 0; j < allBits.Length; j++)
		{
			if (allBits[j] == lastBit)
			{
				length++;
			}
			else
			{
				if (length == k)
				{
					kCount++;
				}

				length = 1;
			}

			lastBit = allBits[j];

		}

		if (length == k) {
			kCount++;
		}

		Console.WriteLine(kCount);
	}
}