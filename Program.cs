/*
Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

void SortingToMin(int[,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
    {   
        for (int j = 0; j<array.GetLength(1)-1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++) 
            {   
                if (array[i, k] < array[i, k + 1]) 
                { 
                    int temp = array[i, k]; 
                    array[i, k] = array[i, k + 1]; 
                    array[i, k + 1] = temp; 
                }    
            }
        }
    }
}
Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);
SortingToMin(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}
void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}
void SortingToMin(int[,] array)
{   
    int index = 0;
    int minSum = 0;
    for(int i = 0; i<array.GetLength(0);i++)
    {   int result=0;
        for (int j = 0; j<array.GetLength(1); j++)
        {
            result = result + array[i,j];  
        }
        if(i==0) 
        {
            minSum=result;
        }
        else if (result<minSum)
        {
        minSum=result;
        index = i;
        } 
    }
    Console.WriteLine($"Строка {index+1}");
}
Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);
SortingToMin(myArray);
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
*/

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j]+ " ");

        Console.WriteLine();
    }
}

int[,] CreateMultiple(int[,]array1, int[,]array2)
{   
    if (array1.GetLength(0)!=array2.GetLength(1)) 
    {
        Console.WriteLine("Матрицы нельзя перемножить");
    }
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for(int k = 0; k < array2.GetLength(0); k++)
            {
                array3[i,j] = array1[i,k]*array2[k,j];
            }
        }
    }
    return array3;
}   

Console.Write("input a number of the 1st array rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of the 1st array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value of the 1st array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value of the 1st array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of the 2nd array rows: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of the 2nd array columns: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value of the 2nd array: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value of the 2nd array: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
int [,] myArray2 = CreateRandom2dArray(rows2, columns2, minValue2, maxValue2);
Show2dArray(myArray);
Console.WriteLine();
Show2dArray(myArray2);
Console.WriteLine();
int [,] myArray3 = CreateMultiple (myArray, myArray2);
Show2dArray(myArray3);