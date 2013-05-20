using System;

class ShipDamage
{
	static void Main()
	{
		int sx1 = int.Parse(Console.ReadLine());
		int sy1 = int.Parse(Console.ReadLine());
		int sx2 = int.Parse(Console.ReadLine());
		int sy2 = int.Parse(Console.ReadLine());
		int h = int.Parse(Console.ReadLine());
		int cx1 = int.Parse(Console.ReadLine());
		int cy1 = int.Parse(Console.ReadLine());
		int cx2 = int.Parse(Console.ReadLine());
		int cy2 = int.Parse(Console.ReadLine());
		int cx3 = int.Parse(Console.ReadLine());
		int cy3 = int.Parse(Console.ReadLine());

		int c1HitY = 2 * h - cy1;
		int c2HitY = 2 * h - cy2;
		int c3HitY = 2 * h - cy3;

		int sLeft = Math.Min(sx1, sx2);
		int sRigth = Math.Max(sx1, sx2);
		int sUpper = Math.Max(sy1, sy2);
		int sBottom = Math.Min(sy1, sy2);

		int totalDamage = 0;

		// 25% hit
		if ((cx1 == sLeft || cx1 == sRigth) && (c1HitY == sUpper || c1HitY == sBottom))
		{
			totalDamage += 25;
		}
		if ((cx2 == sLeft || cx2 == sRigth) && (c2HitY == sUpper || c2HitY == sBottom))
		{
			totalDamage += 25;
		}
		if ((cx3 == sLeft || cx3 == sRigth) && (c3HitY == sUpper || c3HitY == sBottom))
		{
			totalDamage += 25;
		}

		// 50% hit
		if ((cx1 == sLeft || cx1 == sRigth) && (c1HitY < sUpper && c1HitY > sBottom)
			|| (cy1 == sUpper || cy1 == sBottom) && (cx1 < sRigth && cx1 > sLeft))
		{
			totalDamage += 50;
		}
		if ((cx2 == sLeft || cx2 == sRigth) && (c2HitY < sUpper && c2HitY > sBottom)
			|| (cy2 == sUpper || cy2 == sBottom) && (cx2 < sRigth && cx2 > sLeft))
		{
			totalDamage += 50;
		}
		if ((cx3 == sLeft || cx3 == sRigth) && (c3HitY < sUpper && c3HitY > sBottom)
			|| (cy3 == sUpper || cy3 == sBottom) && (cx3 < sRigth && cx3 > sLeft))
		{
			totalDamage += 50;
		}

		// 100% hit
		if ((cx1 > sLeft) && (cx1 < sRigth) && (c1HitY < sUpper) && (c1HitY > sBottom))
		{
			totalDamage += 100;
		}
		if ((cx2 > sLeft) && (cx2 < sRigth) && (c2HitY < sUpper) && (c2HitY > sBottom))
		{
			totalDamage += 100;
		}
		if ((cx3 > sLeft) && (cx3 < sRigth) && (c3HitY < sUpper) && (c3HitY > sBottom))
		{
			totalDamage += 100;
		}

		Console.WriteLine(totalDamage + "%");
	}
}