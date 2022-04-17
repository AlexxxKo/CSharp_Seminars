int a = 42;
int b = 3;
int c = 7;

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);