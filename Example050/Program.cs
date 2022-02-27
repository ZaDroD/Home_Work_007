// В двумерном массиве n×k заменить четные элементы на противоположные.

double[,] mass = new double[5, 6];
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
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = array[i, j] * -1;
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray(mass);
PrintMassiv(mass);