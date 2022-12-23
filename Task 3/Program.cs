// Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
// В каждом столбце найдите среднее арифметическое среди элементов.
// Полученные средние арифметические занести в одномерный массив.

Random random = new Random();
int[,] arr = new int[random.Next(3,3), random.Next(4,4)];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(100, 1000);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("=> [ ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    float sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
    
}
Console.Write("]");
