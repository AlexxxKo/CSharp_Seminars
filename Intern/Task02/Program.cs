// 2. По двум заданным числам проверять является ли первое квадратом второго

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

if (a == b * b) Console.WriteLine("Yes");
else Console.WriteLine("No");