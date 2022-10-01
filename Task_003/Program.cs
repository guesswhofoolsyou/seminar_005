/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int GetLength()
{
    Random rnd = new Random();
    int length = rnd.Next(5, 10);
    Console.WriteLine("Длина массива: " + length);
    Console.WriteLine();
    return length;
}

double[] InitArray(int demension)
{
    double[] array = new double[demension];
    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 10, 0);
    }
    return array;
}

double SearchingMinValue(double[] array)
{
    double minValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (minValue < array[i])
            minValue = array[i];
    }
    Console.Write("Минимальный элемент массива: " + minValue);
    return minValue;
}

double SearchingMaxValue(double[] array)
{
    double maxValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (maxValue > array[i])
            maxValue = array[i];
    }
    Console.Write("Максимальный элемент массива: " + maxValue);
    return maxValue;
}

double Dif(double minValue, double maxValue)
{
    double dif = maxValue - minValue;
    Console.Write("Разница между максимальным и минимальным элементами: " + dif);
    return dif;
}

void PrintData(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine();
}

int length = GetLength();

double[] array = InitArray(length);
PrintData(array);
Console.WriteLine();

double minValue = SearchingMinValue(array);
Console.WriteLine();

double maxValue = SearchingMaxValue(array);
Console.WriteLine();

double dif = Dif(maxValue, minValue);
Console.WriteLine();