// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2dArray()
{
    Console.WriteLine("Set the count of rows in your array");
    int arrayRows = Convert.ToInt32(Console.ReadLine());
    while (arrayRows <= 0)
    {
        Console.WriteLine("Impossible value. Try again!");
        arrayRows = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Set the count of columns in your array");
    int arrayColumns = Convert.ToInt32(Console.ReadLine());
    while (arrayColumns <= 0)
    {
        Console.WriteLine("Impossible value. Try again!");
        arrayColumns = Convert.ToInt32(Console.ReadLine());
    }

    int[,] created2dArray = new int[arrayRows, arrayColumns];

    for (int i = 0; i < arrayRows; i++)
        for (int j = 0; j < arrayColumns; j++)
            created2dArray[i, j] = new Random().Next(0, 9 + 1);

    return created2dArray;
}

void Print2dArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Sorted2dArray(int[,] arrayToSort)
{
    int max = 0;
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
        for (int j = 0; j < arrayToSort.GetLength(1); j++)
        {
            for (int newColumn = 0; newColumn < arrayToSort.GetLength(1)-1; newColumn++)
            {
                if (arrayToSort[i, newColumn] < arrayToSort[i, newColumn+1])
                {
                    max = arrayToSort[i, newColumn+1];
                    arrayToSort[i, newColumn+1] = arrayToSort[i, newColumn];
                    arrayToSort[i, newColumn] = max;
                }
            }
            
        }
    return arrayToSort;
}

int[,] userArray = Create2dArray();
Console.WriteLine("Initial array:");
Print2dArray(userArray);
int[,] sortedArray = Sorted2dArray(userArray);
Console.WriteLine("Array with sorted (max->min) elements in each row:");
Print2dArray(sortedArray);