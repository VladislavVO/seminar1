/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

/*
int numA, numB;
Console.Write("Input first number ");
numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
numB = Convert.ToInt32(Console.ReadLine());
if (numA>numB)
{
Console.WriteLine("max = " + numA);
Console.WriteLine("min = " + numB);
}
else
{
Console.WriteLine("max = " + numB); 
Console.WriteLine("min = " + numA);
}
*/




/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

/*
int numA, numB, numC, max;
Console.Write("Input first number ");
numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number ");
numC = Convert.ToInt32(Console.ReadLine());
max = numA;
if (numB>max)
{
max = numB;
}
if (numC>max)
{
max = numC;
}
Console.WriteLine("max = " + max);
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
int numA, ost;
Console.Write("Input number ");
numA = Convert.ToInt32(Console.ReadLine());
ost = numA%2;
if (ost==0)
{
Console.WriteLine("да");
}
else
{
Console.WriteLine("нет");  
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
int num;
Console.Write("Input number ");
num = Convert.ToInt32(Console.ReadLine());
int current = 2;

while (current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/