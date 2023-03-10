// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
//  int a = (n % 10);

// Console.Write(n % 10);
// {
// {
// while ((n /= 10) != 0)
//    Console.Write (n % 10);
 

// }
// if ( n == a )
// {
//     Console.WriteLine("Число палендром");
// }
// else if (n!=a)
// {
//     Console.WriteLine("Не является палендромом");
// }
// }


Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");







