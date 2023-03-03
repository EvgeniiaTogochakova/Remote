using static MatrixService;

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
else
{
  System.Console.WriteLine("Нет такого");
}
