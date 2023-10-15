int count = new Random().Next(8, 12);
int[] array = new int[count];
// Создание массива через метод void
void CreateArray(int[] array, int count) // void название метода, параметры, которые принимает метод
{   
    int index = 0;
    while(index < count)
    {
        int value = new Random().Next(-10, 11);
        array[index] = value;
        index += 1;
    }
    
}
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
// Вывод массива через функцию void и цикл while
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
// Функция для поиска максимума в массиве
int MaxNum(int[] array, int count)
{
    int index = 1;
    int result = array[0]; 
    
    while(index < count)
    {   
        if(array[index] > result)
        {
            result = array[index];
        }
        index += 1;
    }
    return result;
}

double Average(int[] array, int count)
{
    int index = 0;
    double sum = 0;
    while(index < count)
    {
        sum += array[index];
        index++;
    }
    double result = sum / count;
    return result;
}

CreateArray(array, count);
SortArray(array);
PrintArray(array);
Console.WriteLine();

Array.Sort(array); // Сортировка массива, через встроенный метод Array.Sort(Название массива);

// Вывод массива через цикл for
for (int n = 0; n < array.Length; n++)
{
    Console.Write($"{array[n]} ");
}

// foreach(int n in array)
// {
//     Console.Write($"{array[n]} ");
// }

// Нахождение максимального значения массива, через встроенный название массива.Min() Метод Max, работает аналонично;
Console.WriteLine($"\n\nМинимальное число массива: {array.Min()}");

int max = MaxNum(array, count);
Console.WriteLine($"\nМаксимальное число масива: {max}");

double avg = Average(array, count);

Console.WriteLine($"\nСреднее арифметическое значений массива: {avg}");

Console.WriteLine($"Среднее арифметическое значений массива: {array.Average()}");