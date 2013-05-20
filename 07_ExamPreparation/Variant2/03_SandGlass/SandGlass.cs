using System;

class SandGlass
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		for (int row = 0; row < n / 2 + 1; row++)
		{
			int dot = row;
			int asterisk = n - 2 * dot;
			Console.Write(new String('.', dot));
			Console.Write(new String('*', asterisk));
			Console.Write(new String('.', dot));
			Console.WriteLine();
		}

		for (int rowSecond = n / 2 - 1; rowSecond >= 0; rowSecond--)
		{
			int dot = rowSecond;
			int asterisk = n - 2 * dot;
			Console.Write(new String('.', dot));
			Console.Write(new String('*', asterisk));
			Console.Write(new String('.', dot));
			Console.WriteLine();
		}
	}
}