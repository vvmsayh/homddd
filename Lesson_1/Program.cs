﻿//**Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
System.Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = number/10 %10;
System.Console.WriteLine($"вторая цифра числа {secondDigit}");