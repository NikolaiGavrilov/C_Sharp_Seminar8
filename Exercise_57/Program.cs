// -Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

int [] MinAndMaxVal ()
{
    Console.WriteLine("Set the min value:");
    int arrayMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Set the max value:");
    int arrayMax = Convert.ToInt32(Console.ReadLine());
    int [] minMaxValues = new int [2];
    minMaxValues[0] = arrayMin;
    minMaxValues[1] = arrayMax;
    return minMaxValues;
}

int[,] Create2dArray(int [] minAndMaxVals)
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
            created2dArray[i, j] = new Random().Next(minAndMaxVals[0], minAndMaxVals[1] + 1);

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

void FindAndCountElem (int [,] arrayToFindElem, int [] minMaxAgainPlease)
{
    int count = 0;
    for (int value = minMaxAgainPlease[0]; value < minMaxAgainPlease[1]+1; value++)
    {
        count = 0;
        for (int i = 0; i < arrayToFindElem.GetLength(0); i++)
        {
            for (int j = 0; j < arrayToFindElem.GetLength(1); j++)
            {
                if (value == arrayToFindElem[i,j]) count++;  
            }
        }
        if (count > 0) Console.WriteLine($"Value '{value}' occurs {count} times in your array");
    }
    Console.WriteLine();
}

int [] userMinMax = MinAndMaxVal ();
int[,] userArray = Create2dArray(userMinMax);
Console.WriteLine("Your array is:");
Print2dArray(userArray);
FindAndCountElem(userArray, userMinMax);




