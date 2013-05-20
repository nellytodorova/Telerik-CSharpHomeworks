using System;

class Lines
{
	static void Main()
	{
		int[,] m = new int[8, 8];

		for (int row = 0; row <= 7; row++)
		{
			int bits = int.Parse(Console.ReadLine());

			for (int col = 0; col <= 7; col++)
			{
				if ((bits & (1 << col)) != 0)
				{
					m[row, col] = 1;
				}
			}
		}

		int maxLength = 0,
			count = 0;

		for (int row = 0; row <= 7; row++)
		{
			for (int col = 0; col <= 7; col++)
			{
				int length = 0;

				while (col <= 7 && m[row, col] == 1)
				{
					col++;
					length++;
				}

				if (length == maxLength)
				{
					count++;
				}

				if (length > maxLength)
				{
					maxLength = length;
					count = 1;
				}
			}
		}

		for (int col = 0; col <= 7; col++)
		{

			for (int row = 0; row <= 7; row++)
			{

				int length = 0;

				while (row <= 7 && m[row, col] == 1)
				{
					row++;
					length++;
				}

				if (length == maxLength)
				{
					count++;
				}

				if (length > maxLength)
				{
					maxLength = length;
					count = 1;
				}
			}
		}

		if (maxLength == 1)
		{
			count = count / 2;
		}

		Console.WriteLine(maxLength);
		Console.WriteLine(count);
	}
}