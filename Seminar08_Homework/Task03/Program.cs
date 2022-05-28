// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Повтор Task02 из Seminar06_Homework + добавлен вывод о невозможности произведения

int GetValue(string text)
{
	Console.Write($"{text}: ");
	string getValueStr = Console.ReadLine()!;
	int value = Convert.ToInt32(getValueStr);
	return value;
}

double[,] SetMatrix(int row, int col)
{
	double[,] matrix = new double[row, col];

	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
		{
			matrix[i, j] = new Random().Next(-10, 11);
		}
	}
	return matrix;
}

double[,] SetMulipticationMatrix(double[,] matr1, double[,] matr2)
{
	double[,] matrMuliptication = new double[matr1.GetLength(0), matr2.GetLength(1)];

	for (int i = 0; i < matr1.GetLength(0); i++)
	{
		for (int j = 0; j < matr2.GetLength(1); j++)
		{
			for (int k = 0; k < matr1.GetLength(1); k++)
			{
				matrMuliptication[i, j] += matr1[i, k] * matr2[k, j];
			}
		}
	}
	return matrMuliptication;
}

string PrintArray(double[,] matr)
{
	string arr = String.Empty;
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			arr += ($"{matr[i, j],7}");
		}
		arr += Environment.NewLine;
	}
	return arr;
}


Console.Clear();
int row1 = GetValue("Количество строк первой матрицы");
int col1row2 = GetValue("Количество столбцов первой матрицы");
int row2 = GetValue("Количество строк второй матрицы");
if (row2 != col1row2) Console.WriteLine("Произведение матриц невозможно");
else
{
	int col2 = GetValue("Количество столбцов второй матрицы");

	double[,] matrix1 = SetMatrix(row1, col1row2);
	double[,] matrix2 = SetMatrix(col1row2, col2);

	double[,] matrix3 = SetMulipticationMatrix(matrix1, matrix2);

	Console.WriteLine(PrintArray(matrix1));
	Console.WriteLine();
	Console.WriteLine(PrintArray(matrix2));
	Console.WriteLine();
	Console.WriteLine(PrintArray(matrix3));
}