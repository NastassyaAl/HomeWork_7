Console.Clear();

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int s = new Random().Next(-1, 1);
        if (s == 0) { s = 1; }
        matrix[i, j] = Math.Round(new Random().NextDouble() * 10 * s, 1);
        Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine();
}