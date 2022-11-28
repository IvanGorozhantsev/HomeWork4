// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.Write("Введите первое число :");
// int a =Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число :");
// int b =Convert.ToInt32(Console.ReadLine());
// int c = a;
// for (int i = 1; i < b; i++)
// {
// c = c * a;
// }
// Console.WriteLine("A в степени B равно: " + c);
// Так же проще!
// double c =Math.Pow((a), b);
// Console.WriteLine(c);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.Write("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (x > 0)
// {
// int num = x % 10;
// x = x / 10;
// sum = sum + num;
// }
// Console.WriteLine("Сумма всех цифр в числе равна: " + sum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] randomArray = new int[8];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(0, 7);
//     Console.Write(randomArray[i] + " ");
// }
