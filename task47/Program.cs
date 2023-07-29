// Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n}.\t");

double[,] massive = new double[m, n];
void Get2Dmassive(double[,] massive)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massive[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteMassive(double[,] massive)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double realNumber = Math.Round(massive[i, j], 1);
            Console.Write($"{realNumber}\t");
        }
        Console.WriteLine();
    }
}
Get2Dmassive(massive);
WriteMassive(massive);
