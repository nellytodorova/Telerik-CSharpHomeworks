using System;

class Pillars
{
	static void Main()
	{
		int[,] matrix = new int[8, 8];

		for (int row = 0; row <= 7; row++)
		{
			int bits = int.Parse(Console.ReadLine());

			for (int col = 0; col <= 7; col++)
			{
				matrix[row, col] = (bits >> (7 - col)) & 1;
			}
		}

		//for (int row = 0; row <= 7; row++)
		//{
		//	for (int col = 0; col <= 7; col++)
		//	{
		//		Console.Write(matrix[row, col]);
		//	}

		//	Console.WriteLine();
		//}

		for (int i = 0; i <= 7; i++)
		{
			int leftCount = 0;
			int rightCount = 0;

			for (int row = 0; row <= 7; row++)
			{
				for (int col = 0; col <= 7; col++)
				{
					if (col < i) {
						leftCount += matrix[row, col];
					}
					else if (col > i) {
						rightCount += matrix[row, col];
					}
				}
			}

			if (leftCount == rightCount)
			{
				Console.WriteLine(7 - i);
				Console.WriteLine(leftCount);
				return;
			}
		}

		Console.WriteLine("No");
	}
}