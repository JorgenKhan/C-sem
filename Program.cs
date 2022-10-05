//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("First number is greater than second");
}
else if (n1 < n2)
{
    Console.WriteLine("Second number is greater than first");
}
else
{
    Console.WriteLine("Numbers are equal");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2 && n1 > n3)
{
    Console.WriteLine("First number is max");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine("Second number is max");
}
if (n3 > n1 && n3 > n2)
{
    Console.WriteLine("Third number is max");
}
else
{
    Console.WriteLine("More than one max numbers");
}
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("The number is - even");
}
else
{
    Console.WriteLine("The number is - odd");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
int current = 2;
while (current <= number)
{
    Console.WriteLine(current + " ");
    current += 2;
}
}
*/ 
//6 задача выполнена с подсказкой Йоды) поясните пож-та (current + " ") откуда взялись ковычки и что в них есть?
///