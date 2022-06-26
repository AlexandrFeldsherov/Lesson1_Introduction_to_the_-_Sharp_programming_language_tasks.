/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

double firstNumber = -3;
firstNumber = firstNumber%2;
if (firstNumber==0) Console.WriteLine("да");
else Console.WriteLine("нет");
