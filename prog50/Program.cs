
int[,] MyArray = Myarray( 3 ,3);
Print2DArray(MyArray);
FindElement(MyArray);
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

void FindElement(int[,] array)
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