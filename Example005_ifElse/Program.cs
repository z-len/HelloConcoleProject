Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "лена")
{
    Console.Write("Здравствуй, Леночка!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}