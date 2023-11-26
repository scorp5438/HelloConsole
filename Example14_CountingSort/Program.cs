// Сортировка подсчетом

int[] array = { 1001, 100, 1001, 102};

Console.WriteLine($"[{String.Join(", ", array)}]\n");

// void CountingSort(int[] inputArray)
// {
//     int[] counters = new int[10];
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         counters[inputArray[i]]++;
//         // int ourNumber = inputArray[i];
//         // counters[ourNumber]++;
//     }
//     int index = 0;
//     for (int i = 0; i < counters.Length; i++)
//     {
//         for (int j = 0; j < counters[i]; j++)
//         {
//             inputArray[index] = i;
//             index++;
//         }
//     }
// }

void CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];
    
    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
        // int ourNumber = inputArray[i];
        // counters[ourNumber]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

CountingSortExtended(array);

Console.WriteLine($"[{String.Join(", ", array)}]");