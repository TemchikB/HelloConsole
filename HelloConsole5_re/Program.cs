Console.Write("Ведите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Маша, пять рублей и ты наша");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
