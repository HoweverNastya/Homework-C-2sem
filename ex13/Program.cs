// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 10
//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a/10%10;
Console.Write("второе число: ");
Console.WriteLine(b);
