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

// System.Console.WriteLine("Введите трехзначное число: ");
// string num = System.Console.ReadLine();
// if (num.Length >= 3)
// {
//     System.Console.WriteLine("Третья цифра введенного числа: " + num.Substring (2, 1));
// }
// else 
// {
//     System.Console.WriteLine("Третья цифра отсутствует");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8)
{
    if (num < 6)
    {
        Console.WriteLine("Нет, это рабочий день");
    }
    else 
    {
        System.Console.WriteLine("Да, это выходной!");
    }
}
else 
{
    System.Console.WriteLine($"{num}-го дня недели не существует!");
}
