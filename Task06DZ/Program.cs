//  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

//  4 -> да
//  -3 -> нет
//  7 -> нет



Console.WriteLine("Введите  число");
int a = Convert.ToInt32(Console.ReadLine());

int Mod(int a)
{
    return a % 2;
}
void PrintMod(int remai)//на основе остатка выводим число кратное или нет
{
    if (remai == 0)// сравниваем остаток с 0
        Console.WriteLine("Число кратно");
    else
        Console.WriteLine($"Не кратно, остаток {remai}");
}

int mod = Mod(a);
PrintMod(mod);