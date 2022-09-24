Console.Clear();

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void NumberPosition(int[,] array)
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    int x = 0;
    int y = 0;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                x = i;
                y = j;
                Console.WriteLine($"Позиция элемента в массиве [{x},{y}]");
            }
            else
            {
                count++;
            }
            if (count == array.GetLength(0) * array.GetLength(1))
            {
                System.Console.WriteLine("Такого числа в массиве нет");
            }

        }
    }
}



int[,] array = FillMatrix(4, 3);
NumberPosition(array);