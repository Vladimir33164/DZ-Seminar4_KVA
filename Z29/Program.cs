//Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//6, 1, 33 -> [6, 1, 33]

/*int[] GetArray(int size)//создаем объект, массив типа GetArray.
{
    int[]result = new int[size];
    for (int i = 0; i < result.Length; i++)//цикл ввода элементов массива пользователем
        {
            Console.WriteLine("Enter number:");
            result[i] = Convert.ToInt32(Console.ReadLine());//result[i] = new Random().Next(50);
        }
        return result;
}    
int[] testArray = GetArray(8);
Console.WriteLine($"Array: [{String.Join(", " ,testArray)}]");//вывод значения элемента
*/

//Миша! Очень долго думал, как же решить эту задачу (через ввод массива вручную "Console.WriteLine()")?
//На семинаре ребята уже подымали этот вопрос, но у меня так ничего и не вышло.
//Подсказали мне вот такой способ решения этой задачи (внизу). Но уж больно он мне не нравится!!!
//Я так думаю, тот метод который предлагал ты на семинаре будет проще, но пока не представляю как
//решить эту задачку твоим методом. Было бы интересно узнать фактическое решение задачи.

int[] GetArray(int size)//создаем объект, массив типа GetArray.
{
    int[]result = new int[size];
    for (int i = 0; i < result.Length; i++)//цикл ввода элементов массива пользователем
        {
            Console.WriteLine("Enter number:");
            result[i] = Convert.ToInt32(Console.ReadLine());
        }
        return result;
}    
int[] testArray = GetArray(8);
Console.WriteLine($"Array: [{String.Join(", " ,testArray)}]");//вывод значения элемента


/*int Size = 8;//размер массива
Double[] Massiv = new Double[Size];//создаем объект, массив типа double из 8ми элементов
Console.WriteLine("Enter the array elements [Number of elements 8]:");//вывод строки
for (int i = 0; i < Size; i++)//цикл ввода элементов массива пользователем
    {
    Console.WriteLine("["+i.ToString()+"]:");//вывод индекса элемента
    Massiv[i] = Convert.ToDouble(Console.ReadLine());//инициализация элемента массива
    }

            //Вывод элементов массива
Console.WriteLine("Array Elements: ");//вывод строки
for (int i = 0; i < Size; i++)//цикл
Console.WriteLine(Massiv[i]);//вывод значения элемента
*/