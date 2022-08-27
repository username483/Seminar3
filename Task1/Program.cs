//Напишите программу, которая принимает на вход координаты
// точки (X,Y), причем X!=0, Y!=0 и выдает номер четверти плоскости,
// в которой находится эта точка

Console.Clear();
Console.WriteLine("Введите X ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y ");
int Y = int.Parse(Console.ReadLine());

if (X>0 && Y>0)
{
    Console.WriteLine("1 четверть");
}
else
{
     if(X<0 && Y>0)
     {
        Console.WriteLine("2 четверть");
     }
     else
     {
         if( X<0 && Y<0) 
         {
            Console.WriteLine("3 четверть");
         }
         else 
         {
            if (X>0 && Y<0)
            {
               Console.WriteLine("4 четверть"); 
            }
            else 
            {
                Console.WriteLine("одно или несколько введенных чисел =0, точка находится на оси координат, а не внутри четверти");
            }
         }
     }

}