// Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number)
{
    if (number > n)
    {
        return;
    }
    PrintNumbers(number + 1);
    Console.Write($"{number} ");

}
int a = 1;
PrintNumbers(a);
