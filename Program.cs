//Задача 1. Ввести целое число и вывести его квадрат
/*

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int Result = num*num;

Console.WriteLine("Result is " + Result);

*/

//Задача 2. Написать программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго

/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("First number is a quad of second number");

else

   Console.WriteLine("First number is not a quad of second number"); 
*/


//Задача 3. Пользователь вносит номер дня недели и нужно вывести название дня недели.

/*
Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day < 1)
{
    Console.WriteLine("Incorrect number of day!");
}
else
{
    if(day == 1)
    Console.WriteLine("It's Monday");
    if(day == 2)
    Console.WriteLine("It's Tuesday");
    if(day == 3)
    Console.WriteLine("It's ");
}
*/

//Задача 4. Напишите программу, которая на вход принимает одно число (num), а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if(num < 0)
{
    current = num;
    num = num * (-1);
}
else
{
current = -1 * num;
}

while(current <= num)
{
    Console.Write(current + " ");
    //current = current + 1;
    current++;
}
*/

//Задача 5. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа

/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
    Console.WriteLine("Incorrect number");
else
{
    int a = num % 10;
    Console.WriteLine("Result number is " + a);
}
*/

/*
Семинар 2

//Задача 6. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
void ShowNumber()
{
    int num = new Random().Next(10, 99);
    int firstNum = num/10;
    int secondNum = num%10;

    Console.Write(num + " -> ");

    if(firstNum > secondNum)
    {
        return firstNum;
    else
    {
        return secondNum;

*/

// Домашнее задание 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)

    Console.WriteLine("Первое число больше второго");

else
    Console.WriteLine("Второе число больше первого");
*/

// Домашнее задание 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)

    max = num2;

if(num3 > max)

    max = num3;

Console.WriteLine("Максимальное число " + max);
*/

// Домашнее задание 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)

    Console.WriteLine("Число является четным");

else

    Console.WriteLine("Число не является четным");
*/
