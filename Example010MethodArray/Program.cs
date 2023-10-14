int[] array = { 20, 12, 31, 4, 18, 16, 17, 18 }; // Создание массива

/*
Array.Sort(array);

foreach (int n in array)
    Console.Write($"{n} ");
*/

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}