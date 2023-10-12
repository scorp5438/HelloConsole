int firstFrS = 1,
    secondFrS = 2,
    DogS = 5;
int distance = 10000;
int count = 0;
int frend = 2;
int time = 0;

while (distance > 10)
{
    if (frend == 1)
    {
        time = distance / (firstFrS + DogS);
        frend = 2;
    }
    else
    {
        time = distance / (secondFrS + DogS);
        frend = 1;
    }
    distance = distance - (firstFrS + secondFrS) * time;
    count += 1;
}
Console.WriteLine("Собака пробежит " + count + " раз(а)");