
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] arraymassiv = new int[2, 2, 2];
FillArray(arraymassiv);
PrintIndex(arraymassiv);


void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < arraymassiv.GetLength(0); i++)
    {
        for (int j = 0; j < arraymassiv.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int h = 0; h < arraymassiv.GetLength(2); h++)
            {
                Console.Write($"{arraymassiv[i, j, h]}({i},{j},{h}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int h = 0; h < arr.GetLength(2); h++)
            {
                arr[h, i, j] += count;
                count += 3;
            }
        }
    }
}