Console.CursorVisible = false;

char[,] map =
{
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
    {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
};

char [,] oShape = 
{   
    {'#', '#'},
    {'#', '#'},
};

char [,] iShape = 
{
    {'#'},
    {'#'},
    {'#'},
    {'#'},
};

char [,] iShape2 = 
{
    {' ', ' ', ' ', ' '},
    {'#', '#', '#', '#'},
};

char [,] lShape = 
{
    {' ', ' ', ' '},
    {'#', '#', '#'},
    {'#', ' ', ' '},
};

char [,] jShape = 
{
    {' ', ' ', ' '},
    {'#', '#', '#'},
    {' ', ' ', '#'},
};

char [,] zShape = 
{
    {' ', ' ', ' '},
    {'#', '#', ' '},
    {' ', '#', '#'},
};

char [,] sShape = 
{
    {' ', ' ', ' '},
    {' ', '#', '#'},
    {'#', '#', ' '},
};

char [,] tShape = 
{
    {' ', ' ', ' '},
    {'#', '#', '#'},
    {' ', '#', ' '},
};

// // int number = new Random().Next(1, 8);
// switch (number)
// {
//     case 1:
//         Shape = oShape;
//         break;
//     case 2:
//         Shape = iShape;
//         break;
//     case 3:
//         Shape = lShape;
//         break;
//     case 4:
//         Shape = jShape;
//         break;
//     case 5:
//         Shape = zShape;
//         break;
//     case 6:
//         Shape = sShape;
//         break;
//     case 7:
//         Shape = tShape;
//         break;
// }

bool isOpen = true;
bool isGame = true;
bool contact = true;
bool LeftTouch = true;
bool RightTouch = true;

int elemX = 0, elemY = 11;
char[,] Shape = iShape2;
int number = 2;

Task task = Task.Run(() =>
{
    while (isOpen)
    {
        while (isGame)
        {
            // int number = new Random().Next(1, 8);
            // switch (number)
            // {
            //     case 1:
            //         Shape = oShape;
            //         break;
            //     case 2:
            //         Shape = iShape;
            //         break;
            //     case 3:
            //         Shape = lShape;
            //         break;
            //     case 4:
            //         Shape = jShape;
            //         break;
            //     case 5:
            //         Shape = zShape;
            //         break;
            //     case 6:
            //         Shape = sShape;
            //         break;
            //     case 7:
            //         Shape = tShape;
            //         break;
            // }
            contact = true;
            LeftTouch = true;
            RightTouch = true;
            // switch (number)
            // {
            //     case 1:
                    while (contact)
                    {
                        if (number == 12) Shape = iShape2;
                        if (number == 2) Shape = iShape;
                        Console.Clear();
                        drowMap(map);
                        drowElem(Shape, elemX, elemY);
                        CheckTouchDown(map, Shape, elemX, elemY);

                        Console.SetCursorPosition(elemY, elemX);

                        elemX++;
                        Thread.Sleep(500);
                    }
                    DrowElemToDown(Shape, elemY, elemX);
                    drowMap(map);
                    elemX = 0;
                    elemY = 10;
                    for (int i = 1; i < map.GetLength(0); i++)
                    {
                        if (map[1, i] == '#')
                        {
                        isGame = false;
                        }
                    }
                    int row = 10;
                    while (row > 0)
                    {
                        check(map);
                        row--;
                    }
                    break;
            // }
        }
    }
});

while (isOpen)
{
    ConsoleKeyInfo charKey = Console.ReadKey();
    switch (charKey.Key)
    {
        case ConsoleKey.LeftArrow:
            CheckTouchLeft(map, Shape, elemX, elemY);
            if (LeftTouch)
            {
                elemY--;
                RightTouch = true;
            }
            break;
        case ConsoleKey.RightArrow:
            CheckTouchRight(map, Shape, elemX, elemY);
            if (RightTouch)
            {
                elemY++;
                LeftTouch = true;
            }
            break;
        case ConsoleKey.Spacebar:
            number += 10;
            if (number > 12) number = 2;
            break;
        case ConsoleKey.Escape:
            isOpen = false;
            break;
    }
}

void drowMap(char[,] arr)
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

void drowElem(char[,] arr, int x, int y)
{

    Console.SetCursorPosition(y, x);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
        }
        Console.SetCursorPosition(y, x + 1 + i);
    }
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
                if (count == map.GetLength(1)-2)
                {
                    row = i;
                }
            }
        }
        count = 0;
    }
    chenge(map, row);
}

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

void DrowElemToDown(char[,] elem, int elemX, int elemY)
{
    int tempX = elemX;
    Console.SetCursorPosition(elemX, elemY + 1);
    for (int i = 0; i < elem.GetLength(0); i++)
    {
        for (int j = 0; j < elem.GetLength(1); j++)
        {
            if (elem[i, j] == '#')
            {
                map[elemY, elemX] = elem[i, j];
            }
            elemX++;
        }
        Console.WriteLine();
        elemX = tempX;
        elemY++;
    }
}

void CheckTouchDown (char[,] map, char[,] element, int elemX, int elemY)
{
    for (int i = 0; i < element.GetLength(1); i++)
    {
        for (int j = element.GetLength(0) - 1; j > 0; j--)
        {
            if (element[j, i] == '#')
            {
                if (map[elemX + j + 2, elemY + i] == '#')
                {
                    contact = false;
                }
            }
        }
        // if (element[2, i] == '#')
        // {
        //     if (map[elemX + 4, elemY + i] == '#')
        //     {
        //         contact = false;
        //     }
        // }
        // else if (element[1, i] == '#')
        // {
        //     if (map[elemX + 3, elemY + i] == '#')
        //     {
        //         contact = false;
        //     }
        // }
        // else if (element[0, i] == '#')
        // {
        //     if (map[elemX + 2, elemY + i] == '#')
        //     {
        //         contact = false;
        //     }
        // }
    }
}

void CheckTouchRight(char[,] map, char[,] element, int elemX, int elemY)
{
    for (int i = 0; i < element.GetLength(0); i++)
    {
        for (int j = element.GetLength(1) - 1; j >= 0; j--)
        {
            if (element[i, j] == '#')
            {
                if (map[elemX + i, elemY + j + 1] == '#')
                {
                    RightTouch = false;
                    LeftTouch = true;
                }
            }
        }
    }
}

void CheckTouchLeft (char[,] map, char[,] element, int elemX, int elemY)
{
    for (int i = 0; i < element.GetLength(1); i++)
    {
        for (int j = 0; j < element.GetLength(0); j++)
        {
            if (element[j, i] == '#')
            {
                if (map[elemX + j, elemY + (i - 1)] == '#')
                {
                    LeftTouch = false;
                    RightTouch = true;
                }
            }
        }
    }
}