int[,] array = new int[1000,1000];
double[] avg = new double[1000];
int i = 0, j = 0, m = 0, n = 0;
Random rand = new Random();

Console.WriteLine("Задайте двумерный массив MxN через пробел: ");
int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (i = 0; i < size[1]; i++)
    for (j = 0; j < size[0]; j++)
        array[i,j] = rand.Next(100);

Console.WriteLine("Сгенерированный массив: " + size[0] + "x" + size[1]);

for (i = 0; i < size[1]; i++) 
{
    for (j = 0; j < size[0]; j++)
        if (array[i,j] < 10) Console.Write(" " + array[i,j] + " ");
        else Console.Write(array[i,j] + " ");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Среднее по столбцам: ");
for (i = 0; i < size[0]; i++) 
{
    for (j = 0; j < size[1]; j++) 
    {
        avg[i] = avg[i] + array[j,i];
    }
    avg[i] = avg[i] / size[1];
    Console.Write(Math.Round(avg[i], 1) + " ");
}
Console.WriteLine();
