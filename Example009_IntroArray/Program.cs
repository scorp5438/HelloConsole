int Max(int num1, int num2, int num3) // Определили функцию, которая находит наибольшее число из трех
{
    int result = num1;
    if(num2 > result) result = num2;
    if(num3 > result) result = num3;
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
            Max(array[0], array[1], array[2]),  // 31
            Max(array[3], array[4], array[5]),  // 61
            Max(array[6], array[7], array[8])); // 81 max

Console.WriteLine(result);