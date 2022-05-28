// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Повтор Task03 из Seminar07_Homework. Изменено место вывода индексов

int[] ArrayUniqueNumbers()
{
	int[] arr = new int[90];
	for (int i = 0; i < 90; i++)
	{
		arr[i] = i + 10;
		// Console.Write($"{arr[i]} ");    // Вывод упорядоченного массива
	}
	// Console.WriteLine();    // Массивы на разных строках
	for (int i = 0; i < arr.Length; i++)
	{
		int j = new Random().Next(i, arr.Length);
		int temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
		// Console.Write($"{arr[i]} ");    // Вывод неупорядоченного массива
	}
	return arr;
}

int[,,] SetArrayThree(int[] arr)
{
	int[,,] arrayThree = new int[3, 5, 6];
	int index = 0;
	for (int i = 0; i < arrayThree.GetLength(0); i++)
	{
		for (int j = 0; j < arrayThree.GetLength(1); j++)
		{
			for (int k = 0; k < arrayThree.GetLength(2); k++)
			{
				arrayThree[i, j, k] = arr[index];
				index++;
			}
		}
	}
	return arrayThree;
}

void PrintArrayThree(int[,,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				Console.Write($"{arr[i, j, k],3} [{i}, {j}, {k}]  ");
			}
			Console.WriteLine();
		}
	}
}

Console.Clear();
int[] array = ArrayUniqueNumbers();
Console.WriteLine();
int[,,] arrayThree = SetArrayThree(array);
PrintArrayThree(arrayThree);