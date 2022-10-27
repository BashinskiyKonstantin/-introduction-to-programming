// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


// int[] FillArray(int num)
// {
//     int[] array = new int[num];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(0,99);
//     }
//     return array;
// }

int[] FillArray(int num)
{
    int[] array = new int[num];
    
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"Введите элемент массива: ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
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

int[] myArr = FillArray(8);
PrintArray(myArr);
