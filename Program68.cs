// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 3, n = 2 -> A(n,m) = 9

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Функция равна = {Ackerman(n, m)}");
Console.WriteLine();

static int Ackerman(int n, int m)
{
    if (n == 0) return m + 1;
      
    if (n != 0 && m == 0) return Ackerman(n - 1, 1);

    if (n > 0 && m > 0) return Ackerman(n - 1, Ackerman(n, m - 1));

    return Ackerman(n,m);    
}
int InputInt(string output)
{
Console.WriteLine();
return Convert.ToInt32(Console.ReadLine());
}
