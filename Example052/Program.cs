//52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

double[,] mass = new double[4, 4];
double count = 10;
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = count;
            count++;
        }
    }

}
void PrintMassiv(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
            
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray(mass);
PrintMassiv(mass);