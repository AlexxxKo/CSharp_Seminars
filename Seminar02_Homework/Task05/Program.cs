// 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

int a = new Random().Next(0, 10000);
int b = new Random().Next(0, 10000);
// a = 25;
// b = 5;

Console.WriteLine(a);
Console.WriteLine(b);

if (a * a == b || b * b == a)
{
	Console.WriteLine("Yes");
}
else
{
	Console.WriteLine("No");
}