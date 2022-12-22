//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[lines, columns];
ArrayRandomNumbers(matr);
Console.WriteLine();
Console.WriteLine("Массив Random");
PrintArray(matr);

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < matr.GetLength(1) - 1; z++)
        {
            if (matr[i, z] < matr[i, z + 1]) 
            {
                int temp = 0;
                temp = matr[i, z];
                matr[i, z] = matr[i, z + 1];
                matr[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив по убыванию строк");
PrintArray(matr);

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}