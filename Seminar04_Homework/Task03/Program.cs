// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Console.Clear();

for (int index = 0; index < array.Length; index++)
{
	array[index] = new Random().Next();
	Console.WriteLine(array[index]);
	Console.WriteLine();
}