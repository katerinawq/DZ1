/*Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.*/  
 
Console.WriteLine("Ведите три числа: ");

int a = int.Parse(Console.ReadLine ());
int b = int.Parse(Console.ReadLine ());
int c = int.Parse(Console.ReadLine ());
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);