// 1. Напишите метод, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int a = new Random().Next(10, 100);
// Console.WriteLine(a);

int FindMax(int value)
{
	int b = value % 10;
	int c = value / 10;

	if (b > c)
	{
		return b;
	}
	else
	{
		return c;
	}
}
int max = FindMax(a);
Console.WriteLine(max);
