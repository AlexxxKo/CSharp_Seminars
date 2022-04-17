int n = 4, m;

if (n > 0)
{
	m = -n;
}
else
{
	m = n;
	n = -n;
}

while (m <= n)
{
	Console.WriteLine(m);
	m++;
}
