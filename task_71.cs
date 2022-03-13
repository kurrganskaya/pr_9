// Задача 71: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m==0) return n+1;
    else if (m > 0 && n == 0) return Ackermann(m-1, n = 1);
    else if (m > 0 && n > 0) return Ackermann (m-1, Ackermann(m, n-1));
    else return 0;
}

Console.WriteLine(Ackermann(m, n));
