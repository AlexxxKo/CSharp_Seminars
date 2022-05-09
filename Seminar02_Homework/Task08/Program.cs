// 8. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int a = new Random().Next(1, 8);
Console.WriteLine(a);

if (a == 6 || a == 7) Console.WriteLine("Выходной");
else Console.WriteLine("На работу!!!");