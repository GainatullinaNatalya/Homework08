//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

void FillTriangle(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < triangle.GetLength(0); i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}
void PrintTriangle(int[,] triangle, int cellWidth)
{   
    int col = cellWidth * triangle.GetLength(0);
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0)
            {
                Console.Write($"{triangle[i, j]}");
                col += cellWidth * 2;
            }
        }
        col = cellWidth * triangle.GetLength(0) - cellWidth * (i + 1);
    }
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Треугольник Паскаля: ");

int a = 10;
const int cellWidth = 3;
int[,] triangle = new int[a, a];

FillTriangle(triangle);   
PrintTriangle(triangle, cellWidth);
Console.WriteLine();