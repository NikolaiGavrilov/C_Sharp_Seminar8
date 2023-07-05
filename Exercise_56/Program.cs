// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Create2dArray()
{
    Console.WriteLine("Set the count of rows in your array");
    int arrayRows = Convert.ToInt32(Console.ReadLine());
    while (arrayRows <= 0)
    {
        Console.WriteLine("Impossible value. Try again!");
        arrayRows = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Set the count of rows in your array");
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

int SummOfElemsInRow(int[,] arrayToSumm, int i)
{
    int sumInRow = arrayToSumm[i, 0];
    for (int j = 1; j < arrayToSumm.GetLength(1); j++)
    {
        sumInRow = sumInRow + arrayToSumm[i, j];
    }
    return sumInRow;
}

void MinimumSummRow(int[,] arrayToAnalyse)
{
    int minSumRow = 0;
    int sumRow = SummOfElemsInRow(arrayToAnalyse, 0);
    for (int i = 1; i < arrayToAnalyse.GetLength(0); i++)
    {
        int temporarySumm = SummOfElemsInRow(arrayToAnalyse, i);
        if (sumRow > temporarySumm)
        {
            sumRow = temporarySumm;
            minSumRow = i;
        }
    }
    Console.WriteLine($"Row №{minSumRow+1} has the minimum summ in the array.");
    Console.WriteLine($"Its summ is {sumRow}"); 
    // Для удобства пользователя, не знакомого с программированием, отсчет строк идёт не от 0, а от 1.
}


int[,] userArray = Create2dArray();
Console.WriteLine("Your array is:");
Print2dArray(userArray);
MinimumSummRow(userArray);
