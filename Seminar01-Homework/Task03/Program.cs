// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

int a = GetValue("a");

if (a % 2 == 0)
{
	Console.WriteLine("Чётное");
}
else
{
	Console.WriteLine("Нечётное");
}