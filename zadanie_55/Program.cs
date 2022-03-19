// 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();

Console.Write("Колличество срок: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Колличество стобцов: ");
int n = int.Parse(Console.ReadLine());
int [,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int z = 0; z < n; z++)
    {
        array[i,z] = new Random().Next(0,10);
        Console.Write(array[i,z] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int z = 0; z < n; z++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + array[i,z];
    }
    Console.WriteLine($"Cреднее арифметическое каждого из столбцов: {sum / m}" + " ");
}
