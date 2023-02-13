// Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> Да
// -3 -> Нет
// 7 -> Нет

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0 )
{
    Console.WriteLine("Да");
    }
else
{
    Console.WriteLine("Нет");
}