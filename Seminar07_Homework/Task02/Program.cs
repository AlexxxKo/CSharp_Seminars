// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// Уточнение: если наименьших элементов несколько, удаляем первый встретившийся.

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

int[,] FindMinInArray(int[,] arr)
{
	int[,] minArr = new int[1, 2];
	int min = arr[0, 0];
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			if (arr[i, j] < min)
			{
				min = arr[i, j];
				minArr[0, 0] = i;
				minArr[0, 1] = j;
			}
		}
	}
	Console.WriteLine($"{min} - наименьший элемент. Удаляем {minArr[0, 0] + 1} строку и {minArr[0, 1] + 1} столбец");
	return minArr;
}

int[,] RemoveLinesArray(int[,] arr, int[,] removedIndexes)
{
	int[,] skipArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
	int k = 0, l = 0;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		if (i == removedIndexes[0, 0]) continue;
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			if (j == removedIndexes[0, 1]) continue;
			skipArr[k, l] = arr[i, j];
			l++;
		}
		k++;
		l = 0;
	}
	return skipArr;
}

Console.Clear();
int rowArray = GetValue("Количество строк двумерного массива");
int colArray = GetValue("Количество столбцов двумерного массива");
Console.WriteLine();

int[,] array = FillArray(rowArray, colArray);
PrintArray(array);
Console.WriteLine();

int[,] arrayIndex = FindMinInArray(array);
Console.WriteLine();

array = RemoveLinesArray(array, arrayIndex);
PrintArray(array);