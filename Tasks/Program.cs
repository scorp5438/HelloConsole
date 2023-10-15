// Collatz Conjecture (3n+1)

// int number = new Random().Next(3, 20);
// int hotpo(int number)
// {      
//     int count = 0;
//     while(number != 1)
//     {
//         if(number % 2 == 0)
//         {
//             number /= 2;
//         }
//         else
//         {
//             number = (number * 3) + 1;
//         }
//         count += 1;
//     }
//     return count;
// }

// Console.WriteLine($"{number}\n");

// int result = hotpo(number);
// Console.WriteLine(result);


// Simple Fun #261: Whose Move


// string WhoseMove(string lastPlayer, bool win)
// {
    
//     if((lastPlayer == "white") && (win == true))
//     {
//         lastPlayer = "white";
//     }
//     else if((lastPlayer == "white") && (win == false))
//     {
//         lastPlayer = "black";
//     }
//     else if((lastPlayer == "black") && (win == true))
//     {
//         lastPlayer = "black";
//     }
//     else if((lastPlayer == "black") && (win == false))
//     {
//         lastPlayer = "white";
//     }
//     return lastPlayer;
// }

// string result = WhoseMove("black", false);
// // Console.WriteLine(result);


// // Wilson primes

// double p = 5;

// double HZ(double p)
// {
//     double res = 1;
//     for(double z = 1; z <= p - 1; z ++)
//     {
//         res *= z;
//     }
//     return res;
// }
// double result = HZ(p);

// if((result + 1) % (p * p) == 0)
// {
//     Console.WriteLine(true);
// }
// else
// {
//     Console.WriteLine(false);
// }

int a = 798;

int z = (int)Char.GetNumericValue(a.ToString()[1]);

int r = int.Parse(a.ToString()[1].ToString());

Console.WriteLine($"Тип данных переменной z равной {z}: {z.GetTypeCode()}");
Console.WriteLine($"Тип данных переменной z равной {r}: {r.GetTypeCode()}");
