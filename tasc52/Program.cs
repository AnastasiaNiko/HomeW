// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 4 4,6; 5,6; 3,6; 3.


int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int [,] Get2DMassive (int rows, int column)
{
    int [,] num2DMas = new int [rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            num2DMas [i, j] = new Random ().Next (0, 10); 
        }
    }
    return num2DMas;
}

void Print2DMassive (int [,] massive2D)
{
    for (int i = 0; i < massive2D.GetLength (0); i++)
    {
        for (int j = 0; j < massive2D.GetLength (1); j++)
        {
            Console.Write ($"{massive2D [i, j]}\t");
        }
        Console.WriteLine ();
    }
}

double [] FindAvrMas (int [,] massive2D)
{
    double [] avrMas = new double [massive2D.GetLength (1)];
    for (int i = 0; i < massive2D.GetLength (1); i++)
    {
        for (int j = 0; j < massive2D.GetLength (0); j++)
        {
            avrMas [i] += massive2D [j, i];
        }
        avrMas [i] = avrMas [i] / massive2D.GetLength (0);
    }
    return avrMas;
}

void PrintMassive (double [] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive [i] = Math.Round (massive [i], 1);
        Console.Write (massive [i]);
    }
        Console.WriteLine ();
}

int m = InputNum ("Введите количество строк: ");
int n = InputNum ("Введите количество столбцов: ");

int [,] massive2D = Get2DMassive (m, n);
Print2DMassive (massive2D);
double [] massiveAvr = FindAvrMas (massive2D);

Console.WriteLine ("Среднее арифметическое элементов в каждом столбце:");
PrintMassive (massiveAvr);
