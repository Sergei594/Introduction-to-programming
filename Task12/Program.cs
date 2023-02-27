// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Mod(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}
void PrintMod(int remai)//на основе остатка выводим число кратное или нет
{
    if (remai == 0)// сравниваем остаток с 0
        Console.WriteLine("Число кратно");
    else
        Console.WriteLine($"Не кратно, остаток {remai}");
}
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int mod = Mod(number1, number2);
PrintMod(mod);
