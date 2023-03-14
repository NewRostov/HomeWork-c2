﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 99 || number > 999) Console.WriteLine("Вы ввели не целое трехзначное число");
        else Console.WriteLine("Вторая цифра равна: " + (number % 100 - number % 10) / 10);
    }
}