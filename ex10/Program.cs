﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a%10;
if (a > 99)
{
    Console.Write("Третье число: ");
    Console.WriteLine(b);
}
if (a < 99)
{
    
    Console.WriteLine("Третьего числа нет! ");
}