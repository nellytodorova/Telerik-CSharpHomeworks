using System;

class AstrologicalDigits
{
	static void Main()
	{
		string n = Console.ReadLine();
		int sumDigits = 0;

		do
		{
			sumDigits = 0;
			for (int i = 0; i < n.Length; i++)
			{
				if (n[i] != '.' && n[i] != '-')
				{
					sumDigits += (n[i] - '0');
				}
			}

			n = sumDigits.ToString();
		} while (sumDigits > 9);

		Console.WriteLine(sumDigits);
	}
}