using static System.Console;

Clear();

//O(n²)

int n = Convert.ToInt32(ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write(matrix[i, j]);
        Write(" ");
    }
    System.Console.WriteLine();
}
