// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int FindQvart(int x, int y);
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else if(x > 0 && y < 0)
        return 4;
    else 
        return 0;
}

Console.Write("Input x coordinate: ");
int xDot = Convert.ToInt32(Console.Readline());
Console.Write("Input y coordinate: ");
int yDot = Convert.ToInt32(Console.Readline());

int qvartNum = FindQvart(xDot, yDot);

if (qvartNum == 0)
    Console.WriteLine("Dot located on the axes!");
else
    Console.WriteLine("Number of quart is " + qvartNum);
*/

// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void Coordinates(int quad);
*/

// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

void Distance(double x1, double y1, double x2, double y2)
{
Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Distance = Math.Sqrt((x2-x1), Math.Pow(2,2)+(y2-y1), Math.Pow(2,2));
Console.WriteLine("Distance: " + Distance);
Console.ReadLine();

// Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4





