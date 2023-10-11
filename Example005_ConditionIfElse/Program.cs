Console.WriteLine("Введите ваше имя: ");
string name = Console.ReadLine();
if (name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша");  
}
else
{
    Console.WriteLine("Привет, " + name);
}

