// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000 -> {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int findNumber = firstDigit * 10 + thirdDigit;

// Console.WriteLine(findNumber);

int finalNumber = TwoNumber(number);
Console.WriteLine(finalNumber);
int TwoNumber(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}