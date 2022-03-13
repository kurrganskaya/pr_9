// Задача 69: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму элементов в промежутке от M до N.

Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

int Summ(int m, int n)
{
    if (n == m) return m;
    else if (n > m) 
    {
        return Summ(m + 1, n) + m;
    }
    else
    { 
        return Summ(m - 1, n) + m;
    }  
}

Console.WriteLine(Summ(m, n));
