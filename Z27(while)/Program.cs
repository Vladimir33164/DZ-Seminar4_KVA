﻿//Задача 27: Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Enter number:");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (i > 0)
{
sum = sum + (i % 10);
i = i / 10;
}
Console.WriteLine($"Sum of numbers: {sum}");
