﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int num = int.Parse(Console.ReadLine());
if (num / 10000 == num % 10)
{
    if (num / 1000 % 10 == num / 10 % 10)
    {
        Console.WriteLine($"{num} -> Да");
    }
    else
    {
        Console.WriteLine($"{num} -> Нет:(");
    }
}
else
{
    Console.WriteLine($"{num} -> нет");
}
