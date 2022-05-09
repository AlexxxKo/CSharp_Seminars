// 13. Удалить вторую цифру трёхзначного числа

Console.Clear();

int a = new Random().Next(100, 1000);
// Console.WriteLine(a);

a = a / 100 * 10 + a % 10;

Console.WriteLine(a);