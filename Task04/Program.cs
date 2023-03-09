// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 1-ое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ое число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(numberA > max)
{
    max = numberA;
}
if(numberB > max)
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}
Console.WriteLine("max = " + max);
