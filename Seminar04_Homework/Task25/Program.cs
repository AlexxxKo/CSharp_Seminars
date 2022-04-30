// 25. Найти сумму чисел от 1 до А

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

double GetSum(int a)
{
	double sum = a * (a + 1) / 2;
	return sum;
}

int a = GetValue("a");

if (a > 0)
{
	GetSum(a);
}