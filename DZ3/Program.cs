﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Vvedite pyatiznachnoe chislo: ");
// string num = Console.ReadLine();

// if (num.Length == 5){
//     if (num[0] == num[4] && num[1] == num[3]){
//         Console.WriteLine("Eto polindrom");
//     }
//     else 
//     {
//         Console.WriteLine("Eto ne polindrom");
//     }
// }
// else
// {
//     Console.WriteLine("Eto ne 5-ti znachnoe chislo");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Vvedite koordinatu A1: ");
// int a1 = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Vvedite koordinatu A2: ");
// int a2 = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Vvedite koordinatu A2: ");
// int a3 = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Vvedite koordinatu B1: ");
// int b1 = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Vvedite koordinatu B2: ");
// int b2 = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Vvedite koordinatu A2: ");
// int b3 = Convert.ToInt32(Console.ReadLine()!);


// double ab = Math.Sqrt(Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2) + Math.Pow((a3 - b3), 2));

// Console.WriteLine($"Rasstoyanie mezhdu tochkami = {ab:f2}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Vvedite chislo: ");
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= num; i++)
{
    int sqr = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine(sqr);
}