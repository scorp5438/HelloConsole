int a = 151;
int b = 45;
int c = 75;
int d = 78;
int e = 35;
int f = 55;
int g = 69;
int h = 93;
int j = 45;

int Max(int arg1, int arg2, int arg3) // Определили функцию, которая находит наибольшее число из трех

{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

/*
Присваиваем результат функции переменной.
В функцию передаем три вызова этой же функции
*/

int max = Max(
            Max(a, b, c),
            Max(d, e, f), 
            Max(g, h, j)); 

Console.WriteLine(max);