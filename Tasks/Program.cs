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

// int a = 798;

// int z = (int)Char.GetNumericValue(a.ToString()[1]);

// int r = int.Parse(a.ToString()[1].ToString());

// Console.WriteLine($"Тип данных переменной z равной {z}: {z.GetTypeCode()}");
// Console.WriteLine($"Тип данных переменной z равной {r}: {r.GetTypeCode()}");

// int p = (a / 10) % 10;

// Console.WriteLine(p);

// int temp  = 49;


// if(temp % 10 > temp / 10)
// {
//     Console.WriteLine(temp % 10);
// }
// else
//     Console.WriteLine(temp / 10);


// Reversed Strings

// string str = "World";
// string res = "";
// for (int i = str.Count() - 1; i > - 1; i -= 1)
// {
//     res += str[i];
// }
// Console.WriteLine(res);

// Remove First and Last Characte

// string str = "ofgodfgdk";
// int i = 0;
// string res = "";
// while(i < str.Length)
// {
//     if (i != 0 && i != str.Length - 1)
//     {
//         res += str[i];
//     }
//     i++;
// } 
// Console.WriteLine(res);


// Square(n) Sum

// int[] array = { 1, 2, 2 };
// int res = 0;
// foreach(int i in array)
// {
//     res += i * i;
// }
// Console.WriteLine(res);


// String repeat

// string s = ("#");
// int n = 5;
// int i = 1;
// string res = "";
// while(i <= n)
// {
//     res = res + s;
//     i++;
// }


// // string res = string.Concat(Enumerable.Repeat(s , n));
// Console.WriteLine(res);


// Grasshopper - Summation

// int num = 100;
// int i = 1;
// int res = 0;
// while(i <= num)
// {
//     res += i;
//     i++;
// }
// Console.WriteLine(res);


// Remove String Spaces

// string input = "апвап вава  ва в ва ";

// string res = input.Replace(" ","");

// Console.WriteLine(res);


// Counting sheep...

// var sheeps = new bool[] { true, false, true, false, true, false, true, false, true, false, true };

// int i = 0;
// int res = 0;
// while(i < sheeps.Length)
// {
//     if(sheeps[i])
//     {
//         res++;
//     }
//     i++;
// }
// Console.WriteLine(res);


// Basic Mathematical Operations

// char operation = '/';
// double value1 = 49;
// double value2 = 7;
// double res = 0;
// if(operation == '+')
// {
//     res = value1 + value2;
// }
// if(operation == '-')
// {
//     res = value1 - value2;
// }
// if(operation == '*')
// {
//     res = value1 * value2;
// }
// if(operation == '/')
// {
//     res = value1 / value2;
// }
// Console.WriteLine(res);


// Keep Hydrated!

// double time = 6.7;

// double temp = time * 0.5;

// Console.WriteLine(Convert.ToInt32(Math.Floor(temp)));


// Century From Year

// int year = 1801;
// if(year % 100 == 0)
// {
//     Console.WriteLine(year / 100);
// }
// else
// {
//     Console.WriteLine(year / 100 + 1);
// }


// Abbreviate a Two Word Name

// string name = "patrick feenan";

// // string res = name.ToUpper()[0] + "." + name.ToUpper()[name.IndexOf(" ") + 1];

// string[] temp = name.Split(new char[] {' '});
// string res = string.Join('.', temp[0][0], temp[1][0]).ToUpper();

// Console.WriteLine(res);


// Convert number to reversed array of digits

// int n = 35231;

// string str = n.ToString();

// long[] numbers = new long[str.Length];
// int index = 0;
// for (int i = str.Length - 1; i > -1; i -= 1)
// {
//     numbers[index] = Convert.ToUInt32(str[i].ToString());
//     index += 1;
// }
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"{numbers[i]} ");
// }

// A Needle in the Haystack

// string[] arr = {"hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"};
// int res= Array.IndexOf(arr, "needle");
// Console.WriteLine(res);

// double[] array = { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };

// double res = array.Sum();

// Console.WriteLine(array.Average());


// Simple remove duplicates

// int[] arr = {1, 5, 18, 6, 8, 9, 6, 5, 8, 7, 1, 172, 3, 2};


// int[] temp = arr.Reverse().ToArray();
// int[] temp2 = temp.Distinct().ToArray();
// int[] res = temp2.Reverse().ToArray();
// Console.WriteLine(res[0]);


// Vowel Count

// string str = "abracadabra";
// int vowelCount = 0;
// for(int i = 0; i < str.Length; i++)
// {
//     switch(str[i])
//     {
//         case 'a':
//         case 'e':
//         case 'i':
//         case 'o':
//         case 'u':
//         vowelCount++;
//         break;
//     }
// }


// Disemvowel Trolls

// string str = "What are you, a communist?";
// int i = 0;
// while(i < str.Length)
// {
//     switch(str.ToLower()[i])
//     {
//     case 'a':
//     case 'e':
//     case 'i':
//     case 'o':
//     case 'u':
//         str = str.Replace(str[i], '0');
//         i--;
//         break;
//     default:  
//         break;
//     }
//     i++;
// }
// str = str.Replace("0", "");

// Console.WriteLine(str);