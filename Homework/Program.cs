﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5  /  782 -> 8 / 918 -> 1


Console.Clear();
int num = new Random().Next(100, 999);
Console.WriteLine($"трехзначное число: {num}");

int newNum = (num % 100 - num % 10) / 10;
Console.WriteLine($"вторая цифра заданного числа: {newNum}");

