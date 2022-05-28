// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7


int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

int rowArray = GetValue("Количество строк двумерного массива");
int colArray = GetValue("Количество столбцов двумерного массива");
int[,] array = new int[rowArray, colArray];

int rowTop = 0,
		rowBottom = array.GetLength(0) - 1,
		colLeft = 0,
		colRight = array.GetLength(1) - 1,
		num = 1;

void SpiralArray(int[,] arr)
{
	if (colLeft > colRight) return;
	else
	{
		for (int i = colLeft; i <= colRight; i++)
		{
			arr[rowTop, i] = num;
			num++;
		}
		rowTop++;
	}

	if (rowTop > rowBottom) return;
	else
	{
		for (int j = rowTop; j <= rowBottom; j++)
		{
			arr[j, colRight] = num;
			num++;
		}
		colRight--;
	}

	if (colLeft > colRight) return;
	else
	{
		for (int i = colRight; i >= colLeft; i--)
		{
			arr[rowBottom, i] = num;
			num++;
		}
		rowBottom--;
	}
	if (rowTop > rowBottom) return;
	else
	{
		for (int j = rowBottom; j >= rowTop; j--)
		{
			arr[j, colLeft] = num;
			num++;
		}
		colLeft++;
	}
	SpiralArray(arr);
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

SpiralArray(array);
PrintArray(array);

// Чувствую, что для решения этой задачи рекурсию можно использовать более рационально, но не могу сообразить, как именно.