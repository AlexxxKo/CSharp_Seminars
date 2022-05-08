// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

int[] SetArray(int n)
{
	int[] arr = new int[n];
	for (int index = 0; index < n; index++)
	{
		arr[index] = new Random().Next();
		// Console.Write($"{arr[index]} ");
	}
	return arr;
}

double GetSumOddNumber(int[] arr)
{
	int n = arr.Length;
	double sum = 0;
	for (int index = 1; index < n; index += 2)
	{
		sum += arr[index];
	}
	return sum;
}

Console.Clear();
int n = GetValue("Размерность массива");

int[] array = SetArray(n);

double sum = GetSumOddNumber(array);

// Console.WriteLine();
Console.WriteLine(sum);