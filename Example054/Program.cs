// 54. В матрице чисел найти сумму элементов главной диагонали.
int[,] mass = new int[4, 4];
Random rand = new Random();
int sum = 0;
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(10,100);
        }
    }

}
int PrintMassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + array[i, j];
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return sum;
}
FillArray(mass);
PrintMassiv(mass);
Console.WriteLine("Сумма главной диагонали = " + sum);