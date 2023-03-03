
void FillMatrix(int[,] matrix, int min, int max)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(min, max);
    }
  }
}

void Print(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}


string PrintGood(int[,] matrix)
{
  string result = String.Empty;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      result += $"{matrix[i, j],5} ";
    }
    result += "\n";
  }
  return result;
}

bool FindElementInMatrix(int[,] matrix, int element)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] == element)
      {
        return true;
      }
    }
  }
}


int[] FindPositionElementInMatrix(int[,] matrix, int element)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] == element)
      {
        return new int[] { i, j };
      }
    }
  }
  return new int[] { -1, -1 };
}

Console.WriteLine("Введите, пожалуйста, число. Я создам матрицу и найду в ней позиции вашего числа");
int value = int.Parse(Console.ReadLine());
int[,] matr = new int[10, 10];
Console.WriteLine();
RandomMatrixPrint(matr);
Console.WriteLine();
FindNumberInMatrix(matr, value);
