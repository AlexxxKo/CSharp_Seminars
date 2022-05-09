// 7. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a = new Random().Next(0, 1000000);
// a = 78;
// Console.WriteLine(a);

if (a < 100)
{
	Console.WriteLine("Третьей цифры нет");
}
else
{
	while (a > 1000)
	{
		a /= 10;
	};
	Console.WriteLine(a % 10);
}