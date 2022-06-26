/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.WriteLine("Ведите первое число");
double firstNumber=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите второе число");
double secondNumber=Convert.ToDouble(Console.ReadLine());
if (firstNumber>secondNumber) Console.WriteLine($"{firstNumber}, больше чем {secondNumber}");
else Console.WriteLine($"{firstNumber}, меньше чем {secondNumber}");