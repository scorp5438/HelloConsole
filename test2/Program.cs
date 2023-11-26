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
char [,] lShape2 = 
{
    {'#', '#', ' '},
    {' ', '#', ' '},
    {' ', '#', ' '},
};
char [,] lShape3 = 
{
    {' ', ' ', '#'},
    {'#', '#', '#'},
    {' ', ' ', ' '},
};
char [,] lShape4 = 
{
    {' ', '#', ' '},
    {' ', '#', ' '},
    {' ', '#', '#'},
};

char [,] jShape = 
{
    {' ', ' ', ' '},
    {'#', '#', '#'},
    {' ', ' ', '#'},
};
char [,] jShape2 = 
{
    {' ', '#', ' '},
    {' ', '#', ' '},
    {'#', '#', ' '},
};
char [,] jShape3 = 
{
    {'#', ' ', ' '},
    {'#', '#', '#'},
    {' ', ' ', ' '},
};
char [,] jShape4 = 
{
    {' ', '#', '#'},
    {' ', '#', ' '},
    {' ', '#', ' '},
};

char [,] zShape = 
{
    {' ', ' ', ' '},
    {'#', '#', ' '},
    {' ', '#', '#'},
};
char [,] zShape2 = 
{
    {' ', '#', ' '},
    {'#', '#', ' '},
    {'#', ' ', ' '},
};
char [,] sShape = 
{
    {' ', ' ', ' '},
    {' ', '#', '#'},
    {'#', '#', ' '},
};
char [,] sShape2 = 
{
    {' ', '#', ' '},
    {' ', '#', '#'},
    {' ', ' ', '#'},
};

char [,] tShape = 
{
    {' ', ' ', ' '},
    {'#', '#', '#'},
    {' ', '#', ' '},
};
char [,] tShape2 = 
{
    {' ', '#', ' '},
    {'#', '#', ' '},
    {' ', '#', ' '},
};
char [,] tShape3 = 
{
    {' ', '#', ' '},
    {'#', '#', '#'},
    {' ', ' ', ' '},
};
char [,] tShape4 = 
{
    {' ', '#', ' '},
    {' ', '#', '#'},
    {' ', '#', ' '},
};



bool isOpen = true;
bool isGame = true;
bool contact = true;
bool LeftTouch = true;
bool RightTouch = true;
int score = 0; 
int elemX = 0, elemY = 11;
char[,] Shape = iShape2;

int number = new Random().Next(1, 8);
int nextNumber = new Random().Next(1, 8);
int [] elems = new int[2];
elems[0] = number;
elems[1] = nextNumber;
Task task = Task.Run(() =>
{
    while (isOpen)
    {
        while (isGame)
        {
            contact = true;
            LeftTouch = true;
            RightTouch = true;

            number = elems[0];
            elems[0] = new Random().Next(1, 8);
            elems[1] = new Random().Next(1, 8);
            switch (number)
            {
                case 1:
                    Shape = oShape;
                    break;
                case 2:
                    Shape = iShape;
                    break;
                case 3:
                    Shape = lShape;
                    break;
                case 4:
                    Shape = jShape;
                    break;
                case 5:
                    Shape = zShape;
                    break;
                case 6:
                    Shape = sShape;
                    break;
                case 7:
                    Shape = tShape;
                    break;
            }
            while (contact)
            {
                if (number == 12) Shape = iShape2;
                else if (number == 2) Shape = iShape;
                else if (number == 13) Shape = lShape2;
                else if (number == 23) Shape = lShape3;
                else if (number == 33) Shape = lShape4;
                else if (number == 3) Shape = lShape;
                else if (number == 14) Shape = jShape2;
                else if (number == 24) Shape = jShape3;
                else if (number == 34) Shape = jShape4;
                else if (number == 4) Shape = jShape;
                else if (number == 15) Shape = zShape2;
                else if (number == 5) Shape = zShape;
                else if (number == 16) Shape = sShape2;
                else if (number == 6) Shape = sShape;
                else if (number == 17) Shape = tShape2;
                else if (number == 27) Shape = tShape3;
                else if (number == 37) Shape = tShape4;
                else if (number == 7) Shape = tShape;
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

        }
    }
});

while (isOpen)
{   
    Console.SetCursorPosition(30, 1);
    Console.WriteLine($"Score: {score}");

    Console.SetCursorPosition(30, 3);
    Console.WriteLine($"Next elem:");
    Console.SetCursorPosition(30, 5);
    drowElem(Shape, 5, 30);

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
            if (number % 10 == 2)
            {
                number += 10;
                if (number == 22) number = 2;
            }
            if (number % 10 == 3)
            {
                number += 10;
                if (number == 43) number = 3;
            }
            if (number % 10 == 4)
            {
                number += 10;
                if (number == 44) number = 4;
            }
            if (number % 10 == 5)
            {
                number += 10;
                if (number == 25) number = 5;
            }
            if (number % 10 == 6)
            {
                number += 10;
                if (number == 26) number = 6;
            }
            if (number % 10 == 7)
            {
                number += 10;
                if (number == 47) number = 7;
            }
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
                    score += 10;
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