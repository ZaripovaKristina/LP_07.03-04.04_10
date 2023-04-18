// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// Console.WriteLine($"Введите целое положительное число M");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите целое положительное число N");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2) 
// {
//  Console.WriteLine($"числа равны: {num1}");
//  return;
// }

// if (num1 > num2) 
// {
//  int temp = num1;
//  num1 = num2;
//  num2 = temp;
// }

// NaturalNumbers(num1 ,num2);

// void NaturalNumbers(int number1, int number2)
// {
//     if (number1 == number2)
//     {
//         Console.WriteLine($"числа равны: {number1}");
//         return;
//     }
//     else
//     {
//         if (number1 > number2) return;
//         Console.Write($"{number1}");
//         if (number1 > number2) return;
//         NaturalNumbers(number1 - 1, number2);
//     }
//     if (number1 < number2)
//     {
//         if (number1 < number2) return;
//         NaturalNumbers(number1, number2 - 1);
//         Console.Write($"{number2} ");
//     }

    
// }



Console.Clear();
Console.WriteLine("Вводим первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим последнее число:");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumsRange(m, n);

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