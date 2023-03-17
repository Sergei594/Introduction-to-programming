// архив аргументов 


// аргумент название collection сделали рандомные числа от 1 до 10
void FillArray(int[] collection)
{
    // длинна массива .Length
    int length = collection.Length;
    //    по умолчанию позиция индекс начинаеться с 0
    int index = 0;
    while (index < length)
    {
        // обращение к аргументу (collection) на позицию индех и положить туда новое случайное число(целое число из диапозона 1,10)
        collection[index] = new Random().Next(1, 10);
       // index = index + 1;
    index++;
    }
}

// void не возвращает значения поэтому мы не используем retern
void PrintArray(int[] col)
{
    // количество элементов
int count = col.Length;
int position = 0;
while(position < count)
{
    Console.WriteLine(col[position]);
    position++;
}
}

// массив из 10 элементов
int[] array = new int[10];

// вызвали метод FillArray который заполнил элементы
FillArray(array);
// вызвали метод который распечатал элементы
PrintArray(array);
