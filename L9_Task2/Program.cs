/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */ 

Console.WriteLine("Введите число М (от): ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N (до): ");
int n = int.Parse(Console.ReadLine());
int res = 0;

Console.Write(NaturalSum(m, n, res));

int NaturalSum(int start, int end, int res)
{
    if (start > end)
    {
        return res;
    }
    res += start++;
    return (NaturalSum(start, end, res));
}


