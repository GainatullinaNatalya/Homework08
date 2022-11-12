//Найти произведение двух матриц

void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

Console.WriteLine("Введите размер первого массива: ");
int m = ReadIntegerNumber("Количество строк: ");
int n = ReadIntegerNumber("Количество столбцов: ");

Console.WriteLine("Введите размер второго массива: ");
int s = ReadIntegerNumber("Количество строк: ");
int p = ReadIntegerNumber("Количество столбцов: ");

Console.WriteLine();
Console.WriteLine("Первый массив: ");

int[,] matrix1 = new int[m, n];

FillMatrix(matrix1, 1, 10);
PrintMatrix(matrix1);

Console.WriteLine();
Console.WriteLine("Второй массив: ");

int[,] matrix2 = new int[s, p];

FillMatrix(matrix2, 1, 10);
PrintMatrix(matrix2);

Console.WriteLine();

int[,] matrix3 = new int[m, p];

if (n != s) Console.WriteLine("Такие матрицы нельзя перемножить!");
else
{
    Console.WriteLine("Произведение матриц: ");
    MultiplicationMatrix(matrix1, matrix2, matrix3);
    PrintMatrix(matrix3);
}
