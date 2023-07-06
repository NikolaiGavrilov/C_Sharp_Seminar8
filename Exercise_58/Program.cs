// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int ArrayLengthInput ()
{
    Console.WriteLine("Set the length of your arrays");
    int lengthSetByUser = Convert.ToInt32(Console.ReadLine());
    while (lengthSetByUser <= 0)
    {
        Console.WriteLine("Try againg with length > 0! Input a new number for length:");
        lengthSetByUser = Convert.ToInt32(Console.ReadLine());
    }
    return lengthSetByUser;
}

int[,] Create2dArray(int arrayLength)
{
    int[,] created2dArray = new int[arrayLength, arrayLength];

    for (int i = 0; i < arrayLength; i++)
        for (int j = 0; j < arrayLength; j++)
            created2dArray[i, j] = new Random().Next(0, 9 + 1);

    return created2dArray;
}

void PrintTwoArrays(int[,] arrayToPrint1, int [,] arrayToPrint2)
{
    Console.WriteLine("Your first matrix:");
    for (int i = 0; i < arrayToPrint1.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint1.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine("Your second matrix:");
    for (int i = 0; i < arrayToPrint2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint2.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] MultiplyTwoArrays(int[,] firstArr, int[,] secondArr)
{
  int [,] result = new int[firstArr.GetLength(0), firstArr.GetLength(0)];
  for (int i = 0; i < firstArr.GetLength(0); i++)
  {
    for (int j = 0; j < firstArr.GetLength(1); j++)
    {
      int temp = 0;
      for (int k = 0; k < firstArr.GetLength(1); k++)
      {
        temp = temp + firstArr[i,k] * secondArr[k,j];
      }
      result[i,j] = temp;
    }
  }
  return result;
}

void PrintSingleArray(int[,] singleArrToPrint1)
{
    Console.WriteLine("Your matrix after multiplication:");
    for (int i = 0; i < singleArrToPrint1.GetLength(0); i++)
    {
        for (int j = 0; j < singleArrToPrint1.GetLength(1); j++)
        {
            Console.Write($"{singleArrToPrint1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int userLen = ArrayLengthInput();
int [,] arrayMatr1 = Create2dArray(userLen);
int [,] arrayMatr2 = Create2dArray(userLen);
PrintTwoArrays(arrayMatr1, arrayMatr2);
int [,] arrayMulti = MultiplyTwoArrays(arrayMatr1, arrayMatr2);
PrintSingleArray(arrayMulti);