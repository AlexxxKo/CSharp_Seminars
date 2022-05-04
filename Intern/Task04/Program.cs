// 4. По заданному номеру дня недели вывести его название

Console.Clear();
int a = new Random().Next(1, 8);
// Console.WriteLine(a);

if (a == 1) Console.WriteLine("Monday");
else if (a == 2) Console.WriteLine("Tuesday");
else if (a == 3) Console.WriteLine("Wednesday");
else if (a == 4) Console.WriteLine("Thursday");
else if (a == 5) Console.WriteLine("Friday");
else if (a == 6) Console.WriteLine("Saturday");
else Console.WriteLine("Sunday");