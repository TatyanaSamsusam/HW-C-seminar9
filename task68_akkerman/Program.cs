/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */



Console.WriteLine("введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N: ");
int n = int.Parse(Console.ReadLine());

int Akkerman(int m, int n)
{

    if (m == 0 && n >= 0)
    {
        return (n + 1);
    }
    else if (m > 0 && n == 0)
    {
        return Akkerm(m - 1, 1);
    }

    else if (m > 0 && n > 0)
    {
        return Akkerm(m - 1, Akkerm(m, n - 1));

    }
}

int rez = Akkerman(m, n);
Console.WriteLine(rez);

