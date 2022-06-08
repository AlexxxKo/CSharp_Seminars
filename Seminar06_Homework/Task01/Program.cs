// Составить частотный словарь элементов двумерного массива

double[,] statisticsArr = new double[1, 2];

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

double[,] GetArray(int row, int col)
{
	double[,] arr = new double[row, col];
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = new Random().Next(-20, 20);
			Console.Write($"{arr[i, j],6} ");
		}
		Console.WriteLine();
	}
	Console.WriteLine();
	return arr;
}

void GetArrayWithStatistic(double[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			CounterArray(arr[i, j]);
		}
	}
}

void CounterArray(double num)
{
	bool isNumber = true;
	int length = statisticsArr.GetLength(0);
	for (int i = 0; i < length; i++)
	{
		if (statisticsArr[i, 0] == num)
		{
			statisticsArr[i, 1] += 1;
			isNumber = false;
			break;
		}
	}
	if (isNumber)
	{
		statisticsArr = AddRowInArray(statisticsArr);
		statisticsArr[length, 0] = num;
		statisticsArr[length, 1] += 1;
	}
}

double[,] AddRowInArray(double[,] arr)
{
	int length = arr.GetLength(0);
	double[,] newArr = new double[length + 1, 2];
	for (int i = 0; i < length; i++)
	{
		for (int j = 0; j <= 1; j++)
		{
			newArr[i, j] = arr[i, j];
		}
	}
	return newArr;
}

void SortArray(double[,] arr)
{
	int start = arr[0, 1] == 0 ? 1 : 0;
	for (int i = start; i < arr.GetLength(0); i++)
	{
		double min1 = arr[i, 0], min2 = arr[i, 1];
		for (int j = i; j < arr.GetLength(0); j++)
		{
			if (arr[j, 0] < min1)
			{
				min1 = arr[j, 0];
				arr[j, 0] = arr[i, 0];
				arr[i, 0] = min1;

				min2 = arr[j, 1];
				arr[j, 1] = arr[i, 1];
				arr[i, 1] = min2;
			}
		}
	}
}

void PrintArray(double[,] arr, double length)
{
	int start = arr[0, 1] == 0 ? 1 : 0;
	for (int i = start; i < arr.GetLength(0); i++)
	{
		double percent = Math.Round(arr[i, 1] * 100 / length, 2);
		Console.WriteLine($"{arr[i, 0],4} встречается {arr[i, 1]} раз. Частота {percent}%");
	}
}


int row = GetValue("Количество строк двумерного массива");
int col = GetValue("Количество столбцов двумерного массива");
double[,] array = GetArray(row, col);
GetArrayWithStatistic(array);

SortArray(statisticsArr);

PrintArray(statisticsArr, array.Length);