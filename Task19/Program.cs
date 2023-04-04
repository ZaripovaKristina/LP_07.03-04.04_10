// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций
//  (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine("Число является палиндромом");
  }
  else Console.WriteLine("Число НЕ является полиндромом");
}

// if (number!.Length == 5)
// {
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Число не ПЯТИзначное");


// bool Palindrome(int num)
// {
//     if(num < 10) return false;

//     int initialNum = num;
//     int reversNum = 0;

//     while(num > 0)
//     {
//         reversNum = reversNum * 10 + num % 10;
//         num /= 10;
//     }
//     return initialNum == reversNum;
// }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number < 0) number = number * -1;