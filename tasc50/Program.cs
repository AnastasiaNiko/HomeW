// // Напишите программу, которая на вход принимает позиции элемента в двумерном 
// // массиве, и возвращает значение этого элемента или же указание, что такого 
// // элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int [,] Get2DMassive (int rows, int column)
{
    int [,] numMas2D = new int [rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numMas2D [i, j] = new Random ().Next (0, 99);
        }
    }
    return numMas2D;
}

void Print2DMassive (int [,] massive)
{
    for (int i = 0; i < massive.GetLength (0); i++)
    {
        for (int j = 0; j < massive.GetLength (1); j++)
        {
            Console.Write ($"{massive [i, j]}\t" );
        }
        Console.WriteLine ();
    }
}

int [] GetIndex (int number)
{
    int [] indexMassive = new int [2];
    indexMassive [0] = number / 10;
    indexMassive [1] = number % 10;
    return indexMassive;
}

// Создаем метод вывода элемента двумерного массива

void PrintUnitMassive (int [,] massive2D, int [] massive)
{
    if (massive [0] > massive2D.GetLength (0) || massive [1] > massive2D.GetLength (1))
    {
        Console.WriteLine ("Такого числа в массиве нет ");
    }
    else
    {
        Console.WriteLine ($"Число в массиве : {massive2D [massive[0] - 1, massive [1] - 1]}");
    }
}

int m = InputNum ("Ведите количество строк: ");
int n = InputNum ("Введите количество столбцов: ");

int [,] massive = Get2DMassive (m, n);

Print2DMassive (massive);

int num = InputNum ("Введите индекс ячейки (строка+столбец): ");
int [] index = GetIndex (num);

PrintUnitMassive (massive, index);
