// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine("Введите трехзначное число: ");
// string num = System.Console.ReadLine();
// if (num.Length == 3)
// {
//     System.Console.WriteLine("Вторая цифра введенного числа: " + num.Substring (1, 1));
// }
// else 
// {
//     System.Console.WriteLine("Введенное число не соответствует условиям задачи!");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите трехзначное число: ");
string num = System.Console.ReadLine();
if (num.Length >= 3)
{
    System.Console.WriteLine("Третья цифра введенного числа: " + num.Substring (2, 1));
}
else 
{
    System.Console.WriteLine("Третья цифра отсутствует");
}