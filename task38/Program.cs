// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArray()
{
    double[] array = new double[5];
    Console.Write("Массив {");
    for(int i = 0; i < 5; i++)
    {
        array[i] = 100 * Math.Round(new Random().NextDouble(), 4);
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("}\n");
    return array;
}

void Diff(double[] myArray)
{
    int iMax = 0;
    int iMin = 0;
    for( int i = 1; i < myArray.Length; i++)
    {
        if (myArray[i] > myArray[iMax]) iMax = i;
        if (myArray[i] < myArray[iMin]) iMin = i;
    }
    Console.WriteLine($" разница между max-min = {Math.Round(myArray[iMax] - myArray[iMin], 2)}");
}
Diff(CreateArray());
