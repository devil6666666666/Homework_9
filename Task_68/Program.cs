﻿// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    if (m == 0 && n > 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
return AkkermanFunction(m, n);
}
Console.WriteLine($"Функция Аккермана для чисел {m}, {n} = {AkkermanFunction(m, n)}");