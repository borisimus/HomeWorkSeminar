﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
//-3 -> нет
// 7 -> нет
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N % 2 == 0) 
{
    Console.Write($"Число {N} чётное - ДА");
}
if (N % 2 != 0) 
{
    Console.Write($"Число {N} чётное - НЕТ");
}