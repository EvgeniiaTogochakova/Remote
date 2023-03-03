
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

int GetValueFromConsole(string text)
{
  int value = 0;

  bool flag = false;
  while (!flag)
  {
    Console.Write(text);
    int.TryParse(Console.ReadLine(), out value);
  }

  return value;
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


int rows = GetValueFromConsole("Строк: ");
int columns = GetValueFromConsole("Столбиков: ");
int findItem = GetValueFromConsole("Что ищем: ");

int[,] matrix = new int[rows, columns];
FillMatrix(matrix, 0, 10);
Console.WriteLine(PrintGood(matrix));

bool check = FindElementInMatrix(matrix, findItem);

if (check)
{
  int[] pos = FindPositionElementInMatrix(matrix, findItem);
  Console.WriteLine($"row: {pos[0]}  column:{pos[1]}");
}
