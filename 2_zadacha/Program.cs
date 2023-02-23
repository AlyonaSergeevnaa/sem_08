// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


int[,] result = new int[4, 4];
FillArrayRandom(result);
PrintArray(result);
Console.WriteLine();
StringMinSum(result);


void StringMinSum(int[,] array)
{
    int minStr = 0;
    int minSumStr = 0;
    int sumstr = 0;
    for (int i = 0; i < result.GetLength(1); i++)
    {
        minStr += result[0, i];
    }
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++) sumstr += result[i, j];
        if (sumstr < minStr)
        {
            minStr = sumstr;
            minSumStr = i;
        }
        sumstr = 0;
    }
    Console.Write($"{minSumStr + 1} строка");
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}