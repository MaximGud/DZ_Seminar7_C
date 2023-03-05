//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1(строчка) 7 (столбец) -> такого числа в массиве нет

int[,] CreateRandomMatrix(int rows, int cols)
{
  int[,] matrix = new int[rows, cols];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
  return matrix;
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

int[,] array = CreateRandomMatrix(5, 6);

void CheckMatrixData(int row, int col, int[,] matrix)
{
  if (row <= matrix.GetLength(0) && col <= matrix.GetLength(0) && row >= 0 && col >= 0)
  {
    Console.Write($"Значение массива по позиции {row} строка и {col} столбец равно - {matrix[row,col]}");
  }
  else 
  {
    Console.Write("Такого элемента нет в массиве");
  }
}

Console.Write("Введите позицию строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

PrintArray(array);
CheckMatrixData(n, m, array);