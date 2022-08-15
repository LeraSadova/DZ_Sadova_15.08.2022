// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Давай последовательно введем три координаты для 2х точек? ");
Console.WriteLine("И найдем расстояние между этими точками в пространстве (длину отрезка АВ)");

Console.WriteLine("Введите координату X для точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

//вводим для точки В
Console.WriteLine("Введите координату X для точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки В: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки В: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2)); //формула с использованием встроенной функции
}

double otrezokLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);
//double, т.к. длина будет не целым числом
Console.WriteLine($"Длина отрезка  {otrezokLength}");