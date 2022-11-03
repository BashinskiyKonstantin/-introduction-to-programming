// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100,999);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int HonestCounter ( int [] arr)
{   
    int counter = 0;
     for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] %2 == 0) 
        {
            counter++;
        }
       
    }
    return counter;
}


int[] myArr = FillArray(4);
PrintArray(myArr);
Console.WriteLine($"   Количество чётных чисел в массиве равно -> {HonestCounter(myArr) }");