// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write(" Введите количество элементов  в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 9);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        // Console.Write($"[{String.Join(",", array.Length)}]"); 
    }
Console.Write($"[{String.Join(",", array)}]"); 
}
