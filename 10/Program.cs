﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
 918 -> 1 */


int rand= new Random().Next(100,1000);
Console.WriteLine(rand);

int x= rand/10;
int y= x%10;
Console.WriteLine(y);