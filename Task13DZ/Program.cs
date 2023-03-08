// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;


if (100 < number)
{
int secondВigit = number % 100;
int result = secondВigit;
int SecondВigit = result / 10;


Console.WriteLine($"Третья цифра числа -> {SecondВigit}");
}
else if (99 > number)
{
    Console.WriteLine($"Третий цифры нет ");
}

if (number > 10000)
{
int secondВigit = number % 1000;
int result = secondВigit;
int SecondВigit = result / 100;
Console.WriteLine($"Третья цифра числа -> {SecondВigit}");

}