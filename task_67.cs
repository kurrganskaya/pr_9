// Задача 67: Показать натуральные числа от N до 1, N задано. N = 5. -> "5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Укажите границу диапазона выводимых чисел: ");
int n = int.Parse(Console.ReadLine());

int List(int n)
{
    if (n == 0) return 0;
    Console.Write(n + " ");
    return List(n-1);
}
List(n);
Console.WriteLine();
