﻿//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8





int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
//int firstDigit = number / 10;
//int secondDigit = number % 10;
//if (firstDigit == secondDigit) Console.WriteLine ($"Числа одинаковые");
//else if (firstDigit > secondDigit) Console.WriteLine ($"Наибольшее число = {firstDigit}");
 // else Console.WriteLine ($"Наибольшее число = {secondDigit}");


int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;


    //if (firstDigit > secondDigit) return firstDigit;
    //return secondDigit;


    //int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    //return result;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit (number);

Console.WriteLine ($"Наибольшее число = {maxDigit}");


//int res =Math.Max(firstDigit,secondDigit);
//Console.WriteLine($"Наибольшая цифра числа = {res}");