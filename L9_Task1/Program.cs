/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

Console.WriteLine("Введите число М (от): ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N (до): ");
int n = int.Parse(Console.ReadLine());

NaturalBack(m, n);

void NaturalBack(int start, int end)
{
    if (start > end)
    {
        return;
    }
    if (start == 0)
    {
        start++;
    }
    Console.Write(start + ", ");
    start++;
    NaturalBack(start, end);
}

