/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] MyArray = Myarray( 3 ,3);
Print2DArray(MyArray);
FindSrArfm(MyArray);
int[,]  Myarray(int height, int wight)
{
    int[,] TwoDArray = new int [height,wight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < wight; j++)
        {
            TwoDArray[i,j] = new Random().Next(0,10);   
        }
    }
    return TwoDArray;
}

void FindSrArfm(int[,] array)
{       
  for (int i=0;i < array.GetLength(0);i++) 
    {   
        int srarfm = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
        srarfm += array[j,i];
        }  
         Console.WriteLine($"Среднеарефметическое элементов столбца {i+1} = {(float)srarfm/3}");
    }

}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +"\t");
        }
        Console.WriteLine();
    }
}