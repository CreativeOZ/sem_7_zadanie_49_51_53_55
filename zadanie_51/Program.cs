// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n.

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
        array[i,z] = i + z;
        Console.Write(array[i,z] + " ");
    }
    Console.WriteLine();
}