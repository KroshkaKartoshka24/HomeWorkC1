// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
string num = System.Console.ReadLine();
if (num.Length == 3)
{
    System.Console.WriteLine("Вторая цифра введенного числа: " + num.Substring (1, 1));
}
else 
{
    System.Console.WriteLine("Введенное число не соответствует условиям задачи!");
}