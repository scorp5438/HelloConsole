﻿// Вид 1 

// void method1()
// {
//     System.Console.WriteLine("Avtor");
// }


// Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текстовое сообщение");


//*******************************************************************************************

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; // Ctrl + C Остановка бесконечного цикла
//     }
// }
// Method21(msg: "Текст", count: 4);


// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year - 16);


// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "x");
// Console.WriteLine(res);


//*******************************************************************************************

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "x");
// Console.WriteLine(res);


//*******************************************************************************************

// int x = 1;
// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {   
//         Console.SetCursorPosition(x, j-1);
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     x += 13;
// }


//*******************************************************************************************

// string text = "- Я думаю, - сказал князь, улабаясь, что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             +"вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю:";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + newValue;
//         else result = result + text[i];
//     }
//     return result;
// }

// string NewText = Replace(text, ' ', '|');
// Console.WriteLine(NewText);
// Console.WriteLine();

// NewText = Replace(NewText, 'к', 'К');
// Console.WriteLine(NewText);
// Console.WriteLine();

// NewText = Replace(NewText, 'с', 'С');
// Console.WriteLine(NewText);


//*******************************************************************************************

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i <array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSort2(int[] array)
{
    for (int i = 0; i <array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
SelectionSort2(arr);
PrintArray(arr);