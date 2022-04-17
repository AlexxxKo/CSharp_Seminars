int n = 123;
if (n < 0) n = -n;
int lastDigit = n % 10;
Console.WriteLine(lastDigit);