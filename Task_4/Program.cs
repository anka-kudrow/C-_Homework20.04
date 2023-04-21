// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Write three numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max_num = 0;
if(num1 > num2)
{
    if(num1 > num3)
        max_num = num1;
}        
else if (num2 > num1)
{
    if(num2 > num3)
        max_num = num2;
}
else
{
    max_num = num3;
}
Console.WriteLine(max_num);    



       
