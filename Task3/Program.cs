//Напишите программу, которая принимает на вход координаты
// двух точек  и находит расстояние между ними в 2Д пространстве
// А(3,6) В (2,1) -> 5,09

class program
{

static void Main()

{
    Console.Clear();
Console.WriteLine("Введите значение Х для первой точки ");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y для первой точки ");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Х для второй точки ");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Y для второй точки ");
int Y2 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)));
}
}

