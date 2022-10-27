Console.Write("Enter User name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Wow, Hello, Masha!");
}
else
{
    Console.Write("Hello,");
    Console.WriteLine(username);
}