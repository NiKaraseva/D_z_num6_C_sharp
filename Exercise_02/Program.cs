/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */ 

Console.WriteLine("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine()!);


if(k1 != k2)
{
    double x = Math.Round((b2 - b1) * 1.0 / (k1 - k2), 2);
    double y = Math.Round((k1 * b2 - k2 * b1) * 1.0 / (k1 - k2), 2);
    Console.WriteLine($"Координаты точки пересечения отрезков = {(x, y)}");
}

else if((k1 == k2) && (b1 != b2))
{
    Console.WriteLine("Две прямые параллельны");
}
else if((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Две прямые совпадают");
}