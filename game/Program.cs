using System.ComponentModel;

Console.CursorVisible = false;
char [,] map = 
{
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', '#'},
    {'#', ' ', '#', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', 'X', '#', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', '#'},
    {'#', ' ', ' ', ' ', 'X', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
};


int userX = 6, userY = 6;
char[] bag = new char[1];
bool isOpen = true;
while(isOpen)
{   Console.SetCursorPosition(0, 20);
    Console.Write("Сумка: ");
    for (int i = 0; i < bag.Length; i++)
    {
        Console.Write(bag[i] + " ");
    }

    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.Write(map[i, j]);
        }
        Console.WriteLine();
    }
    Console.SetCursorPosition(userY, userX);
    Console.WriteLine('@');
    ConsoleKeyInfo charKey = Console.ReadKey();
    switch(charKey.Key)
    {
        case ConsoleKey.UpArrow:
            if (map[userX -1, userY] != '#')
            {
                userX--;
            }
            break;
        case ConsoleKey.DownArrow:
            if (map[userX + 1, userY] != '#')
            {
                userX++;
            }
            break;
        case ConsoleKey.LeftArrow:
            if (map[userX, userY - 1] != '#')
            {
                userY--;
            }
            break;
        case ConsoleKey.RightArrow:
            if (map[userX, userY + 1] != '#')
            {
                userY++;
            }
            break;
        case ConsoleKey.Escape:
            isOpen = false;
            break;
    }
    if (map[userX, userY] == 'X')
    {
        map[userX, userY] = 'O';
        char[] tempBag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempBag[i] = bag[i];
        }
        tempBag[tempBag.Length - 1] = 'X';
        bag = tempBag;
    }
    Console.Clear();
}


// ************************************************************************************************************************************************
// ************************************************************************************************************************************************


// Console.CursorVisible = false;
// char [,] map = 
// {
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };

// char [,] oShape = 
// {
//     {'#', '#',},
//     {'#', '#',},
// };

// char [,] iShape = 
// {
//     {' ', '#', ' ', ' '},
//     {' ', '#', ' ', ' '},
//     {' ', '#', ' ', ' '},
//     {' ', '#', ' ', ' '},
// };

// char [,] lShape = 
// {

//     {' ', ' ', ' '},
//     {'#', '#', '#'},
//     {'#', ' ', ' '},
// };

// char [,] jShape = 
// {
//     {' ', ' ', ' '},
//     {'#', '#', '#'},
//     {' ', ' ', '#'},
// };

// char [,] zShape = 
// {

//     {' ', ' ', ' '},
//     {'#', '#', ' '},
//     {' ', '#', '#'},
// };

// char [,] sShape = 
// {
//     {' ', ' ', ' '},
//     {' ', '#', '#'},
//     {'#', '#', ' '},
// };

// char [,] tShape = 
// {
//     {' ', ' ', ' '},
//     {'#', '#', '#'},
//     {' ', '#', ' '},
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

// int userX = 3, userY = 5;

// bool isOpen = true;
// bool touch = true;
// while(isOpen)
// {   
//     Console.SetCursorPosition(30, 1);
//     Console.WriteLine("Score: ");

//     Console.SetCursorPosition(0, 0);
//     for (int i = 0; i < map.GetLength(0); i++)
//     {
//         for (int j = 0; j < map.GetLength(1); j++)
//         {
//             Console.Write(map[i, j]);
//         }
//         Console.WriteLine();
//     }
// char [,] zShape2 = 
// {
//     {'#', '#', '#'},
//     {'#', '#', '#'},
// };

//     Console.SetCursorPosition(userY, userX);
//     drow(zShape2, userX, userY);
//     ConsoleKeyInfo charKey = Console.ReadKey();
//     touch = true;
//     switch(charKey.Key)
//     {
//         case ConsoleKey.UpArrow:
//             if (map[userX, userY] != '#' || map[userX, userY + 1] != '#')
//             {
//                 userX--;
//             }
//             break;
//         case ConsoleKey.DownArrow:
//             CheckTouchDown(map, zShape2, userX, userY);
//             if(touch) userX++;
//             // if (map[userX + 3, userY] != '#' || map[userX + 3, userY + 1] != '#')
//             // {
//             //     userX++;
//             // }
//             break;
//         case ConsoleKey.LeftArrow:
//             CheckTouchLeft(map, zShape2, userX, userY);
//             if(touch) userY--;
//             // if (map[userX, userY - 1] != '#')
//             // {
//             //     userY--;
//             // }
//             break;
//         case ConsoleKey.RightArrow:
//             CheckTouchRight(map, zShape2, userX, userY);
//             if (touch) userY++;
//             // if (map[userX, userY + 2] != '#')
//             // {
//             //     userY++;
//             // }
//             break;
//         case ConsoleKey.Escape:
//             isOpen = false;
//             break;
//     }

//     Console.Clear();
// }

// char [,] oShape2 = 
// {
//     {'#', '#', ' '},
//     {' ', '#', '#'},
// };

// void drow (char [,] arr, int x = 0, int y = 0)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j]);
//         }
//         Console.SetCursorPosition(y, x + 1 + i);
//     }
// }

// void CheckTouchRight(char[,] map, char[,] element, int elemX, int elemY)
// {
//     for (int i = 0; i < element.GetLength(0); i++)
//     {
//         for (int j = element.GetLength(1) - 1; j >= 0; j--)
//         {
//             if (element[i, j] == '#')
//             {
//                 if (map[elemX + i, elemY + j + 1] == '#')
//                 {
//                     touch = false;
//                 }
//             }
//         }
//         // Развернутый код
//         // if (element[i, 2] == '#')
//         // {
//         //     if (map[elemX + i, elemY + 3] == '#')
//         //     {
//         //         touch = false;
//         //     }
//         // }
//         // else if (element[i, 1] == '#')
//         // {
//         //     if (map[elemX + i, elemY + 2] == '#')
//         //     {
//         //         touch = false;
//         //     }
//         // }
//         // else if (element[i, 0] == '#')
//         // {
//         //     if (map[elemX + i, elemY + 1] == '#')
//         //     {
//         //         touch = false;
//         //     }
//         // }
//     }
// }

// void CheckTouchLeft (char[,] map, char[,] element, int elemX, int elemY)
// {
//     for (int i = 0; i < element.GetLength(1); i++)
//     {
//         for (int j = 0; j < element.GetLength(0); j++)
//         {
//             if (element[j, i] == '#')
//             {
//                 if (map[elemX + j, elemY + (i - 1)] == '#')
//                 {
//                     touch = false;
//                 }
//             }
//         }
//     // if (element[0, 0] == '#')
//     // {
//     //     if (map[elemX, elemY - 1] == '#')
//     //     {
//     //         touch = false;
//     //     }
//     // }
//     // if (element[1, 0] == '#')
//     // {
//     //     if (map[elemX + 1, elemY - 1] == '#')
//     //     {
//     //         touch = false;
//     //     }
//     // }
//     // if (element[0, 1] == '#')
//     // {
//     //     if (map[elemX, elemY] == '#')
//     //     {
//     //         touch = false;
//     //     }
//     // }
//     // if (element[1, 1] == '#')
//     // {
//     //     if (map[elemX + 1, elemY] == '#')
//     //     {
//     //         touch = false;
//     //     }
//     // }
//     // if (element[0, 2] == '#')
//     // {
//     //     if (map[elemX, elemY + 1] == '#')
//     //     {
//     //         touch = false;
//     //     }
//     // }
//     // if (element[1, 2] == '#')
//     // {
//     //     if (map[elemX + 1, elemY + 1] == '#')
//     //     {
//     //         touch = false;
//     //     }
//     // }
//     }
// }

// void CheckTouchDown (char[,] map, char[,] element, int elemX, int elemY)
// {
//     for (int i = 0; i < element.GetLength(1); i++)
//     {
//         for (int j = element.GetLength(0) - 1; j > 0; j--)
//         {
//             if (element[j, i] == '#')
//             {
//                 if (map[elemX + j + 1, elemY + i] == '#')
//                 {
//                     touch = false;
//                 }
//             }
//         }
//     }
// }
// // ********************************************************************************************************************************
// // ********************************************************************************************************************************

// Console.CursorVisible = false;

// char [,] map = 
// {
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
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };

// char [,] oShape =
// {
//     {'#', '#'},
//     {'#', '#'},
// };

// char [,] zShape =
// {
//     {' ', ' ', ' '},
//     {'#', '#', ' '},
//     {' ', '#', '#'},
// };

// char [,] tShape =
// {
//     {' ', ' ', ' '},
//     {'#', '#', '#'},
//     {' ', '#', ' '},
// };

// char [,] jShape =
// {
//     {' ', ' ', ' '},
//     {'#', '#', '#'},
//     {' ', ' ', '#'},
// };

// while (map[0, 10] != '#')
// {   
//     int elemX = 1, elemY = 10;
//     drowMap (map);

//     while (map[elemX + 2, elemY] != '#' && map[elemX + 2, elemY + 1] != '#')
//     {
//         drowMap (map);
//         Console.SetCursorPosition(elemY, elemX);
//         drowElem(jShape, elemX, elemY);
//         Thread.Sleep(200); 
//         elemX++;
//     }
//     // PrintPosition (zShape, elemX, elemY);
//     DrowElemToDown(jShape, elemY, elemX);
//     drowMap(map);

//     // map[elemX - 1, elemY] = '#';
//     // map[elemX - 1, elemY + 1] = '#';
//     // map[elemX, elemY] = '#';
//     // map[elemX, elemY + 1] = '#';
// }

// // int elemX = 3, elemY = 10;
// // DrowElemToDown(tShape, elemX, elemY);
// drowMap(map);

// void drowMap (char[,] arr)
// {
//     Console.SetCursorPosition(0, 0);
//     for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write(arr[i, j]);
//             }
//             Console.WriteLine();
//     }
// }

// void drowElem (char[,] arr, int x, int y)
// {
//     Console.SetCursorPosition(y, x);
//     for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write(arr[i, j]);
//             }
//             Console.SetCursorPosition(y, x + 1 + i);
//     }
// }

// void DrowElemToDown(char[,] elem, int elemX, int elemY)
// {
//     int tempX = elemX;
//     Console.SetCursorPosition(elemX, elemY + 1);
//     for (int i = 0; i < elem.GetLength(0); i++)
//     {
//         for (int j = 0; j < elem.GetLength(1); j++)
//         {
//             map[elemY, elemX] = elem[i, j];
//             elemX++;
//         }
//         Console.WriteLine();
//         elemX = tempX;
//         elemY++;
//     }
// }
