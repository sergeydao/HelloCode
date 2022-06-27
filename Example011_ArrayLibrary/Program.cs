
void FillArray(int[] collection)  // метод для заполнения массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col) // метод для распечатывания массива
{
    int count = col.Length; // length просто другое название
    int position = 0; // index просто другое название
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int finde)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если искомого элемента нет в массиве, 
    // вернется -1
    while (index < count)
    {
        if (collection[index] == finde)
        {
            position = index;
            break; // нашли первое соответствие и заканчиваем.

        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создать новый массив с 10 числами. По умолчанию это нули.

FillArray(array); // вызываем метод
PrintArray(array); // вызываем метод
Console.WriteLine();

int pos = IndexOf(array, 333); //ищем индекс элемента 4
Console.WriteLine(pos);