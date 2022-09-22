// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (M < N)
{
    void Sum(int number)
    {
        if (number < M)
        {
            return;
        }
        sum = sum + number;
        Sum(number - 1);
    }
    Sum(N);
    Console.Write($"Сумма равна {sum}");

}

if (M > N)
{
    void Sum(int number)
    {
        if (number < N)
        {
            return;
        }
        sum = sum + number;
        Sum(number - 1);
    }
    Sum(M);
    Console.Write($"Сумма равна {sum}");
}
