using System;

class SumOfSubsetIs0
{
	static void Main()
	{
		int a;
		int b;
		int c;
		int d;
		int e;
		bool flagSum = false;

		Console.Write("Please enter the first number: ");
		string firstStr = Console.ReadLine();

		Console.Write("Please enter the second number: ");
		string secondStr = Console.ReadLine();

		Console.Write("Please enter the third number: ");
		string thirdStr = Console.ReadLine();

		Console.Write("Please enter the fourth number: ");
		string fourthStr = Console.ReadLine();

		Console.Write("Please enter the fifth number: ");
		string fifthStr = Console.ReadLine();

		if (!int.TryParse(firstStr, out a))
		{
			Console.WriteLine("Invalid number: {0}", firstStr);
		}
		else if (!int.TryParse(secondStr, out b))
		{
			Console.WriteLine("Invalid number: {0}", secondStr);
		}
		else if (!int.TryParse(thirdStr, out c))
		{
			Console.WriteLine("Invalid number: {0}", thirdStr);
		}
		else if (!int.TryParse(fourthStr, out d))
		{
			Console.WriteLine("Invalid number: {0}", fourthStr);
		}
		else if (!int.TryParse(fifthStr, out e))
		{
			Console.WriteLine("Invalid number: {0}", fifthStr);
		}
		else
		{
			// Combination with 5 numbers
			if (a + b + c + d + e == 0)
			{
				flagSum = true;
			}

			// Start of combination with 4 numbers
			else if (a + b + c + d == 0)
			{
				flagSum = true;
			}
			else if (a + b + c + e == 0)
			{
				flagSum = true;
			}
			else if (a + c + d + e == 0)
			{
				flagSum = true;
			}
			else if (a + b + d + e == 0)
			{
				flagSum = true;
			}
			else if (b + c + d + e == 0)
			{
				flagSum = true;
			}

			// Start of combination with 3 numbers
			else if (a + b + c == 0)
			{
				flagSum = true;
			}
			else if (a + b + d == 0)
			{
				flagSum = true;
			}
			else if (a + b + e == 0)
			{
				flagSum = true;
			}
			else if (a + c + d == 0)
			{
				flagSum = true;
			}
			else if (a + c + e == 0)
			{
				flagSum = true;
			}
			else if (a + d + e == 0)
			{
				flagSum = true;
			}
			else if (b + c + d == 0)
			{
				flagSum = true;
			}
			else if (b + c + e == 0)
			{
				flagSum = true;
			}
			else if (b + d + e == 0)
			{
				flagSum = true;
			}
			else if (c + d + e == 0)
			{
				flagSum = true;
			}

			// Start of combination with 2 numbers
			else if (a + b == 0)
			{
				flagSum = true;
			}
			else if (a + c == 0)
			{
				flagSum = true;
			}
			else if (a + d == 0)
			{
				flagSum = true;
			}
			else if (a + e == 0)
			{
				flagSum = true;
			}
			else if (b + c == 0)
			{
				flagSum = true;
			}
			else if (b + d == 0)
			{
				flagSum = true;
			}
			else if (b + e == 0)
			{
				flagSum = true;
			}
			else if (c + d == 0)
			{
				flagSum = true;
			}
			else if (c + e == 0)
			{
				flagSum = true;
			}
			else if (d + e == 0)
			{
				flagSum = true;
			}

			Console.WriteLine("Do we have sum with 0? - {0}", flagSum);
		}
	}
}