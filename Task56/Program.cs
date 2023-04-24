// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка


int n = 5;
int m = 5;
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

void MinRow(int[,] matrix)
{
  int minSum = int.MaxValue;
  int minIndex = -1;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
     sum += matrix[i, j];
    }
    if (sum < minSum)
    {
     minSum = sum;
     minIndex = i;
    }
  }
  Console.WriteLine("Строка с наименьшей суммой элементов: " + minIndex);
}
FillArray(matrix);
PrintArray(matrix);
MinRow(matrix);
