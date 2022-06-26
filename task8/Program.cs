/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Ведите число ");
double number=Convert.ToDouble(Console.ReadLine());
int wholeNumber=(int)number;
for(int outputNumber=1;outputNumber<=wholeNumber;outputNumber++) {
int remains=outputNumber%2;
if (remains==0) Console.Write($"{outputNumber}, ");
}

