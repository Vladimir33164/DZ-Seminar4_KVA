//Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную 
//степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.WriteLine("Enter number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number В");
int b = Convert.ToInt32(Console.ReadLine());
int sum = a;
int i = 1;
while (i < b)
{
    sum = sum * a;
    i++;
}
Console.WriteLine($"Result A to the degree of B: {sum}");