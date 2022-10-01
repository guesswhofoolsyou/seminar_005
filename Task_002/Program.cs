/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int GetLength()
{
    Random rnd = new Random();
    int length = rnd.Next(1, 10);
    Console.WriteLine("Длина массива: " + length);
    Console.WriteLine();
    return length;
}

int[] InitArray(int demension)
{
    int[] array = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    return array;
}

int Summ(int[] array)
{
    int summ = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    Console.Write("Сумма нечетных элементов: " + summ);
    return summ;
}

int SummAnotherWay(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            summ += array[i];
    }
    Console.Write("Сумма элементов: " + summ);
    return summ;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int arraylength = GetLength();
int[] array = InitArray(arraylength);
PrintArray(array);
int summOfElements = Summ(array);
Console.WriteLine();
int anotherSumm = SummAnotherWay(array);