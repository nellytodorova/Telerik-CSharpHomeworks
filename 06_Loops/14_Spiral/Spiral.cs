using System;

/*
 * 14. * Write a program that reads a positive integer number N (N < 20) from 
 * console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
 */
class Spiral
{
	static void Main()
	{
		int n;

		Console.Write("N = ");
		string strN = Console.ReadLine();

		if (!int.TryParse(strN, out n))
		{
			Console.WriteLine("Invalid number: {0}", strN);
		}
		else
		{
			if (n < 20)
			{
				int totalElements = n * n;
				int[,] matrix = new int[n, n];
				int[,] newMatrix = new int[n, n];

				string direction = "right";

				int startRow = 0;
				int endRow = n;
				int startCol = 0;
				int endCol = n;

				int currentRow = 0;
				int currentCol = 0;

				for (int i = 1; i <= totalElements; i++)
				{
					switch (direction)
					{
						case "right":
							newMatrix[currentRow, currentCol] = i;
							currentCol++;

							if (currentCol == endCol)
							{
								direction = "down";
								currentCol--;
								startRow++;
								currentRow = startRow;
							}

							break;

						case "down":
							newMatrix[currentRow, currentCol] = i;
							currentRow++;

							if (currentRow == endRow)
							{
								direction = "left";
								currentRow--;
								endCol--;
								currentCol = endCol - 1;
							}

							break;

						case "left":
							newMatrix[currentRow, currentCol] = i;
							currentCol--;

							if (currentCol < startCol)
							{
								direction = "up";
								currentCol++;
								endRow--;
								currentRow = endRow - 1;
							}

							break;

						case "up":
							newMatrix[currentRow, currentCol] = i;
							currentRow--;

							if (currentRow < startRow)
							{
								direction = "right";
								currentRow++;
								startCol++;
								currentCol = startCol;
							}

							break;

						default:
							break;
					}
				}

				// Print the new generated spiral matrix
				for (int row = 0; row < newMatrix.GetLength(0); row++)
				{
					for (int col = 0; col < newMatrix.GetLength(1); col++)
					{
						Console.Write(Convert.ToString(newMatrix[row, col]).PadLeft(3, ' '), newMatrix[row, col]);	
					}

					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("The entered number must be less than 20!");
			}
		}
	}
}