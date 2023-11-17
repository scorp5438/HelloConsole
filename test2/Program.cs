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

char [,] lShape = 
{
    {' ', ' ', ' '},
    {'#', '#', '#'},
    {'#', ' ', ' '},
};

char [,]lShapeV2 = 
{
    {'#', '#', ' '},
    {' ', '#', ' '},
    {' ', '#', ' '}
};

char [,] lShapeV3 = 
{
    {' ', ' ', '#'},
    {'#', '#', '#'},
    {' ', ' ', ' '},
};

char [,]lShapeV4 = 
{
    {' ', '#', ' '},
    {' ', '#', ' '},
    {' ', '#', '#'}
};

char [,] tShape = 
{
    {' ', ' ', ' '},
    {'#', '#', '#'},
    {' ', '#', ' '},
};

char [,] iShape = 
{
    {' ', ' ', ' '},
    {' ', '#', '#'},
    {'#', '#', ' '},
};

// char [,] iShape = 
// {
//     {' ', '#', ' ', ' '},
//     {' ', '#', ' ', ' '},
//     {' ', '#', ' ', ' '},
//     {' ', '#', ' ', ' '},
// };

char [,] iShape2 = 
{
    {' ', ' ', ' ', ' '},
    {'#', '#', '#', '#'},
    {' ', ' ', ' ', ' '},
    {' ', ' ', ' ', ' '},
};

bool isOpen = true;
bool isGame = true;
bool contact = true;
int elemX = 1, elemY = 10;
int number = 1;

Task task = Task.Run(() =>
    {
        while (isOpen)
        {
            while (isGame)
            {
                contact = true;
                switch (number)
                {
                    case 1:
                        while (contact)
                        {
                            Console.Clear();
                            drowMap(map);
                            drowElem(iShape, elemX, elemY);
                            CheckTouch(map, iShape, elemX, elemY);
                            // for (int i = 0; i < iShape.GetLength(1); i++)
                            // {
                            //     if (iShape[2, i] == '#')
                            //     {
                            //         if (map[elemX + 4, elemY + i] == '#')
                            //         {
                            //             contact = false;
                            //         }
                            //     }
                            //     else if (iShape[1, i] == '#')
                            //     {
                            //         if (map[elemX + 3, elemY + i] == '#')
                            //         {
                            //             contact = false;
                            //         }
                            //     }
                            //     else if (iShape[0, i] == '#')
                            //     {
                            //         if (map[elemX + 2, elemY + i] == '#')
                            //         {
                            //             contact = false;
                            //         }
                            //     }
                            // }
                            
                            Console.SetCursorPosition(elemY, elemX);
                            
                            elemX++;
                            Thread.Sleep(300);
                            
                        }
                        DrowElemToDown(iShape, elemY, elemX);
                        drowMap(map);
                        // map[elemX - 1, elemY] = '#';
                        // map[elemX - 1, elemY + 1] = '#';
                        // map[elemX, elemY] = '#';
                        // map[elemX, elemY + 1] = '#';

                        elemX = 1;
                        elemY = 10;
                        for (int i = 1; i < map.GetLength(0); i++)
                        {
                            if (map[1, i] == '#') isGame = false;
                        }
                        int row = 10;
                        while (row > 0)
                        {
                            check(map);
                            row--;
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }
    });

while (isOpen)
{
    ConsoleKeyInfo charKey = Console.ReadKey();
    switch (charKey.Key)
    {
        case ConsoleKey.LeftArrow:
            if (map[elemX, elemY - 1] != '#' || map[elemX + 2, elemY - 1] != '#')
            {
                elemY--;
            }
            break;
        case ConsoleKey.RightArrow:
            if (map[elemX, elemY + 3] != '#'  || map[elemX + 2, elemY + 3] != '#')
            {
                elemY++;
            }
            break;
        // case ConsoleKey.Spacebar:
        //     if (map[elemX, elemY + 3] != '#')
        //     {   
        //         number += 10;

        // if (number > 31) number = 1;
        //     }
        //     break;
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

void CheckTouch (char[,] map, char[,] element, int elemX, int elemY)
{
    for (int i = 0; i < element.GetLength(0); i++)
    {
        if (element[2, i] == '#')
        {
            if (map[elemX + 4, elemY + i] == '#')
            {
                contact = false;
            }
        }
        else if (element[1, i] == '#')
        {
            if (map[elemX + 3, elemY + i] == '#')
            {
                contact = false;
            }
        }
        else if (element[0, i] == '#')
        {
            if (map[elemX + 2, elemY + i] == '#')
            {
                contact = false;
            }
        }
    }
}