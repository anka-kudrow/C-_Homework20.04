﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Write first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write second number");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if(num1 > num2)
{
    max = num1;
    min = num2;
    Console.WriteLine("max = ", max); 
    Console.WriteLine("min = ", min);
}    
else   
    max = num2;
    min = num1;
    Console.WriteLine("max = ", max); 
    Console.WriteLine("min = ", min);


