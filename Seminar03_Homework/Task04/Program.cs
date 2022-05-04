// 4. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int[] setArray(int number)
{
	int[] arr = new int[5];

	int i = 0;
	while (number != 0)
	{
		arr[i] = number % 10;
		number /= 10;
		i++;
	}
	return arr;
}

string isPalindrom(int[] arr)
{
	string text = "No";
	for (int i = 0; i < arr.Length - 1 - i; i++)
	{
		if (arr[i] != arr[arr.Length - 1 - i])
		{
			text = "No";
			break;
		}
		else text = "Yes";
	}
	return text;
}

int n = new Random().Next(10000, 100000);
// n = 27672;
// Console.WriteLine(n);

int[] array = setArray(n);

string palindrom = isPalindrom(array);
Console.WriteLine(palindrom);