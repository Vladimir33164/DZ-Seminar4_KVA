//Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную 
//степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число В");
int b = Convert.ToInt32(Console.ReadLine());
int sum = a;
for (int i = 1; i < b; i++)
{
    sum = sum * a;
}
Console.WriteLine($"Result A to the degree of B: {sum}");
*/

Console.WriteLine("Enter number А:");//вывод строки
Double A = Convert.ToDouble(Console.ReadLine());//ввод значения А пользователем
Console.WriteLine("Enter number В:");//вывод строки
int B = Convert.ToInt32(Console.ReadLine());//ввод значения В пользователем
Double Rez = A;
for (int i = 1; i < B; i++) Rez *= A;//цикл возведения в степень
Console.WriteLine("Result A to the degree of B:" + Rez.ToString()); //вывод результата