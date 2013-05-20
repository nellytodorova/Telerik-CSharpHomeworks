using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct Car
{
	public int x;
	public int y;
	public char c;
	public ConsoleColor color;
}

class Program
{
	static void PrintOnPosition(int x, int y, char c,
		ConsoleColor color = ConsoleColor.Gray)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(c);
	}

	static void PrintStringOnPosition(int x, int y, string str,
		ConsoleColor color = ConsoleColor.Gray)
	{
		Console.SetCursorPosition(x, y);
		Console.ForegroundColor = color;
		Console.Write(str);
	}

	static void Main()
	{
		double speed = 100.0;
		double acceleration = 0.5;
		int playfieldWidth = 5;
		int livesCount = 5;
		Console.BufferHeight = Console.WindowHeight = 20;
		Console.BufferWidth = Console.WindowWidth = 30;
		Car userCar = new Car();
		userCar.x = 2;
		userCar.y = Console.WindowHeight - 1;
		userCar.c = '@';
		userCar.color = ConsoleColor.Yellow;
		Random randomGenerator = new Random();
		List<Car> objects = new List<Car>();
		while (true)
		{
			speed += acceleration;
			if (speed > 400)
			{
				speed = 400;
			}

			bool hitted = false;
			{
				int chance = randomGenerator.Next(0, 100);
				if (chance < 10)
				{
					Car newObject = new Car();
					newObject.color = ConsoleColor.Cyan;
					newObject.c = '-';
					newObject.x = randomGenerator.Next(0, playfieldWidth);
					newObject.y = 0;
					objects.Add(newObject);
				}
				else if (chance < 20)
				{
					Car newObject = new Car();
					newObject.color = ConsoleColor.Cyan;
					newObject.c = '*';
					newObject.x = randomGenerator.Next(0, playfieldWidth);
					newObject.y = 0;
					objects.Add(newObject);
				}
				else
				{
					Car newCar = new Car();
					newCar.color = ConsoleColor.Green;
					newCar.x = randomGenerator.Next(0, playfieldWidth);
					newCar.y = 0;
					newCar.c = '#';
					objects.Add(newCar);
				}
			}

			while (Console.KeyAvailable)
			{
				ConsoleKeyInfo pressedKey = Console.ReadKey(true);
				//while (Console.KeyAvailable) Console.ReadKey(true);
				if (pressedKey.Key == ConsoleKey.LeftArrow)
				{
					if (userCar.x - 1 >= 0)
					{
						userCar.x = userCar.x - 1;
					}
				}
				else if (pressedKey.Key == ConsoleKey.RightArrow)
				{
					if (userCar.x + 1 < playfieldWidth)
					{
						userCar.x = userCar.x + 1;
					}
				}
			}
			List<Car> newList = new List<Car>();
			for (int i = 0; i < objects.Count; i++)
			{
				Car oldCar = objects[i];
				Car newObject = new Car();
				newObject.x = oldCar.x;
				newObject.y = oldCar.y + 1;
				newObject.c = oldCar.c;
				newObject.color = oldCar.color;
				if (newObject.c == '*' && newObject.y == userCar.y && newObject.x == userCar.x)
				{
					speed -= 20;
				}
				if (newObject.c == '-' && newObject.y == userCar.y && newObject.x == userCar.x)
				{
					livesCount++;
				}
				if (newObject.c == '#' && newObject.y == userCar.y && newObject.x == userCar.x)
				{
					livesCount--;
					hitted = true;
					speed += 50;
					if (speed > 400)
					{
						speed = 400;
					}
					if (livesCount <= 0)
					{
						PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
						PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
						Console.ReadLine();
						Environment.Exit(0);
					}
				}
				if (newObject.y < Console.WindowHeight)
				{
					newList.Add(newObject);
				}
			}
			objects = newList;
			Console.Clear();
			if (hitted)
			{
				objects.Clear();
				PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
			}
			else
			{
				PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
			}
			foreach (Car car in objects)
			{
				PrintOnPosition(car.x, car.y, car.c, car.color);
			}

			// Draw info
			PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
			PrintStringOnPosition(8, 5, "Speed: " + speed, ConsoleColor.White);
			PrintStringOnPosition(8, 6, "Acceleration: " + acceleration, ConsoleColor.White);
			//Console.Beep();
			Thread.Sleep((int)(600 - speed));
		}
	}
}
