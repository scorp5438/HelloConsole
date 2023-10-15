int[] array = { 3, 4, 5, 2, -2, 6, 1, -3 };

// Сортировка через двойной цикл while и метод void
void SortArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    while (index < count - 1)
    {
        int i = 0;
        int coun = array.Length;
        while(i < coun - 1)
        {
            if( array[i] > array[i + 1])
            {
                int temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
            i += 1;
        }
        count -= 1;
    }
}

void PrintArray(int[] ar)
{
    int index = 0;
    int count = ar.Length;
    while(index < count)
    {
        Console.Write($"{ar[index]} ");
        index += 1;
    }
}

Array.Sort(array);

SortArray(array);
PrintArray(array);

Console.WriteLine();

for (int n = 0; n < array.Length; n++)
{
    Console.Write($"{array[n]} ");
}