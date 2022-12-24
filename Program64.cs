// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = InputInt("Введите положительное число N: ");
int m = 1;

Console.WriteLine(Number(n, m));

int Number(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Number(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}