//Задача 19
//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.







//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*
double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 - x2)+(y1 - y2)*(y1 - y2)+(z1 - z2)*(z1 - z2));
    double lengthAB1 = Math.Round(lengthAB, 3); //округление значения
    return lengthAB1;
}
Console.WriteLine("Input x coordinate of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinate of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z coordinate of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x coordinate of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinate of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z coordinate of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance AB is {dist}");
*/


//Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void CubeFinder()
{
    Console.WriteLine("Input number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if(numberN > 0)
    {
        int current_i = 1;
        while(current_i <= numberN)
        {
            double res = Math.Pow(current_i, 3);
            Console.Write($"{res}, ");
            current_i ++;
        }
        Console.WriteLine("\b\b.");  //удалить 2 символа из вывода
    }
    else
    Console.WriteLine("Impossible value!");
}
