// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

int n = GetValue("n");

if (n > 0)
{
	int number = 2;
	while (number < n)
	{
		Console.WriteLine(number);
		number += 2;
	}
}
