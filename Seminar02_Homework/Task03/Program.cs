// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int a = new Random().Next(0, 1000000);
int b = new Random().Next(0, 1000000);
// b = 21;
// a = 3;

Console.WriteLine(a);
Console.WriteLine(b);

if (b < a)
{
	Console.WriteLine($"{b} < {a}");
}
else
{
	if (b % a == 0)
	{
		Console.WriteLine($"{b} / {a} = {b / a}");
	}
	else
	{
		Console.WriteLine(b % a);
	}
}