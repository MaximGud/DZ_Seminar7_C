// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandomMatrix(int rows, int cols)
{
  int[,] matrix = new int[rows, cols];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  }
  return matrix;
}

int[,] array = CreateRandomMatrix(3, 3);

double[] ColsAverage(int[,] arr)
{
  int size = arr.GetLength(1);
  double[] averageNums = new double[size];
  double sum = 0;
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      sum = sum + arr[i,j];
    } 
    averageNums[j] = Math.Round((sum/(arr.GetLength(0))), 2);
    sum = 0;
  }
  return averageNums;
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

PrintArray(array);
Console.Write($"Среднее арифметическое каждого столбца равно: {String.Join("; ", ColsAverage(array))}");