// 6. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

int Cube(int number)
{
	return number * number * number;
}

int n = GetValue("N");

for (int i = 1; i <= n; i++)
{
	int s = Cube(i);
	Console.WriteLine(s);
}