// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

double GetSum(int number)
{
	double sum = 0;
	while (number != 0)
	{
		sum += number % 10;
		number = number / 10;
	}
	return sum;
}

int a = GetValue("a");

double result = GetSum(a);
Console.WriteLine(result);