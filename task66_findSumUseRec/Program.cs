/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());


void FindSum (int m, int n, int sum)
{
    if (m - 1 >= n) 
    {
        Console.WriteLine(sum);
        return;
    }

    sum = sum + m;
    m ++;
    FindSum(m, n , sum);
}

FindSum(numberM, numberN, 0);

