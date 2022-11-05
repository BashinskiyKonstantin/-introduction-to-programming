// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int amountNumbers = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int num)
{
    int[] array = new int[num];
    
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"Введите {i+1} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
    return array;
}


int SumPositiveNumbers (int [] array)
{
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0) sumPositive++;
       
    }
    return sumPositive;
}

int[] myArray = CreateArray(amountNumbers);
Console.WriteLine($"Количество чисел больше 0 равно -> {SumPositiveNumbers(myArray)}");
