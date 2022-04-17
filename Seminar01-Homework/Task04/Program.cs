// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int n = 1;
if (n > 0)
{
	int number = 2;
	while (number < n)
	{
		Console.WriteLine(number);
		number += 2;
	}
}
