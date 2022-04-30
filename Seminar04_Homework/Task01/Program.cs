// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

double GetExponentiation(int x, int y)
{
	int exp = 1;
	for (int i = 1; i <= y; i++)
	{
		exp *= x;
	}
	return exp;
}

int a = GetValue("A");
int b = GetValue("B");

double result = GetExponentiation(a, b);
Console.WriteLine(result);