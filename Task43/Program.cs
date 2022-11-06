// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите точку b1 для первой прямой: ");
int  pointB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку k1 для первой прямой: ");
int  pointK1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку b2 для второй прямой: ");
int  pointB2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку k2 для второй прямой: ");
int pointK2 = Convert.ToInt32(Console.ReadLine());


double SearchX(int b1, int k1, int b2, int k2)
{
    double searchX1 = k1 - k2;
    double searchX2 = b1 - b2; 
    double x = searchX2 / -searchX1;
    double xResult = Math.Round(x, 1);
    return xResult;
}
 
double x = SearchX(pointB1,pointK1,pointB2,pointK2);
double y1 = pointK1 * x + pointB1;
double y1Result = Math.Round(y1, 1);
double y2 = pointK2 * x + pointB2;
double y2Result = Math.Round(y2, 1); 

Console.WriteLine($"Точки пересечения двух пярмых ({y1Result}; {y2Result}) ");