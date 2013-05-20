using System;

class WeAllLoveBits
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			int number = int.Parse(Console.ReadLine());
			int newNum = 0;

			while (number != 0)
			{
				newNum <<= 1;

				if ((number & 1) == 1) {
					newNum = newNum | 1;
				}

				number >>= 1;
			}

			Console.WriteLine(number ^ (~number) & newNum);

			//int result = 0;
			//while (number > 0)
			//{
			//	int lastBit = number & 1;
			//	result = result << 1;
			//	result = result | lastBit;
			//	number = number >> 1;
			//}
		}
	}
}