// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

int[,] FillArray(int row, int col)
{
	int[,] arr = new int[row, col];
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
		{
			arr[i, j] = new Random().Next(-999, 1000);
		}
	}
	return arr;
}

int SetMinSumRow(int[,] arr)
{
	double minSum = 0;
	int index = 0;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		double sum = 0;
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			sum += arr[i, j];
		}
		// Console.WriteLine($"{i + 1,3} {sum}");
		if (i == 0)
		{
			minSum = sum;
			index = 0;
		}
		else
		{
			if (sum < minSum)
			{
				minSum = sum;
				index = i;
			}
		}
	}
	return index + 1;
}

Console.Clear();
int rowArray = GetValue("Количество строк двумерного массива");
int colArray = GetValue("Количество столбцов двумерного массива");

int[,] array = FillArray(rowArray, colArray);
Console.WriteLine(SetMinSumRow(array));
