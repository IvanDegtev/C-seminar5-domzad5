// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

double[] CreateArray(int length, int minRnd, int maxRnd)
{
    double[] array = new double[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double SumSign(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max - min;
}

int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной величины");
int maxRnd = ReadInt("Введите границу максимума случайной величины");
double[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива {SumSign(array)}");
