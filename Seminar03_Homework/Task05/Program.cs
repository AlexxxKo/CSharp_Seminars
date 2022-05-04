// 5.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	double value = Convert.ToDouble(getValueStr);
	return value;
}

double GetLength(double a1, double a2, double b1, double b2, double c1, double c2)
{
	double length = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1) + (c2 - c1) * (c2 - c1));
	return length;
}

double x1 = GetValue("x1");
double y1 = GetValue("y1");
double z1 = GetValue("z1");
double x2 = GetValue("x2");
double y2 = GetValue("y2");
double z2 = GetValue("z2");

double s = GetLength(x1, x2, y1, y2, z1, z2);

Console.WriteLine(s);