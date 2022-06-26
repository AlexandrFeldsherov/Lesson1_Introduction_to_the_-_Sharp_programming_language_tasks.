/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


double firstNumber = 2;
double secondNumber = 3;
double sthirdNumber = 7;
double max = secondNumber;
if (firstNumber > secondNumber) max = firstNumber;
if (max < sthirdNumber) max = sthirdNumber;
Console.WriteLine(max);

//если программа берет числа из консоли
/*Console.Write("Ведите первое число ");
double firstNumber=Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите второе число ");
double secondNumber=Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите третье число ");
double sthirdNumber=Convert.ToDouble(Console.ReadLine());
double max=secondNumber;
if (firstNumber>secondNumber) max=firstNumber;
if (max<sthirdNumber) max=sthirdNumber;
Console.WriteLine($"Максимальное число {max}");*/