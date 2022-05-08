// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

double[] SetArray(int n)
{
	double[] arr = new double[n];
	for (int index = 0; index < n; index++)
	{
		arr[index] = new Random().NextDouble();
		// Console.Write($"{arr[index]} ");
	}
	return arr;
}

double getDifference(double[] arr)
{
	int n = arr.Length;
	double max = arr[0], min = arr[0];
	foreach (double el in arr)
	{
		if (el > max) max = el;
		else if (el < min) min = el;
	}

	double differ = max - min;
	return differ;
}

Console.Clear();
int n = GetValue("Размерность массива");

double[] array = SetArray(n);

double difference = getDifference(array);

// Console.WriteLine();
Console.WriteLine(difference);