// Сформировать трехмерный массив /не повторяющимися двузначными числами (не обязательно)/ 
//показать его построчно на экран выводя индексы соответствующего элемента

void FillThreeArray(int[,,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max);
            }
}

void PrintThreeArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"|{j}| {array[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int a = ReadIntegerNumber("Введите первый размер массива: ");
int b = ReadIntegerNumber("Введите второй размер массива: ");
int c = ReadIntegerNumber("Введите третий размер массива: ");

int[,,] array = new int[a, b, c];
FillThreeArray(array, 0, 100);
Console.WriteLine("Массив: ");
PrintThreeArray(array);
