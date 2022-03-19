// 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Clear();

Console.Write("Колличество срок: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Колличество стобцов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Задано число: ");
int num = int.Parse(Console.ReadLine());

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
bool result1 = true;
bool result2 = false;
for (int i = 0; i < m; i++)
{
    for (int z = 0; z < n; z++)
    {
        if (array[i,z] == num)
        {
            result1 = true;
            Console.WriteLine($"Позиция числа в массиве: ({i},{z})");
        }
        if (result2 = false) Console.Write("Числа нет в массиве.");// не работает. 
    }
}    
        
    