//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

class program
{

static void Main()
{

Console.Clear();
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine());

if (N>0)
{
    int i=1;
    while (N>=i)
   {
              Console.WriteLine(Math.Pow(i,2));
              i ++;
   }
}
if (N<0)
{
    int i=1;
     while (N<=i)
   {
    Console.WriteLine(Math.Pow(i,2));
              i --;
   }
}

}
}