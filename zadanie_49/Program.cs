// 49. Показать двумерный массив размером m×n, заполненный вещественными числами.

Console.Clear();

Console.Write("Колличество срок: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Колличество стобцов: ");
int n = int.Parse(Console.ReadLine());

double [,] array = new double [m,n];
for (int i = 0; i < m; i++)
{
    for (int z = 0; z < n; z++)
    {
        array[i,z] = new Random().NextDouble();
        Console.Write(array[i,z] + " ");
        /* Console.Write(Math.Round(array[i,z] , 3) + "   "); колличество цифр в остатке после запятой */
    }
    Console.WriteLine();
}