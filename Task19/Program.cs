// Задача 19

// Напишите программу, которая принимает на вход пятизначное
//  число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций
//  (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool CheckPalindrome(int num)
{
    int firstnum = num / 10000;
    int fivenum = num % 10;
    if (firstnum == fivenum)
    {
        int secondnum = num / 1000;
        secondnum = secondnum % 10;
        int fournum = num % 100;
        fournum = fournum / 10;
        if (secondnum == fournum) return true;
        else return false;
    }
    else return false;
}

bool CheckLenght(int num)
{
    if (num / 10000 != 0) 
{
    num = num /10000; 
    if (num /10 == 0) return true;
    else return false;
} 
    else return false;
}

if (CheckLenght(num)) 
{
    if (CheckPalindrome(num)) Console.WriteLine("Число является палиндромом!");
    else Console.WriteLine("Число не является палиндромом!");
}
else Console.WriteLine("Число не является пятизначным!");