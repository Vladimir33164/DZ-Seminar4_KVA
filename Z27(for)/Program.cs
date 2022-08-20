//Задача 27: Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

/*Console.WriteLine("Enter number:");//вывод строки
int A = Convert.ToInt32(Console.ReadLine());//ввод значения пользователем
int Sum=0;//создаем переменную под сумму
for (;A > 0;)//цикл пока А больше 0
{
    Sum = Sum + (A % 10);//находим остаток от деления на 10 и прибавляем к текущей сумме
    A /= 10;//делим на 10    
}        
Console.WriteLine("Sum of numbers:" + Sum.ToString()); //вывод результата
*/

Console.WriteLine("Enter number:");
int A = Convert.ToInt32(Console.ReadLine());
int rezult = 0;
for (; A > 0;)
{
rezult = rezult + (A % 10);
A = A / 10;
}
Console.WriteLine($"Sum of numbers: {rezult}");
