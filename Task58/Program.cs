// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    int sum = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resultMatrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
            sum = 0;
        }

    }
    return resultMatrix;
}




int[,] firstArray2D = CreateMatrixRndInt(2, 2, 1, 4);
PrintMatrix(firstArray2D);
Console.WriteLine();
int[,] secondArray2D = CreateMatrixRndInt(2, 2, 1, 4);
PrintMatrix(secondArray2D);
Console.WriteLine();
int[,] resultArray2D = secondArray2D;
if (firstArray2D.GetLength(0) == secondArray2D.GetLength(1))
{
    Console.WriteLine("Результирующая матрица:");
    System.Console.WriteLine();
    resultArray2D = MultiplyMatrix(firstArray2D, secondArray2D, resultArray2D);
    PrintMatrix(resultArray2D);
}
else Console.WriteLine("Умножение невозможно!");