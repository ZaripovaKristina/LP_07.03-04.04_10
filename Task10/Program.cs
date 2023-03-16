//  Напишите программу, которая принимает 
//  на вход трёхзначное число и на выходе показывает 
//  вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int numberLast = number /10 % 10;
    Console.WriteLine(numberLast);
}
else
{
    Console.WriteLine("введите ТРЁХназное число");
}