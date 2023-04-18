// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Вводим число:");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

NaturalNumsRange(n, m);

void NaturalNumsRange(int num1, int num2)
{
  if (num1 < num2) 
  {
    Console.Write($"{num1} ");
    NaturalNumsRange(num1 + 1, num2);
  }
  else if (num1 > num2)
  {
    Console.Write($"{num1} ");
    NaturalNumsRange(num1-1, num2);
  }
  else 
  {
    Console.Write(num1);
  }
}