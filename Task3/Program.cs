// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenerateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach(double item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

double DifMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
        for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max) {max = array[i];}
        if(array[i] < min) {min = array[i];}
    }
        return (max - min);
}
double[] array = GenerateArray(5);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {DifMaxMin(array)}");