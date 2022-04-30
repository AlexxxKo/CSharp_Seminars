// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

double GetLength(double a1, double a2, double b1, double b2)
{
	double length = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));
	return length;
}

double x1 = GetValue("x1");
double y1 = GetValue("y1");
double x2 = GetValue("x2");
double y2 = GetValue("y2");

double s = GetLength(x1, x2, y1, y2);

Console.WriteLine(s);