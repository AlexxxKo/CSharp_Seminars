// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

double a = new Random().NextDouble();
double b = new Random().NextDouble();
if (a > b) Console.WriteLine($"max = {a}, min = {b}");
else Console.WriteLine($"max = {b}, min = {a}");