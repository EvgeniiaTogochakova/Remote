
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


void FindNumberInMatrix(int[,] matrix, int n)
{
  string result = "";

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] == n)
      {
        result += "Позиция вашего числа: строка" + $"{i} " + "столбец" + $"{j}";
        Console.WriteLine(result);
        break;
      }
    }
  }

  if (String.IsNullOrEmpty(result))
  {
    result += "К сожалению, в моей матрице нет вашего числа";
    Console.WriteLine(result);
  }
}

Console.WriteLine("Введите, пожалуйста, число. Я создам матрицу и найду в ней позиции вашего числа");
int value = int.Parse(Console.ReadLine());
int[,] matr = new int[10, 10];
Console.WriteLine();
RandomMatrixPrint(matr);
Console.WriteLine();
FindNumberInMatrix(matr, value);
