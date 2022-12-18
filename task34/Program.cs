// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] NewArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

void PrintArray(int[] size)
{
    for(int i = 0; i < size.Length; i++)
    {
        Console.Write(size[i] + " ");
    }
}

int[] array = NewArray(10);
PrintArray(array);

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0) count++;
}

Console.Write("-->" + count);