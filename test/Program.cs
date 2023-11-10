// Исчезновение линий

char[,] map = 
{
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',}, // индекс 0
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',},
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',},
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',},
    { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',},
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
    { '#', '#', '#', ' ', ' ', ' ', '#', '#', ' ', '#', '#', ' ', ' ', '#',},
    { '#', '#', '#', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', '#',},
    { '#', '#', '#', '#', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#',},
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
    { '#', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', '#',},
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
    { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},  // индекс 13
};

void drowMap(char[,] arr)
{
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
        }
        Console.WriteLine();
    }
}

int row = 10;

while(row > 0)
{
    check(map);
    row--;
}

void check (char[,] arr)
{
    int row = 0;
    int count = 0;
    for (int i = 1; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < arr.GetLength(1) - 1; j++)
        {
            if (arr[i, j] == '#')
            {
                count++;
                if (count == 12)
                {
                    row = i;
                }
            }
        }
        count = 0;
    }
    chenge(map, row);
}


chenge(map, row);
void chenge(char[,] arr, int x)
{
    for (int i = x; i > 1; i--)
    {
        for (int j = 1; j < arr.GetLength(1) - 1; j++)
        {
            arr[i, j] = arr[i - 1, j];
        }
    }
}

Console.WriteLine();
drowMap(map);

// ****************************************************************************************************************************************
// ****************************************************************************************************************************************

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
//     {'#', '#'},
//     {'#', '#'},
// };

// // char [,] iShape = 
// // {
// //     {'#'},
// //     {'#'},
// //     {'#'},
// //     {'#'},
// // };

// char [,] lShape = 
// {

//     {'#', '#', '#'},
//     {'#', ' ', ' '},
// };

// // char [,] jShape = 
// // {

// //     {'#', '#', '#'},
// //     {' ', ' ', '#'},
// // };

// // char [,] zShape = 
// // {

// //     {'#', '#', ' '},
// //     {' ', '#', '#'},
// // };

// // char [,] sShape = 
// // {

// //     {' ', '#', '#'},
// //     {'#', '#', ' '},
// // };

// // char [,] tShape = 
// {

//     {'#', '#', '#'},
//     {' ', '#', ' '},
// };

// int elemX = 1, elemY = 10;
// int nextEx = 4, nextEy = 30;

// bool isOpen = true;

// while(isOpen)
// {   
//     Console.CursorVisible = false;
//     // int number = new Random().Next(1, 8);
//     int number = 1;
//     Console.SetCursorPosition(30, 1);
//     Console.WriteLine("Score: ");
//     Console.SetCursorPosition(30, 2);
//     Console.WriteLine($"{number}");

//     Console.SetCursorPosition(nextEy, nextEx);
//     drowElem(lShape, nextEx, nextEy);

//     switch (number)
//     {
//         case 1:
  
//             Console.SetCursorPosition(35, 5);
//             Console.WriteLine("Функция 1");

//             drowMap(map);
//             ConsoleKeyInfo charKey = Console.ReadKey();
//             while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#')
//             {
//                 drowMap(map);
//                 Console.SetCursorPosition(elemY, elemX);
//                 drowElem(oShape, elemX, elemY);
//                 Thread.Sleep(1000);
//                 elemX++;

                
//                 switch (charKey.Key)
//                 {
//                     case ConsoleKey.LeftArrow:
//                         if (map[elemX, elemY - 1] != '#')
//                         {
//                             elemY--;
//                         }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         if (map[elemX, elemY + 2] != '#')
//                         {
//                             elemY++;
//                         }
//                         break;
//                     case ConsoleKey.Escape:
//                         isOpen = false;
//                         break;

//                         Console.Clear();
//                 }
//             }

//             map[elemX - 1, elemY] = '#';
//             map[elemX - 1, elemY + 1] = '#';
//             map[elemX, elemY] = '#';
//             map[elemX, elemY + 1] = '#';
//             break;
//             // default:
//             //     break;
//             // case 2:
//             //     Console.WriteLine(123);
//             //     break;
//             // // case 3:
//             //     drowElem(lShape);
//             //     break;
//             // case 4:
//             //     drowElem(oShape);
//             //     break;
//             // case 5:
//             //     drowElem(zShape);
//             //     break;
//             // case 6:
//             //     drowElem(tShape);
//             //     break;
//             // case 7:
//             //     drowElem(sShape);
//             //     break;
//     }


//     // void elem1()
//     // {
//     // Console.SetCursorPosition(35, 5);
//     // Console.WriteLine("Функция 1");

//     // drowMap(map);

//     // while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#')
//     // {
//     //     drowMap(map);
//     //     Console.SetCursorPosition(elemY, elemX);
//     //     drowElem(oShape, elemX, elemY);
//     //     Thread.Sleep(200);
//     //     elemX++;

//     //     ConsoleKeyInfo charKey = Console.ReadKey();

//     //     switch (charKey.Key)
//     //     {
//     //         case ConsoleKey.LeftArrow:
//     //             if (map[elemX, elemY - 1] != '#')
//     //             {
//     //                 elemY--;
//     //             }
//     //             break;
//     //         case ConsoleKey.RightArrow:
//     //             if (map[elemX, elemY + 2] != '#')
//     //             {
//     //                 elemY++;
//     //             }
//     //             break;
//     //         case ConsoleKey.Escape:
//     //             isOpen = false;
//     //             break;

//     //             Console.Clear();
//     //     }
//     // }

//     // map[elemX - 1, elemY] = '#';
//     // map[elemX - 1, elemY + 1] = '#';
//     // map[elemX, elemY] = '#';
//     // map[elemX, elemY + 1] = '#';
//     // }
//     Console.SetCursorPosition(38, 10);
//     Console.WriteLine(123);


//     drowMap(map);
    
// }

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
//             Console.SetCursorPosition(y, x + 1);
//     }
// }

