using System;

class PrintThreeNumbers
{
	static void Main()
	{
		int a;
		int b;
		int c;

		Console.Write("Please enter the first number: ");
		string firstStr = Console.ReadLine();

		Console.Write("Please enter the second number: ");
		string secondStr = Console.ReadLine();

		Console.Write("Please enter the third number: ");
		string thirdStr = Console.ReadLine();

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
		else
		{
			Console.WriteLine("The sum is: {0}", a + b + c);
		}
	}
}