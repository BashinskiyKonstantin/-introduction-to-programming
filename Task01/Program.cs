// Итерация №1
// 1. Напиши программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
 
//  а = 25, b = 5 -> да
//  а = 2, b = 10 -> нет
//  а = 9, b = 3 -> да
//  а = -3, b = 9 -> нет


Console.WriteLine ("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine ("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine ());

bool result = secondnumber * secondnumber == firstnumber;

if (result){
    Console.WriteLine ("Первое число является квадратом второго");
}

else{
    Console.WriteLine ("Первое число не является квадратом второго");
}

