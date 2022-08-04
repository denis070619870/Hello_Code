Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Денис")
{
    Console.WriteLine("Добро пожаловать, Денис!");
}
else
{
    Console.Write("Привет!");
    Console.WriteLine(username);
}
