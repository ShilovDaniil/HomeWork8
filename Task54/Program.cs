// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Num(string arg)
{
  System.Console.WriteLine($"Введите {arg}: ");
  return int.Parse(System.Console.ReadLine());
}

int n = Num("количество строк");
int m = Num("количество столбцов");
int[,] matrix = new int[n, m];

void FillArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(-100, 100);
    }
  }
}

void PrintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
  }
}

void NewArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
      for (int k = j + 1; k < matrix.GetLength(1); k++)
      {
        if (matrix[i, j] < matrix[i, k])
        {
          int temp = matrix[i, j];
          matrix[i, j] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
NewArray(matrix);