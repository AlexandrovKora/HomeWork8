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
/*
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

int[,] CreateMultiple(int[,] array1, int[,] array2)
{   
    
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {   
            int sum=0;
            for(int k = 0; k < array1.GetLength(1); k++)
            {
                sum = sum + array1[i,k]*array2[k,j];
            }
            array3[i,j] = sum;
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
if (rows!=columns2) Console.WriteLine("Матрицы нельзя перемножить");
else Show2dArray(myArray3);

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
*/
/*
void CreateRandom3dArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number =0; 
    for(int i = 0; i < temp.GetLength(0); i++)
    {   
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i>=1)
        {
            for(int j = 0; j < 1; j++)
            {

                while (temp[i]==temp[j])
                {
                    temp[i] = new Random().Next(10,100);
                    j=0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }

    int count = 0;
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            for (int k = 0; k<array.GetLength(2); k++)
            {
                array [i, j, k]=temp[count];
                count++;
            }
        }
    }
}

void Show3dArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}{j}{k}) ");
            }
            Console.WriteLine();
        }
    }
}


Console.Write("input size of the 1st dimension: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("input size of the 2nd dimension: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("input size of the 3rd dimension: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[x,y,z];

CreateRandom3dArray(array);
Show3dArray(array);

*/
/*Задача 62. Напишите программу, которая заполнит спирально массив 
4 на 4.
*/
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            {
                Console.Write($" {array[i, j]} ");
            }
            else 
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

void CreateHelicalArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp += 1;

        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j += 1;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i += 1;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j -= 1;
        else
            i -= 1;
    }
}

const int arraySize = 4;
int[,] squareMatrix = new int[arraySize, arraySize];

CreateHelicalArray(squareMatrix);
ShowArray(squareMatrix);