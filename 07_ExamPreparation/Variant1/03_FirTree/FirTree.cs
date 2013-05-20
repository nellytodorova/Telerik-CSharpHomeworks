using System;

class FirTree
{
	static void Main()
	{
		byte N = byte.Parse(Console.ReadLine());

		char asterisk = '*';
		char dot = '.';

		int rows = N - 1;
		int perRow = 2 * (N - 2) + 1;

		for (int i = 1; i <= rows; i++)
		{
			for (int j = 1; j <= perRow; j++)
			{
				if ((j <= (N - i - 1)) || (j > (N - 2 + i)))
				{
					Console.Write(dot);
				} 
				else {
					Console.Write(asterisk);
				}
			}

			Console.WriteLine();
		}

		// Print the stem
		for (int k = 1; k <= perRow; k++)
		{
			if (k == N - 1) {
				Console.Write(asterisk);
			}
			else
			{
				Console.Write(dot);
			}
		}

		Console.WriteLine();
	}
}