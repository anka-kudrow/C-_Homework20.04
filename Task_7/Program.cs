﻿// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
if(num < 10)
    Console.WriteLine("No");

else 
{
    while (num > 99)
    {
        num = num / 10;
    }
    result = num % 10;
}    

Console.WriteLine(result);