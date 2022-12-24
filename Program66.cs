// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int m = InputInt("Введите положительное число M: ");
int n = InputInt("Введите положительное число N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");

int Sum(int m, int n)
{
    if (m == n) return n;
    
    return n + Sum(m, n - 1);
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

