// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в
//  промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Вводим число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим число N:");
int n = Convert.ToInt32(Console.ReadLine());


int SumDigits(int m, int n)
 {
     if (m == n) return n;
     else return n  + SumDigits(m, n - 1);
 }

 Console.WriteLine(SumDigits(m, n)); // 3628800
