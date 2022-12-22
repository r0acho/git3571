// Сформируйте трёхмерный массив размером 2х2х2 из неповторяющихся двузначных чисел. Напишите программу
//, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
int list1 = InputInt("Введите размерность массива по X: ");
int list2 = InputInt("Введите размерность массива по Y: ");
int list3 = InputInt("Введите размерность массива по Z: ");
int countNums = 44;

int[,,] resultNums = CreateMassive(list1, list2, list3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] CreateMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = num++;
    } 

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(10, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}