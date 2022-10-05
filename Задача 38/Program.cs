// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] |");
}
double Array(double[] array)
{
    double length = array.Length;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    for (int i = 0; i < length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    double diff = Math.Round((max - min), 1);
    return diff;
}
double[] A = CreateArrayRndInt(5, 0, 100);
PrintArray(A);
double B = Array(A);
Console.Write(B);
