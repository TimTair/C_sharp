﻿// Демонстрация решения

// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> Среда   
// 4 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
string day = Console.ReadLine();

if (day == "1") Console.Write("Понедельник");
else if (day == "2") Console.Write("Вторник");
else if (day == "3") Console.Write("Среда");
else if (day == "4") Console.Write("Четверг");
else if (day == "5") Console.Write("Пятница");
else if (day == "6") Console.Write("Суббота");
else if (day == "7") Console.Write("Воскресенье");
else Console.Write("Ошибка ввода");