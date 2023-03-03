public static class MatrixService
{
  public static void FillMatrix(int[,] matrix, int min, int max)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i, j] = new Random().Next(min, max);
      }
    }
  }

  public static void Print(int[,] matrix)
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

  public static string PrintGood(int[,] matrix)
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

  public static bool FindElementInMatrix(int[,] matrix, int element)
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

    return false;
  }

  public static int GetValueFromConsole(string text)
  {
    int value = 0;

    bool flag = false;
    while (!flag)
    {
      Console.Write(text);
      flag = int.TryParse(Console.ReadLine(), out value);
    }

    return value;
  }

  public static int[] FindPositionElementInMatrix(int[,] matrix, int element)
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
}