using static System.Console;

Clear();

int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(ReadLine());
WriteLine("[" + string.Join(", ", array) + "]");

//[4, 5, 3, 1, 2]
//O(n)
//[1, 2, 3, 4, 5] -- O(n * log n) Быстрая сортировка
// ((5 + 1)/2) * 5 -- O(1) СУММА АРИФМЕТИЧЕСКИХ ПРОГРЕСИИ
//n < n * log(n) + 1

int summa = 0;
for (int i = 0; i < n; i++)
    summa += array[i];
System.Console.WriteLine(summa); //O(n)
