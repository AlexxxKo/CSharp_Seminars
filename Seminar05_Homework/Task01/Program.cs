// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
		arr[index] = new Random().Next(100, 1000);
		// Console.Write($"{arr[index]} ");
	}
	return arr;
}

int GetEvenNumberCount(int[] arr)
{
	int n = arr.Length, count = 0;
	for (int index = 0; index < n; index++)
	{
		if (arr[index] % 2 == 0) count++;
	}
	return count;
}

Console.Clear();
int n = GetValue("Размерность массива");

int[] array = SetArray(n);

int count = GetEvenNumberCount(array);

// Console.WriteLine();
Console.WriteLine(count);