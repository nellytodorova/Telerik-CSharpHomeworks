using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class FallingRocks
{
	static int playerPadSize = 3;
	static int playfieldWidth = 40;
	static int livesCount = 10;
	static int pointsCount = 0;
	static string[] rocksSymbols = { "^^", "@@", "*", "+++", "&", ";", "%", "$$", "#", "!", ".." };
	static int indexRocksSymbols;

	struct Object
	{
		public int x;
		public int y;
		public string c;
		public ConsoleColor color;
	}

	static void RemoveScrollBars()
	{
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.BufferHeight = Console.WindowHeight = 20;
		Console.BufferWidth = Console.WindowWidth = 60;
	}

	static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(c);
	}

	static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(str);
	}

	static void Main()
	{
		RemoveScrollBars();

		Object dwarf = new Object();
		dwarf.x = playfieldWidth / 2 - playerPadSize / 2;
		dwarf.y = Console.WindowHeight - 1;
		dwarf.c = "(0)";
		dwarf.color = ConsoleColor.Yellow;

		Random randomGenerator = new Random();
		List<Object> rocks = new List<Object>();

		// Get a string array with the names of ConsoleColor enumeration members.
		string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));

		while (true)
		{
			bool hitted = false;
			indexRocksSymbols = randomGenerator.Next(0, rocksSymbols.Length);
			ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[randomGenerator.Next(0, colorNames.Length)]);

			Object newRock = new Object();
			newRock.color = color;
			newRock.c = rocksSymbols[indexRocksSymbols];
			newRock.x = randomGenerator.Next(0, playfieldWidth);
			newRock.y = 0;
			rocks.Add(newRock);
			
			if (Console.KeyAvailable)
			{
				ConsoleKeyInfo pressedKey = Console.ReadKey(true);
				while (Console.KeyAvailable) Console.ReadKey(true);

				if (pressedKey.Key == ConsoleKey.LeftArrow)
				{
					if (dwarf.x - 1 >= 0)
					{
						dwarf.x = dwarf.x - 1;
					}
				}
				else if (pressedKey.Key == ConsoleKey.RightArrow)
				{
					if (dwarf.x + 1 < playfieldWidth)
					{
						dwarf.x = dwarf.x + 1;
					}
				}
			}

			for (int i = 0; i < rocks.Count; i++)
			{
				Object oldObject = rocks[i];
				Object newObject = new Object();
				newObject.x = oldObject.x;
				newObject.y = oldObject.y + 1;
				newObject.c = oldObject.c;
				newObject.color = oldObject.color;
				rocks.Remove(oldObject);

				if (newObject.y == Console.WindowHeight)
				{
					pointsCount++;
				}

				if ((newObject.y == dwarf.y && newObject.x == dwarf.x)
					|| (newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
					|| (newObject.y == dwarf.y && newObject.x == dwarf.x + 2))
				{
					livesCount--;
					hitted = true;

					if (livesCount <= 0)
					{
						PrintStringOnPosition(15, 7, "GAME OVER", ConsoleColor.Red);
						PrintStringOnPosition(15, 9, "Press Enter to continue", ConsoleColor.Red);
						Console.ReadLine();
						Environment.Exit(0);
					}
				}

				if (newObject.y < Console.WindowHeight)
				{
					rocks.Add(newObject);
				}
			}

			Console.Clear();

			// Print the dwarf
			if (hitted)
			{
				rocks.Clear();
				PrintStringOnPosition(dwarf.x, dwarf.y, "XXX", ConsoleColor.Red);
			}
			else
			{
				PrintStringOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
			}

			// Print the rocks
			foreach (Object rock in rocks)
			{
				PrintStringOnPosition(rock.x, rock.y, rock.c, rock.color);
			}

			PrintStringOnPosition(41, 5, "Lives: " + livesCount, ConsoleColor.White);
			PrintStringOnPosition(41, 7, "Score: " + pointsCount, ConsoleColor.White);

			Thread.Sleep(300);
		}
	}
}