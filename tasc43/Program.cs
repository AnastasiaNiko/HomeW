// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, 
// b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputFirstCoefficients()
{
  for (int i = 1; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i}-ой прямой (y = k1 * x + b1):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j == 0) Console.Write($"Введите значение k1: ");
      else Console.Write($"Введите значениие b1: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

void InputSecondCoefficients()
{
  for (int i = 1; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-ой прямой (y = k2 * x + b2):\n");
    for (int z = 0; z < coeff.GetLength(1); z++)
    {
      if(z == 0) Console.Write($"Введите значение k2: ");
      else Console.Write($"Введите значениие b2: ");
      coeff[i,z] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
    Decision(coeff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }

InputFirstCoefficients();
InputSecondCoefficients();
OutputResponse(coeff);
