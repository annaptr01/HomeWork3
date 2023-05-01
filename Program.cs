//Задача 19
//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

void Palindrom()
{
    Console.WriteLine("Enter 5-digits number: ");
    int user_num = Convert.ToInt32(Console.ReadLine());

    if(user_num > 9999 && user_num < 100000)
    {
        int first_num = user_num / 10000;   //12345 = 1
        int second_num = user_num / 1000 % 10; //12345 = 2
        int third_num = user_num / 100 % 10;
        int fourth_num = user_num / 10 % 10;
        int fifth_num = user_num % 10;

        else if(first_num == fifth_num $$ second_num == fourth_num)

            Console.WriteLine("Your number is Palindrome!");
            
        else
            Console.WriteLine("Your number is not Palindrome!");
    }
    else Console.WriteLine("You entered not 5-digit number!");
}





//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*
double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 - x2)+(y1 - y2)*(y1 - y2)+(z1 - z2)*(z1 - z2));
    double lengthAB1 = Math.Round(lengthAB, 2); //округление значения
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
/*
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
            Console.Write($"{res:f0}, ");
            current_i ++;
        }
        Console.WriteLine("\b\b.");  //удалить 2 символа из вывода
    }
    else
    Console.WriteLine("Impossible value!");
}
*/