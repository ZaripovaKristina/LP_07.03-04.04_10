// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] array = new int[8]; //0, 1, 2, 3, 4, 5, 6, 7
// array [0] = 34;

// for (int i = 0; i < array.Length; i++)
// {
//     //array [i] = 
// Console.Write(array[i] + )
// }
// int [] arr = {1, 2, 3};


// int number = new Random().Next(0,1);
// int [] array = new int [8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = number;
// }
// for (int j = i +1; j < array.Length; j++)
// {
//     array[j] = num;
// }


int[] array = new int[8];
FillArray(array);
PrintArray(array);
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

    {
        Console.Write(array[i] + " ");
    }

}


