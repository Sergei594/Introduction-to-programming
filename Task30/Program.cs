// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(0, 2);
//collection[index] = new Math.Round(Random().NextDouble(), 0);
index++;
}
}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while(position < count)
{
Console.Write($" {col[position]} ");
position++;
}
}

int[] array = new int[8];

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine();


// 2 вариант записи

// int[] array = new int[8];

// void FillArray(int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = new Random().Next(0, 2);

// }
// }
// void PrintArray(int[] arr)
// {
// int count = arr.Length;
// for (int i = 0; i < count; i++)
// {
// Console.Write($"{arr[i] } ");
// }

// }

// FillArray(array);
// PrintArray(array);


// 3 вариант записи

// int[] array = new int[8];

// void FillArray(int[] arr)
// {
// Random rnd = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(0, 2);

// }
// }

// void PrintArray(int[] arr)
// {
// int count = arr.Length;
// for (int i = 0; i < count; i++)
// {
// Console.Write($"{arr[i] } ");
// }

// }

// FillArray(array);
//  PrintArray(array);