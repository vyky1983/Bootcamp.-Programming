using static System.Console;
Clear();

//O(n²)

int n = Convert.ToInt32(ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++) 
    {
     Console.Write(i * j);
     Console.Write("\t");
     }
     System.Console.WriteLine();
}