using System;

class GreaterNumber
{
	static void Main()
	{
		int a;
		int b;

		Console.Write("Please enter the first number: ");
		string firstStr = Console.ReadLine();

		Console.Write("Please enter the second number: ");
		string secondStr = Console.ReadLine();

		if (!int.TryParse(firstStr, out a))
		{
			Console.WriteLine("Invalid number: {0}", firstStr);
		}
		else if (!int.TryParse(secondStr, out b))
		{
			Console.WriteLine("Invalid number: {0}", secondStr);
		}
		else
		{
			//Console.WriteLine("Greater: {0}", Math.Max(a, b));
			//Console.WriteLine("Smaller: {0}", Math.Min(a, b));

			//int max = a - ((a - b) & ((a - b) >> 31));
			//Console.WriteLine(max);

			Console.WriteLine("The greater number: {0}", (a + b + Math.Abs(a - b)) / 2);
			Console.WriteLine("The smaller number: {0}", (a + b - Math.Abs(a - b)) / 2);
		}	
	}
}