// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите сторону b1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону k1: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону b2: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону k2: ");
int num4 = Convert.ToInt32(Console.ReadLine());

bool Equation(int x, int y)
{
    return y = k1 * x + b1 == y = k2 * x + b2;
}
bool result = Equation (num1, num2, num3, num4);
Console.WriteLine(result?"Является треугольником":"Не является треугольником");
