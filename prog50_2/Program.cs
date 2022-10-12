/* Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
2 -> 7
9 -> 4
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
*/
Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] UserArray = GenerateArrayRandom(rows, columns);
Indixes(UserArray);
Print2DArray(UserArray);

int[,] GenerateArrayRandom(int height, int wight)
{
    int[,] TwoDArray = new int[height, wight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < wight; j++)
        {
            TwoDArray[i, j] = new Random().Next(0, 10);
        }
    }
    return TwoDArray;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] Indixes(int[,] array)
{
    Console.WriteLine("Введите позицию в массиве");
    int UserNumber = Convert.ToInt32(Console.ReadLine());
    if (UserNumber > array.Length)
    {

        Console.WriteLine("Такого элемента нет");
    }
    else
    {
         int count = 1;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
               
                if (count == UserNumber)
                {
                    Console.WriteLine($"Элемент находящийся на позиции {UserNumber} = {array[i, j]}");
                    
                }
                count++;
            }
        }
    }

    return array;
}