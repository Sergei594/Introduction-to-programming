// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6




int number = Prompt("Введите число->");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {

        Console.WriteLine($"Третий цифры нет ");
        return false;

    }
    return true;
}


// моя попытка решить задачу

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0) number = -number;
// if (number > 100)
// {
// int secondВigit = number % 100;
// int result = secondВigit;
// int SecondВigit = result / 10;


// Console.WriteLine($"Третья цифра числа -> {SecondВigit}");
// }
// if (number < 99)
// {
// Console.WriteLine($"Третий цифры нет ");
// }
// if (number > 10000)
// {
// int secondВigit = number % 1000;
// int result = secondВigit;
// int SecondВigit = result / 100;
// Console.WriteLine($"Третья цифра числа -> {SecondВigit}");

// }