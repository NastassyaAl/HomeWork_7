Console.Clear();

int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write("Укажите строку (x) = ");
int x = int.Parse(Console.ReadLine());
Console.Write("Укажите столбец (y) = ");
int y = int.Parse(Console.ReadLine());
if (x < 0 | x > matrix.GetLength(0) - 1 | y < 0 | y > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine("Значение элемента массива: " + matrix[x, y]);
}
