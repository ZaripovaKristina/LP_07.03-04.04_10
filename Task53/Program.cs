// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.



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

void ChangeMatrixLines (int[,] matrix)
{int firstRom = 0;
int lastRom = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
{
    {
        int temp = matrix[firstRom, j];
        matrix[firstRom, j] = matrix[lastRom, j];
        matrix[lastRom, j] = temp;
    }
}
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

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();
ChangeMatrixLines(array2d);
PrintMatrix(array2d);


