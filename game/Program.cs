﻿// using System.ComponentModel;

// Console.CursorVisible = false;
// char [,] map = 
// {
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', '#'},
//     {'#', ' ', '#', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', 'X', '#', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', '#'},
//     {'#', ' ', ' ', ' ', 'X', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };


// int userX = 6, userY = 6;
// char[] bag = new char[1];
// bool isOpen = true;
// while(isOpen)
// {   Console.SetCursorPosition(0, 20);
//     Console.Write("Сумка: ");
//     for (int i = 0; i < bag.Length; i++)
//     {
//         Console.Write(bag[i] + " ");
//     }

//     Console.SetCursorPosition(0, 0);
//     for (int i = 0; i < map.GetLength(0); i++)
//     {
//         for (int j = 0; j < map.GetLength(1); j++)
//         {
//             Console.Write(map[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.SetCursorPosition(userY, userX);
//     Console.WriteLine('@');
//     ConsoleKeyInfo charKey = Console.ReadKey();
//     switch(charKey.Key)
//     {
//         case ConsoleKey.UpArrow:
//             if (map[userX -1, userY] != '#')
//             {
//                 userX--;
//             }
//             break;
//         case ConsoleKey.DownArrow:
//             if (map[userX + 1, userY] != '#')
//             {
//                 userX++;
//             }
//             break;
//         case ConsoleKey.LeftArrow:
//             if (map[userX, userY - 1] != '#')
//             {
//                 userY--;
//             }
//             break;
//         case ConsoleKey.RightArrow:
//             if (map[userX, userY + 1] != '#')
//             {
//                 userY++;
//             }
//             break;
//         case ConsoleKey.Escape:
//             isOpen = false;
//             break;
//     }
//     if (map[userX, userY] == 'X')
//     {
//         map[userX, userY] = 'O';
//         char[] tempBag = new char[bag.Length + 1];
//         for (int i = 0; i < bag.Length; i++)
//         {
//             tempBag[i] = bag[i];
//         }
//         tempBag[tempBag.Length - 1] = 'X';
//         bag = tempBag;
//     }
//     Console.Clear();
// }


// ************************************************************************************************************************************************

// using System.ComponentModel;

// Console.CursorVisible = false;
// char [,] map = 
// {
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };

// char [,] oShape = 
// {
//     {'@', '@'},
//     {'@', '@'},
// };

// char [,] iShape = 
// {
//     {' ', '@', ' ', ' '},
//     {' ', '@', ' ', ' '},
//     {' ', '@', ' ', ' '},
//     {' ', '@', ' ', ' '},
// };

// char [,] lShape = 
// {
//     {' ', ' ', ' '},
//     {'@', '@', '@'},
//     {'@', ' ', ' '},
// };

// char [,] jShape = 
// {
//     {' ', ' ', ' '},
//     {'@', '@', '@'},
//     {' ', ' ', '@'},
// };

// char [,] zShape = 
// {
//     {' ', ' ', ' '},
//     {'@', '@', ' '},
//     {' ', '@', '@'},
// };

// char [,] sShape = 
// {
//     {' ', ' ', ' '},
//     {' ', '@', '@'},
//     {'@', '@', ' '},
// };

// char [,] tShape = 
// {
//     {' ', ' ', ' '},
//     {'@', '@', '@'},
//     {' ', '@', ' '},
// };

// int number = new Random().Next(1, 8);
// switch(number)
// {
//     case 1:
//         drow(iShape);
//         break;
//     case 2:
//         drow(jShape);
//         break;
//     case 3:
//         drow(lShape);
//         break;
//     case 4:
//         drow(oShape);
//         break;
//     case 5:
//         drow(zShape);
//         break;
//     case 6:
//         drow(tShape);
//         break;
//     case 7:
//         drow(sShape);
//         break;
// }

// int userX = 5, userY = 5;
// char[] bag = new char[1];
// bool isOpen = true;
// while(isOpen)
// {   
//     Console.SetCursorPosition(0, 20);
//     Console.Write("Сумка: ");
//     for (int i = 0; i < bag.Length; i++)
//     {
//         Console.Write(bag[i] + " ");
//     }
//     Console.SetCursorPosition(0, 5);
//     for (int i = 0; i < map.GetLength(0); i++)
//     {
//         for (int j = 0; j < map.GetLength(1); j++)
//         {
//             Console.Write(map[i, j]);
//         }
//         Console.WriteLine();
//     }

//     Console.SetCursorPosition(userY, userX);
//     drow(sqwr, userX, userY);
//     ConsoleKeyInfo charKey = Console.ReadKey();
//     switch(charKey.Key)
//     {
//         case ConsoleKey.UpArrow:
//             if (map[userX - 1, userY] != '#')
//             {
//                 userX--;
//             }
//             break;
//         case ConsoleKey.DownArrow:
//             if (map[userX + 1, userY] != '#')
//             {
//                 userX++;
//             }
//             break;
//         case ConsoleKey.LeftArrow:
//             if (map[userX, userY - 1] != '#')
//             {
//                 userY--;
//             }
//             break;
//         case ConsoleKey.RightArrow:
//             if (map[userX, userY + 1] != '#')
//             {
//                 userY++;
//             }
//             break;
//         case ConsoleKey.Escape:
//             isOpen = false;
//             break;
//     }
//     if (map[userX, userY] == 'X')
//     {
//         map[userX, userY] = 'O';
//         char[] tempBag = new char[bag.Length + 1];
//         for (int i = 0; i < bag.Length; i++)
//         {
//             tempBag[i] = bag[i];
//         }
//         tempBag[tempBag.Length - 1] = 'X';
//         bag = tempBag;
//     }
//     Console.Clear();
// }

// void drow (char [,] arr, int x = 0, int y = 0)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j]);
//         }
//         Console.SetCursorPosition(y, x + 1);
//     }
// }


// ********************************************************************************************************************************


Console.CursorVisible = false;

char [,] map = 
{
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
};

char [,] oShape =
{
    {'@', '@'},
    {'@', '@'},
};

while (true)
{   

    int elemX = 1, elemY = new Random().Next(20);
    drowMap (map);


    while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#')
    {
        drowMap (map);
        Console.SetCursorPosition(elemY, elemX);
        drowElem(oShape, elemX, elemY);
        Thread.Sleep(200); 
        elemX++;
    }
    map[elemX - 1, elemY] = '#';
    map[elemX - 1, elemY + 1] = '#';
    map[elemX, elemY] = '#';
    map[elemX, elemY + 1] = '#';

}

void drowMap (char[,] arr)
{
    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
    }
}

void drowElem (char[,] arr, int x, int y)
{
    Console.SetCursorPosition(y, x);
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.SetCursorPosition(y, x + 1);
    }
}