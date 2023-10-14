int Max(int arg1, int arg2, int arg3) // Определили функцию, которая находит наибольшее число из трех
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int [] array = {11, 21, 31, 41, 15, 61, 17, 81, 19};
array[0] = 12;

// int max = array.Max();

/*
Присваиваем результат функции переменной.
В функцию передаем три вызова этой же функции
*/
int result = Max(
            Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]), 
            Max(array[6], array[7], array[8])); 

Console.WriteLine(result);