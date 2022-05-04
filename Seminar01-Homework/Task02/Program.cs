// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	double value = Convert.ToDouble(getValueStr);
	return value;
}

Console.Clear();
double a = GetValue("a");
double b = GetValue("b");
double c = GetValue("c");

double max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);