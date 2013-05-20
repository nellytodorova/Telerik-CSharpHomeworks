using System;

class BinaryDigitsCount
{
	static void Main()
	{
		byte b = byte.Parse(Console.ReadLine());
		int n = int.Parse(Console.ReadLine());

		int count = 0;

		for (int i = 1; i <= n; i++)
		{
			count = 0;
			uint num = uint.Parse(Console.ReadLine());

			string numStr = Convert.ToString(num, 2);

			for (int j = 0; j < numStr.Length; j++)
			{
				if ((numStr[j] - '0') == b)
				{
					count++;
				}
			}

			Console.WriteLine(count);
		}
	}
}