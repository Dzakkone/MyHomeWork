// Задача 1. Напишите программу, которая выводит случайное число из отрезка от 10 до 99 включительно и показывает 
// наибольшую цифру в этом числе.

/*
void ShownNumber()
{
    int num  = new Random().Next(10, 99);
    int firstNum = num/10;
    int secondNum = num%10;

    Console.Write(num + " -> ");

    if(firstNum > secondNum)
    {
        Console.WriteLine(firstNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}
ShownNumber();
*/

// Задача 2. Написать программу, которая выводит случайное 3х значное число и удаляет вторую цифру этого числа.

/*
void ReduceNumber()
{
    int num  = new Random().Next(100, 999);
    Console.Write(num + " -> ");
    int num1 = num/100;
    int num2 = num%10;
    int num3 = num1*10 + num2;

    Console.Write(num3);
}

ReduceNumber();
*/

// Задача 3. Написать программу, которая принимает на вход 2 числа и проверяет делится ли одно из них на другое, 
// в случае, если не делится вывести остаток.

/*
void IfMultiple()
{
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 % num2 == 0)
{ 
    Console.Write(num1 + " is multiple of " + num2);
}
else
{
    Console.Write(num1 + " is NOT multiple of " + num2);
}
}

IfMultiple();
*/

// Задача 4. Написать программу, которая принимает на вход число и проверяет кратно ли оно и 7 и 23 одновременно.

/*
void Multiple()
{
    Console.Write("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.Write(num + " is multiple 7 and 23");
    }
    else
    {
        Console.Write(num + " is NOT multiple 7 and 23");
    }
}
Multiple();
*/

// Задача 5. Написать программу, которая принимает на вход 2 числа и проверяет является ли одно число квадратом второго.

/*
void Sqr(int num1, int num2)
{
    if (num1 == num2 * num2)
    {
        Console.Write("First number is square second number");
    }
    else
    {
        Console.Write("First number is NOT square second number");
    }
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Sqr(num1, num2);
*/

// Домашнее задание 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

/*
void ReduceNumber()
{
    Console.Write("Input a three-digit number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write(num + " -> ");
    int num1 = num/10;
    int num2 = num1%10;

    Console.Write(num2);
}

ReduceNumber();
*/

// Домашнее задание 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей 
// цифры нет.

/*
void ThirdDigit()
{
    Console.Write("Input a three-digit number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 99)
    {
        Console.Write(num + " -> ");
        Console.WriteLine(num > 99 ? num.ToString()[2] : '-');
    }
    else
    {
        Console.Write("No third digit");
    }
}

ThirdDigit();
*/

// Домашнее задание 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

/*
void WeekDay()
{
    Console.Write("Input number of weekday: ");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day > 7 || day < 1)
    {
        Console.WriteLine("Incorrect number of day!");
    }
    else
    {
        if (day == 1)
            Console.WriteLine("No");
        if (day == 2)
            Console.WriteLine("No");
        if (day == 3)
            Console.WriteLine("No");
        if (day == 4)
            Console.WriteLine("No");
        if (day == 5)
            Console.WriteLine("No");
        if (day == 6)
            Console.WriteLine("Yes");
        if (day == 7)
            Console.WriteLine("Yes");
    }
}

WeekDay();
*/
