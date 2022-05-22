﻿// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.Write("Введите X1 -> ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1 -> ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1 -> ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine($"A ({x1}, {y1}, {z1})");
Console.Write("Введите X2 -> ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2 -> ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z2 -> ");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine($"B ({x2}, {y2}, {z2})");
//
double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(Math.Round(result, 3));