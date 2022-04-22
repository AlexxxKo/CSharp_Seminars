// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int a = new Random().Next(0, 1000000);
// a = 161;

// Console.WriteLine(a);

if ((a % 7 == 0) && (a % 23 == 0))
{
	Console.WriteLine("Yes");
}
else
{
	Console.WriteLine("No");
}