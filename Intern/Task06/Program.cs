// 6. Написать программу вычисления значения функции y = f(a). f(a) = (1 + 1 / a) ^ a

double GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	double value = Convert.ToDouble(getValueStr);
	return value;
}

double a = GetValue("a");

double y = Math.Pow(1 + 1 / a, a);

Console.WriteLine($"(1 + 1 / {a}) ^ {a} = {y}");