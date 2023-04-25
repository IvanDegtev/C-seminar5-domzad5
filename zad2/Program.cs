// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int SumSign(int[] array, bool isPositive = true)
{
    int sign = 1;
    if (!isPositive)
    {
        sign = -1;
    }

    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        if (array[i] * sign < 0 || sign > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной величины");
int maxRnd = ReadInt("Введите границу максимума случайной величины");
int[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях {SumSign(array)}");
