// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с
//  наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и в
// ыдаёт номер строки с наименьшей суммой элементов: 1 строка

// int minSumLine = 0;
// // int sumLine = SumLineElements(array2d, 0);

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();





int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

    int minSum = 0;
    int sumLine = SumLineElements(array2d,0);
    for (int i = 1; i < array2d.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array2d, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSum = i;
        }
    }


    
int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}
{
Console.WriteLine($"Cтрокa с наименьшей суммой элементов ({minSum+1}) ");
}