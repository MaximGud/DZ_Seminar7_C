// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateRandomMatrix(int rows, int cols)
{
  double[,] matrix = new double[rows, cols];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    { 
      double number = Math.Round((new Random().NextDouble()*new Random().Next(-10, 11)), 2);
      matrix[i,j] = number;
    }
  }
  return matrix;
}

void PrintArray(double[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i,j]+ "\t");
    }
    Console.WriteLine();
  }
}

double[,] array = CreateRandomMatrix(3,4);
PrintArray(array);