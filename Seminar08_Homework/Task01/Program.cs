// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortArrayRows(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			int maxIndex = j;
			for (int k = j; k < arr.GetLength(1); k++)
			{
				if (arr[i, k] > arr[i, maxIndex]) maxIndex = k;
			}
			if (maxIndex != j)
			{
				int temp = arr[i, j];
				arr[i, j] = arr[i, maxIndex];
				arr[i, maxIndex] = temp;
			}
		}
	}
}

void PrintArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j],5}");
		}
		Console.WriteLine();
	}
}

Console.Clear();
int rowArray = GetValue("Количество строк двумерного массива");
int colArray = GetValue("Количество столбцов двумерного массива");

int[,] array = FillArray(rowArray, colArray);

// PrintArray(array);
// Console.WriteLine();
SortArrayRows(array);
PrintArray(array);