// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, guys!");
Console.WriteLine("Отгадайте число от 0 до 50");

Random n = new Random();
int x = n.Next(50);

int y = Convert.ToInt32(Console.ReadLine());

    if (x == y)
    {
        Console.WriteLine("Вы отгадали число");
    }
    else
{
    Console.WriteLine("Вы не угадали число");
}







