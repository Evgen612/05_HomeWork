// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

int[] NewArray()
{
    int[] res = new int[6];
    for (int i = 0; i < 6; i++)
    {
        res[i] = new Random().Next(0, 11);
        Console.Write(res[i] + " ");
    }
    return res;
}

void FindArray(int[] size)
{
    int sum = 0;
    for(int i = 0; i < 6; i++)
    {
        if(i % 2 != 0) sum += size[i];
    }
    Console.WriteLine("-->" + sum);
}
FindArray(NewArray());


