// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine ("Введите число 1: " );
int firstNumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите число 2: " );
int secondNumber = Convert.ToInt32 (Console.ReadLine());

bool CheckSquare (int num1, int num2)
{
return num1 * num1 == num2 || num2 * num2 == num1;
}
if (CheckSquare(firstNumber, secondNumber)) Console.WriteLine("yes");
else Console.WriteLine("no");


