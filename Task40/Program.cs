﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.




// Console.Write("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadKey());

// Console.Write("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadKey());

// Console.Write("Введите третье число");
// int num3 = Convert.ToInt32(Console.ReadKey());



// bool triangle = IsExistTriangle(num1, num2, num3);
// Console.WriteLine(triangle);


// bool IsExistTriangle(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) return true;
//     else return false;
// }

bool IsExistTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool triangle = IsExistTriangle(num1, num2, num3);
Console.WriteLine(triangle ? "Да" : "Нет");