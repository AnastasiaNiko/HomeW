// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
    }
void Degree (int number, int degree)
{
    int result  = number;

    for (int i = 2; i <= degree; i++)
    {
        result *= number;
    }
    Console.WriteLine ($" Результат: {result}");
}

int number = InputNum (" Введите число: ");

int degree = InputNum (" В какую степень возвести: ");

Degree(number, degree);
