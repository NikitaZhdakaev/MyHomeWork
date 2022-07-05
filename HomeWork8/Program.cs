/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по возрастанию 
элементы каждой строки двумерного массива.

int[,] Matrix(int m, int n)
{
 int[,] newMatrix = new int[m, n];
 for (int i = 0; i < m; i++)
 for (int j = 0; j < n; j++) newMatrix[i, j] = new Random().Next(1, 10);
 return newMatrix;
}
void ShowMatrix(int[,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
	{
 for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($"{matrix[i, j]} ");
 Console.WriteLine();
	}
}
int[,] SortMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
		for (int j = 0; j < matrix.GetLength(1); j++)
			for (int k = 0; k < matrix.GetLength(1) - 1; k++)
				if (matrix[i, k] > matrix[i, k + 1])
				{
					int temp = matrix[i, k];
					matrix[i, k] = matrix[i, k + 1];
					matrix[i, k + 1] = temp;
				}
	return matrix;
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
ShowMatrix(matrix);
matrix = SortMatrix(matrix);
Console.WriteLine();
ShowMatrix(matrix);
*/

/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Matrix(int m)
{
	int[,] newMatrix = new int[m, m];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < m; j++) newMatrix[i, j] = new Random().Next(1, 10);
	return newMatrix;
}
void ShowMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($"{matrix[i, j]} ");
		Console.WriteLine();
	}
}
int[] ArrayRowsMatrix(int[,] matrix)
{
	int[] array = new int[matrix.GetLength(0)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		int sum = 0;
		for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
		array[i] = sum;
	}
	return array;
}
int NumMinSumRowsMatrix(int[] array)
{
	int result = array[0];
	int str = 1;
	for (int i = 0; i < array.Length; i++)
		if (array[i] < result)
		{
			result = array[i];
			str = i + 1;
		}
	return str;
}
Console.Write("Введите количество строк и столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m);
ShowMatrix(matrix);
int[] array = ArrayRowsMatrix(matrix);
int num = NumMinSumRowsMatrix(array);
Console.WriteLine($"{num} строка");
*/

/* Задача 62. Заполните спирально массив 4 на 4.

int[,] RoundMatrix(int[,] newMatrix, int num, int i, int k, int step, int o)
{
	double temp1 = Convert.ToDouble(newMatrix.GetLength(0) + newMatrix.GetLength(1)) / 4;
	double temp2 = temp1 - Math.Truncate(temp1);
	for (int l = 0; l < o; l++)
	{
		for (int j = k; j < newMatrix.GetLength(1) - k; j++) newMatrix[i, j] = num++;
		num--;
		step++;
		for (int j = newMatrix.GetLength(1) - ++k; i < newMatrix.GetLength(0) - step; i++) newMatrix[i, j] = num++;
		num--;
		i--;
		for (int j = newMatrix.GetLength(1) - k; j >= k - 1; j--) newMatrix[i, j] = num++;
		num--;
		for (int j = step; i >= k; i--) newMatrix[i, j] = num++;
		i++;
	}
	if (temp2 == 0.75)
	{
		for (int j = k; j < newMatrix.GetLength(1) - k; j++) newMatrix[i, j] = num++;
		num--;
		step++;
		for (int j = newMatrix.GetLength(1) - ++k; i < newMatrix.GetLength(0) - step; i++) newMatrix[i, j] = num++;
		num--;
		i--;
	}
	if (newMatrix.GetLength(0) % 2 != 0 && newMatrix.GetLength(1) % 2 != 0) newMatrix[newMatrix.GetLength(0) / 2, newMatrix.GetLength(1) / 2] = num++;
	return newMatrix;
}
int[,] SpiralMatrix(int m, int n)
{
	int[,] newMatrix = new int[m, n];
	int num = 1, i = 0, k = 0, step = -1, o = (m + n) / 4;
	newMatrix = RoundMatrix(newMatrix, num, i, k, step, o);
	return newMatrix;
}
void ShowMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($"{matrix[i, j]} ");
		Console.WriteLine();
	}
}
int m = 0, n = 0;
do
{
	Console.WriteLine("Введите ширину и высоту матрицы, но ширина и высота не должны превышать друг друга больше чем на 1: ");
	Console.Write("Введите количество строк массива: ");
	m = Convert.ToInt32(Console.ReadLine());
	Console.Write("Введите количество столбцов массива: ");
	n = Convert.ToInt32(Console.ReadLine());
}
while (m != n && m + 1 != n && n + 1 != m);
int[,] matrix = SpiralMatrix(m, n);
ShowMatrix(matrix);
*/
