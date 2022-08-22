//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
int N = 1;
bool not = true;
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Чётные числа от 1 до {number}:");
while (N <= number)
{
    if (N % 2 != 1)
    {
        Console.Write($"{N}, ");
        not = false;
    }
    N = N + 1;
}
if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}