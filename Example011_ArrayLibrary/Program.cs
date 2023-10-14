void FillArray(int[] collections)
{
    int length = collections.Length;
    int index = 0;
    while (index < length)
    {
        collections[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int positions = 0;
    while(positions < count)
    {
        Console.Write($"{col[positions]} ");
        positions++;
    }
}

int IndexOff(int[] collections, int find)
{
    int count = collections.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collections[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Создание нового массива с количеством заданным кол-вом элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 404);

Console.WriteLine(pos);

