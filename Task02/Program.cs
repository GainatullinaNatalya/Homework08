// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int RowMinIndex(int[,] matr)
{
    int min = matr[0, 0];
    int MinIndRow = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                MinIndRow = i;
            }
        }
    }
    return MinIndRow;
}

int ColumnMinIndex(int[,] matr)
{
    int min = matr[0, 0];
    int MinIndCol = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                MinIndCol = j;
            }
        }
    }
    return MinIndCol;
}

void RowChangeMatr(int[,] matr, int MinIndRow)
{
    for (int i = MinIndRow; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matr[i + 1, j];
        }
    }
}

void ColChangeMatr(int[,] matr, int MinIndCol)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = MinIndCol; j < matr.GetLength(1) - 1; j++)
        {
            matr[i, j] = matr[i, j + 1];
        }
    }
}

void PrintChangeMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int r = ReadIntegerNumber("Введите количество строк: ");
int c = ReadIntegerNumber("Введите количество столбцов: ");

int[,] matrix = new int[r, c];

FillMatrix(matrix, 0, 50);
PrintMatrix(matrix);

int m = RowMinIndex(matrix);
int n = ColumnMinIndex(matrix);

Console.WriteLine();

RowChangeMatr(matrix, m);
ColChangeMatr(matrix, n);
PrintChangeMatr(matrix);