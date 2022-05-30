// Заполните спирально массив 4 на 4

// Task01 из Seminar07_Homework - общий случай. Здесь - частный 4 на 4

int[,] array = new int[4, 4];

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

Console.Clear();
SpiralArray(array);
PrintArray(array);