// Напишите программу, которая найдёт точку пересеения двух прямых, заданных уравнением: y=k1*x+b1, y=k2*x+b2; значения b1,k1 и b2,k2
// задаются пользователем. b1=2, k1=5, b2=4, k2=9

Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b1 - b2) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine("x= " + x + "; y = " + y);