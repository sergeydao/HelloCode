int[] array = { 1, 12, 31, 42, 54, 61, 72, 18 };

int n = array.Length; // длина массива

int find = Convert.ToInt32(Console.ReadLine());

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //прервать. Когда нашли первый индекс, цикл окончится.
    }
    index++;
}