// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}
int n = GetValue("n"), m;

if (n > 0)
{
	m = -n;
}
else
{
	m = n;
	n = -n;
}

while (m <= n)
{
	Console.WriteLine(m);
	m++;
}
