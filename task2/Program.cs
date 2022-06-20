/* Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
*/

Console.WriteLine("Ведите первое число: ");
int a = int.Parse(Console.ReadLine ());

Console.WriteLine("Ведите второе число: ");
int b = int.Parse(Console.ReadLine ());
 
 if (a < b )
{ 
     Console.Write("Первое число меньше второго");
}

if ( a > b )
{
    Console.Write("Первое число больше второго");
}
