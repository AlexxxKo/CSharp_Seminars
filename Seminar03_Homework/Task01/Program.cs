// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
double GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	double value = Convert.ToDouble(getValueStr);
	return value;
}

int GetQuadrants(double coordX, double coordY)
{
	if (coordX == 0 || coordY == 0)
	{
		return 0;
	}
	else
	{
		if (coordX > 0)
		{
			if (coordY > 0) return 1;
			else return 4;
		}
		else
		{
			if (coordY > 0) return 2;
			else return 3;
		}
	}
}

double x = GetValue("x");
double y = GetValue("y");

int result = GetQuadrants(x, y);
if (result != 0) Console.WriteLine(result);