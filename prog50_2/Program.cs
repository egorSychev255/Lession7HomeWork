
Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] UserArray = Myarray(rows, columns);
Indixes(UserArray);
Print2DArray(UserArray);

int[,] Myarray(int height, int wight)
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