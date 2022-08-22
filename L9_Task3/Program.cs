/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.Write(AkkermanRes(m,n));

int AkkermanRes(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if ((m > 0) && (n == 0))
    {
        return AkkermanRes(m - 1, 1);
    }
    if ((m > 0) && (n > 0))
    {
        return AkkermanRes(m - 1, AkkermanRes(m, n - 1));
    }
    return n + 1;
}
